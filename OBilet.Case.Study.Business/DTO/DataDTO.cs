using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO
{
    public class DataDTO
    {
        [JsonProperty(PropertyName="session-id")]
        public string SessionId { get; set; }

        [JsonProperty(PropertyName="device-id")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName="affiliate")]
        public object Affiliate { get; set; }

        [JsonProperty(PropertyName="device-type")]
        public int DeviceType { get; set; }

        [JsonProperty(PropertyName="device")]
        public object Device { get; set; }

        [JsonProperty(PropertyName="ip-country")]
        public string IpCountry { get; set; }

        [JsonProperty(PropertyName="origin-id")]
        public int OriginId { get; set; }

        [JsonProperty(PropertyName="destination-id")]
        public int DestinationId { get; set; }

        [JsonProperty(PropertyName="departure-date")]
        public string DepartureDate { get; set; }
    }
}
