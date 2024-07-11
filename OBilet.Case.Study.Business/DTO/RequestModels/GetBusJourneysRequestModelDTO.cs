using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO.RequestModels
{
    public class GetBusJourneysRequestModelDTO
    {
        [JsonProperty(PropertyName="device-session")]
        public DeviceSessionDTO DeviceSession { get; set; }

        [JsonProperty(PropertyName="date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName="language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName="data")]
        public DataDTO Data { get; set; }
    }
}
