using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO
{
    public class StopDTO
    {
        [JsonProperty(PropertyName="id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName="kolayCarLocationId")]
        public int? KolayCarLocationId { get; set; }

        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName="station")]
        public string Station { get; set; }

        [JsonProperty(PropertyName="time")]
        public DateTime? Time { get; set; }

        [JsonProperty(PropertyName="is-origin")]
        public bool IsOrigin { get; set; }

        [JsonProperty(PropertyName="is-destination")]
        public bool IsDestination { get; set; }

        [JsonProperty(PropertyName="is-segment-stop")]
        public bool IsSegmentStop { get; set; }

        [JsonProperty(PropertyName="index")]
        public int Index { get; set; }

        [JsonProperty(PropertyName="obilet-station-id")]
        public object ObiletStationId { get; set; }

        [JsonProperty(PropertyName="map-url")]
        public object MapUrl { get; set; }
    }

}
