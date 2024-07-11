using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models.RequestModels
{
    public class GetSessionRequestModel
    {
        [JsonProperty(PropertyName="type")]
        public int Type { get; set; }

        [JsonProperty(PropertyName="connection")]
        public Connection Connection { get; set; }

        [JsonProperty(PropertyName="browser")]
        public Browser Browser { get; set; }
    }
}
