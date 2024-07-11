using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO.RequestModels
{
    public class GetSessionRequestModelDTO
    {
        [JsonProperty(PropertyName="type")]
        public int Type { get; set; }

        [JsonProperty(PropertyName="connection")]
        public ConnectionDTO Connection { get; set; }

        [JsonProperty(PropertyName="browser")]
        public BrowserDTO Browser { get; set; }
    }
}
