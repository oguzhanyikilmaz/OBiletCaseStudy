using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models.RequestModels
{
    public class GetBusLocationsRequestModel
    {
        [JsonProperty(PropertyName="data")]
        public string Data { get; set; }

        [JsonProperty(PropertyName="device-session")]
        public DeviceSession DeviceSession { get; set; }

        [JsonProperty(PropertyName="date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName="language")]
        public string Language { get; set; }
    }
}
