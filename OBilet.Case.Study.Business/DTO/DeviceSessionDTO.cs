using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO
{
    public class DeviceSessionDTO
    {
        [JsonProperty(PropertyName="session-id")]
        public string SessionId { get; set; }

        [JsonProperty(PropertyName="device-id")]
        public string DeviceId { get; set; }
    }
}
