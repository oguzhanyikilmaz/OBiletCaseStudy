using Microsoft.AspNetCore.Mvc;
using OBilet.Case.Study.API.Client.Extensions;
using OBilet.Case.Study.Business.Abstractions;
using OBilet.Case.Study.Business.DTO;
using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO.ResponseModels;
using OBilet.Case.Study.Web.Extensions;
using OBilet.Case.Study.Web.Helpers;
using OBilet.Case.Study.Web.Models;
using System.Diagnostics;

namespace OBilet.Case.Study.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBusService _busService;
        private readonly IAuthService _authService;
        private readonly IRedisService _redisService;

        public HomeController(ILogger<HomeController> logger,
            IBusService busService,
            IAuthService authService,
            IRedisService redisService)
        {
            _logger = logger;
            _busService = busService;
            _authService = authService;
            _redisService = redisService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                GetSessionResponseModelDTO getSessionResponse = new GetSessionResponseModelDTO();

                var redisGetSessionResponseValue = await _redisService.GetValueAsync($"{HttpContext.Session.Id}-OBiletSession");

                if (!string.IsNullOrEmpty(redisGetSessionResponseValue))
                    getSessionResponse = redisGetSessionResponseValue.ToObject<GetSessionResponseModelDTO>();
                else
                {
                    var getSessionRequestModel = CHelper.CreateGetSessionRequestModel(HttpContext);
                    getSessionResponse = await _authService.GetSession(getSessionRequestModel);

                    TimeSpan expiry = TimeSpan.FromMinutes(30);
                    await _redisService.SetValueAsync($"{HttpContext.Session.Id}-OBiletSession", getSessionResponse.ToJson(), expiry);
                }

                var getBusLocationsRequestModel = CHelper.CreateGetBusLocationsRequestModel(getSessionResponse);

                var busLocations = await _busService.GetBusLocations(getBusLocationsRequestModel);
                var model = CHelper.CreateJourneySearchViewModel(busLocations);

                var origin = HttpContext.Session.GetString("Origin");
                var destination = HttpContext.Session.GetString("Destination");
                var departureDate = HttpContext.Session.GetString("DepartureDate");

                if (!string.IsNullOrEmpty(origin) && !string.IsNullOrEmpty(destination) && !string.IsNullOrEmpty(departureDate))
                {
                    model.Origin = origin;
                    model.Destination = destination;
                    model.DepartureDate = departureDate;
                }


                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in the Index method.");
                return RedirectToAction("Error");
            }

        }

        [HttpPost]
        public IActionResult Search(JourneySearchViewModel model)
        {
            try
            {
                if (model.Origin == model.Destination)
                {
                    ModelState.AddModelError("", "Kalkýþ ve varýþ noktalarý ayný olamaz.");
                    return View("Index", model);
                }

                HttpContext.Session.SetString("Origin", model.Origin);
                HttpContext.Session.SetString("Destination", model.Destination);
                HttpContext.Session.SetString("DepartureDate", model.DepartureDate);

                return RedirectToAction("JourneyIndex", new { model.Origin, model.Destination, model.DepartureDate });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in the Search method.");
                return RedirectToAction("Error");
            }

        }

        public async Task<IActionResult> JourneyIndex(string origin, string destination, string departureDate)
        {
            try
            {
                GetSessionResponseModelDTO getSessionResponse = new GetSessionResponseModelDTO();

                var redisGetSessionResponseValue = await _redisService.GetValueAsync($"{HttpContext.Session.Id}-OBiletSession");

                if (!string.IsNullOrEmpty(redisGetSessionResponseValue))
                    getSessionResponse = redisGetSessionResponseValue.ToObject<GetSessionResponseModelDTO>();
                else
                {
                    var getSessionRequestModel = CHelper.CreateGetSessionRequestModel(HttpContext);
                    getSessionResponse = await _authService.GetSession(getSessionRequestModel);

                    TimeSpan expiry = TimeSpan.FromMinutes(30);
                    await _redisService.SetValueAsync($"{HttpContext.Session.Id}-OBiletSession", getSessionResponse.ToJson(), expiry);
                }

                var getBusJourneysRequestModel = CHelper.CreateGetBusJourneysRequestModel(getSessionResponse, origin, destination, departureDate);

                var journeysResponse = await _busService.GetBusJourneys(getBusJourneysRequestModel);

                var journeyList = journeysResponse.Data.Select(journey => new Journey
                {
                    ArrivalTime = journey.Journey.Arrival.ToString().ExtractTime(),
                    BusCompany = !string.IsNullOrEmpty(journey.PartnerName) ? journey.PartnerName.ToString() : "Firma adý boþ",
                    DepartureTime = journey.Journey.Departure.ToString().ExtractTime(),
                    Id = journey.Id.ToString(),
                    Destination = journey.Journey.Destination,
                    Origin = journey.Journey.Origin,
                    Price = journey.Journey.OriginalPrice.ToString(),
                }).ToList();

                var model = new JourneyIndexViewModel
                {
                    Origin = origin,
                    OriginLocation = journeysResponse.Data.FirstOrDefault(x => !string.IsNullOrEmpty(x.OriginLocation)).OriginLocation,
                    Destination = destination,
                    DestinationLocation = journeysResponse.Data.FirstOrDefault(x => !string.IsNullOrEmpty(x.DestinationLocation)).DestinationLocation,
                    DepartureDate = departureDate.ConvertDate(),
                    Journeys = journeyList
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in the JourneyIndex method.");
                return RedirectToAction("Error");
            }

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
