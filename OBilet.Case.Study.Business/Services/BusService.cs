using AutoMapper;
using Microsoft.Extensions.Logging;
using OBilet.Case.Study.API.Client.Abstract;
using OBilet.Case.Study.API.Client.Models.RequestModels;
using OBilet.Case.Study.Business.Abstractions;
using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO.ResponseModels;

namespace OBilet.Case.Study.Business.Services
{
    public class BusService : IBusService
    {
        #region FieldsAndProps

        private readonly IOBiletService _oBiletService;
        private readonly IMapper _mapper;
        private readonly ILogger<BusService> _logger;
        #endregion

        #region Ctors
        public BusService(IOBiletService oBiletService, IMapper mapper, ILogger<BusService> logger)
        {
            _oBiletService = oBiletService;
            _mapper = mapper;
            _logger = logger;
        }
        #endregion

        #region Methods

        /// <summary>
        /// İlgili servisten sefer bilgilerini çeker.
        /// </summary>
        /// <param name="getBusJourneysRequestModel"></param>
        /// <returns></returns>
        public async Task<GetBusJourneysResponseModelDTO> GetBusJourneys(GetBusJourneysRequestModelDTO getBusJourneysRequestModel)
        {
            try
            {
                var request = _mapper.Map<GetBusJourneysRequestModel>(getBusJourneysRequestModel);

                var response = await _oBiletService.GetBusJourneys(request);

                var result = _mapper.Map<GetBusJourneysResponseModelDTO>(response);

                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, getBusJourneysRequestModel);

                return await Task.FromResult(new GetBusJourneysResponseModelDTO());

            }

        }

        /// <summary>
        /// İlgili servisten lokasyon bilgileri çeker.
        /// </summary>
        /// <param name="getBusLocationsRequestModel"></param>
        /// <returns></returns>
        public async Task<GetBusLocationsResponseModelDTO> GetBusLocations(GetBusLocationsRequestModelDTO getBusLocationsRequestModel)
        {
            try
            {
                var request = _mapper.Map<GetBusLocationsRequestModel>(getBusLocationsRequestModel);

                var response = await _oBiletService.GetBusLocations(request);

                var result = _mapper.Map<GetBusLocationsResponseModelDTO>(response);

                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, getBusLocationsRequestModel);

                return await Task.FromResult(new GetBusLocationsResponseModelDTO());

            }

        }

        #endregion
    }
}
