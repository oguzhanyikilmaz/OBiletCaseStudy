using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO.RequestModels
{
    public class GetBusLocationsRequestModelDTO
    {
        [JsonProperty(PropertyName="data")]
        public string Data { get; set; }

        [JsonProperty(PropertyName="device-session")]
        public DeviceSessionDTO DeviceSession { get; set; }

        [JsonProperty(PropertyName="date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName="language")]
        public string Language { get; set; }
    }
}
