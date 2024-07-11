using OBilet.Case.Study.API.Client.Models.RequestModels;
using OBilet.Case.Study.API.Client.Models.ResponseModels;
using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.Abstractions
{
    public interface IAuthService
    {
        Task<GetSessionResponseModelDTO> GetSession(GetSessionRequestModelDTO getSessionRequestModel);
    }
}
