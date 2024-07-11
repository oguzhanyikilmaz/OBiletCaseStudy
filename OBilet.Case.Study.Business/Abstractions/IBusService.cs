using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.Abstractions
{
    public interface IBusService
    {
        Task<GetBusLocationsResponseModelDTO> GetBusLocations(GetBusLocationsRequestModelDTO getBusLocationsRequestModel);
        Task<GetBusJourneysResponseModelDTO> GetBusJourneys(GetBusJourneysRequestModelDTO getBusJourneysRequestModel);
    }
}
