using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO
{
    public class FeatureDTO
    {
        [JsonProperty(PropertyName="id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName="priority")]
        public int? Priority { get; set; }

        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName="description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName="is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty(PropertyName="back-color")]
        public string BackColor { get; set; }

        [JsonProperty(PropertyName="fore-color")]
        public string ForeColor { get; set; }

        [JsonProperty(PropertyName="partner-notes")]
        public object PartnerNotes { get; set; }
    }
}
