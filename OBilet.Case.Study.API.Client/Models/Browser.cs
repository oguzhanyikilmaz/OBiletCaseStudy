using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models
{
    public class Browser
    {
        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName="version")]
        public string Version { get; set; }
    }
}
