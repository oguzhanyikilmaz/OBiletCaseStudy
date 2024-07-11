using AutoMapper;
using Microsoft.Extensions.Logging;
using OBilet.Case.Study.API.Client.Abstract;
using OBilet.Case.Study.API.Client.Models.RequestModels;
using OBilet.Case.Study.Business.Abstractions;
using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO.ResponseModels;

namespace OBilet.Case.Study.Business.Services
{
    public class AuthService : IAuthService
    {
        #region FieldsAndProps

        private readonly IOBiletService _oBiletService;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthService> _logger;

        #endregion

        #region Ctors

        public AuthService(IOBiletService oBiletService, IMapper mapper, ILogger<AuthService> logger)
        {
            _oBiletService = oBiletService;
            _mapper = mapper;
            _logger = logger;
        }
        #endregion

        #region Methods

        /// <summary>
        /// İlgili servisin Auth işlemlerini gerçekleştirir.
        /// </summary>
        /// <param name="getSessionRequestModel"></param>
        /// <returns></returns>
        public async Task<GetSessionResponseModelDTO> GetSession(GetSessionRequestModelDTO getSessionRequestModel)
        {
            try
            {
                var request = _mapper.Map<GetSessionRequestModel>(getSessionRequestModel);

                var response = await _oBiletService.GetSession(request);

                var result = _mapper.Map<GetSessionResponseModelDTO>(response);

                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, getSessionRequestModel);

                return await Task.FromResult(new GetSessionResponseModelDTO());

            }

        }

        #endregion

    }
}
