using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models
{
    public class Policy
    {
        [JsonProperty(PropertyName="max-seats")]
        public object MaxSeats { get; set; }

        [JsonProperty(PropertyName="max-single")]
        public int? MaxSingle { get; set; }

        [JsonProperty(PropertyName="max-single-males")]
        public int? MaxSingleMales { get; set; }

        [JsonProperty(PropertyName="max-single-females")]
        public int? MaxSingleFemales { get; set; }

        [JsonProperty(PropertyName="mixed-genders")]
        public bool MixedGenders { get; set; }

        [JsonProperty(PropertyName="gov-id")]
        public bool GovId { get; set; }

        [JsonProperty(PropertyName="lht")]
        public bool Lht { get; set; }
    }

}
