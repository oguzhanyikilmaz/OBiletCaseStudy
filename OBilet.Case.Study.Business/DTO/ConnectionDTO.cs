using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO
{
    public class ConnectionDTO
    {
        [JsonProperty(PropertyName="ip-address")]
        public string IpAddress { get; set; }

        [JsonProperty(PropertyName="port")]
        public string Port { get; set; }
    }
}
