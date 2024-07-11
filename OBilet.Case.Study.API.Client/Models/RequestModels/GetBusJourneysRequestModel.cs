using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models.RequestModels
{
    public class GetBusJourneysRequestModel
    {
        [JsonProperty(PropertyName="device-session")]
        public DeviceSession DeviceSession { get; set; }

        [JsonProperty(PropertyName="date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName="language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName="data")]
        public Data Data { get; set; }
    }
}
