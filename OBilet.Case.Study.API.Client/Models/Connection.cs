using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models
{
    public class Connection
    {
        [JsonProperty(PropertyName="ip-address")]
        public string IpAddress { get; set; }

        [JsonProperty(PropertyName="port")]
        public string Port { get; set; }
    }
}
