using OBilet.Case.Study.API.Client.Abstract;
using OBilet.Case.Study.API.Client.Helpers;
using OBilet.Case.Study.API.Client.Models.RequestModels;
using OBilet.Case.Study.API.Client.Models.ResponseModels;
using RestSharp;

namespace OBilet.Case.Study.API.Client.Concrete
{
    public class OBiletService : IOBiletService
    {
        #region FieldsAndProps
        private readonly RestHelper _restHelper;
        #endregion

        #region Ctors
        public OBiletService()
        {
            _restHelper = new RestHelper("https://v2-api.obilet.com");
        }
        #endregion

        #region Methods

        #region PublicMethods

        /// <summary>
        /// OBilet API ile iletişime geçerek sefer bilgilerini çeker.
        /// </summary>
        /// <param name="getBusJourneysRequestModel"></param>
        /// <returns></returns>
        public async Task<GetBusJourneysResponseModel> GetBusJourneys(GetBusJourneysRequestModel getBusJourneysRequestModel)
        {

            var response = _restHelper.Execute<GetBusJourneysResponseModel>("/api/journey/getbusjourneys", Method.Post, getBusJourneysRequestModel, "GetBusJourneys");

            return await Task.FromResult(response);
        }

        /// <summary>
        /// OBilet API ile iletişime geçerek lokasyon bilgileri alır.
        /// </summary>
        /// <param name="getBusLocationsRequestModel"></param>
        /// <returns></returns>
        public async Task<GetBusLocationsResponseModel> GetBusLocations(GetBusLocationsRequestModel getBusLocationsRequestModel)
        {
            var response = _restHelper.Execute<GetBusLocationsResponseModel>("/api/location/getbuslocations", Method.Post, getBusLocationsRequestModel, "GetBusLocations");

            return await Task.FromResult(response);
        }

        /// <summary>
        /// OBilet API ile iletişime geçerek istekler için Session bilgisi alır.
        /// </summary>
        /// <param name="getSessionRequestModel"></param>
        /// <returns></returns>
        public async Task<GetSessionResponseModel> GetSession(GetSessionRequestModel getSessionRequestModel)
        {
            var response = _restHelper.Execute<GetSessionResponseModel>("/api/client/getsession", Method.Post, getSessionRequestModel, "GetSession");

            return await Task.FromResult(response);
        }

        #endregion

        #endregion

    }
}
