using Newtonsoft.Json.Linq;
using OBilet.Case.Study.API.Client.Models.RequestModels;
using OBilet.Case.Study.API.Client.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Abstract
{
    public interface IOBiletService
    {
        Task<GetSessionResponseModel> GetSession(GetSessionRequestModel getSessionRequestModel);
        Task<GetBusLocationsResponseModel> GetBusLocations(GetBusLocationsRequestModel getBusLocationsRequestModel);
        Task<GetBusJourneysResponseModel> GetBusJourneys(GetBusJourneysRequestModel getBusJourneysRequestModel);
    }
}
