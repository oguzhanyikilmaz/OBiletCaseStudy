using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO;
using OBilet.Case.Study.Web.Models;
using OBilet.Case.Study.Business.DTO.ResponseModels;
using System.Globalization;

namespace OBilet.Case.Study.Web.Helpers
{
    public static class CHelper
    {
        #region Methods

        /// <summary>
        /// Servisten session verisi almak için yollanacak request modeli oluşturur.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public static GetSessionRequestModelDTO CreateGetSessionRequestModel(HttpContext httpContext)
        {
            var ipAddress = httpContext.Connection.RemoteIpAddress.ToString();
            var userAgent = httpContext.Request.Headers["User-Agent"].ToString();
            var browser = BrowserHelper.GetBrowserInfo(userAgent);

            return new GetSessionRequestModelDTO()
            {
                Browser = new BrowserDTO() { Name = browser.Name, Version = browser.Version },
                Connection = new ConnectionDTO() { IpAddress = ipAddress, Port = "5117" },
                Type = 1
            };
        }

        /// <summary>
        /// Servisten lokasyon verisi almak için yollanacak request modeli oluşturur.
        /// </summary>
        /// <param name="getSessionResponse"></param>
        /// <returns></returns>
        public static GetBusLocationsRequestModelDTO CreateGetBusLocationsRequestModel(GetSessionResponseModelDTO getSessionResponse)
        {
            return new GetBusLocationsRequestModelDTO()
            {
                Data = null,
                Date = DateTime.Now,
                Language = "tr-TR",
                DeviceSession = new DeviceSessionDTO() { DeviceId = getSessionResponse.Data.DeviceId, SessionId = getSessionResponse.Data.SessionId }
            };
        }

        /// <summary>
        /// Servisten sefer verisi almak için yollanacak request modeli oluşturur.
        /// </summary>
        /// <param name="getSessionResponse"></param>
        /// <param name="origin"></param>
        /// <param name="destination"></param>
        /// <param name="departureDate"></param>
        /// <returns></returns>
        public static GetBusJourneysRequestModelDTO CreateGetBusJourneysRequestModel(GetSessionResponseModelDTO getSessionResponse, string origin, string destination, string departureDate)
        {
            GetBusJourneysRequestModelDTO getBusJourneysRequestModel = new GetBusJourneysRequestModelDTO()
            {
                Data = new DataDTO() { OriginId = Convert.ToInt32(origin), DestinationId = Convert.ToInt32(destination), DepartureDate = departureDate },
                Date = DateTime.Now.ToString(),
                Language = "tr-TR",
                DeviceSession = new DeviceSessionDTO() { DeviceId = getSessionResponse.Data.DeviceId, SessionId = getSessionResponse.Data.SessionId }
            };

            return getBusJourneysRequestModel;
        }

        /// <summary>
        /// Servisten alınan lokasyon verisini son kullanıcıya göstermek için ViewModel oluşturur.
        /// </summary>
        /// <param name="busLocations"></param>
        /// <returns></returns>
        public static JourneySearchViewModel CreateJourneySearchViewModel(GetBusLocationsResponseModelDTO busLocations)
        {
            var locations = busLocations.Data.Select(location => new Location
            {
                Id = location.Id.ToString(),
                Name = location.Name
            }).ToList();

            return new JourneySearchViewModel
            {
                Locations = locations,
                DepartureDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")
            };
        }

        #endregion
    }
}
