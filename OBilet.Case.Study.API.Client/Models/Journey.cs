using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Models
{
    public class Journey
    {
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "stops")]
        public List<Stop> Stops { get; set; }

        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }

        [JsonProperty(PropertyName = "departure")]
        public DateTime Departure { get; set; }

        [JsonProperty(PropertyName = "arrival")]
        public DateTime Arrival { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        [JsonProperty(PropertyName = "original-price")]
        public double OriginalPrice { get; set; }

        [JsonProperty(PropertyName = "internet-price")]
        public double InternetPrice { get; set; }

        [JsonProperty(PropertyName = "provider-internet-price")]
        public double? ProviderInternetPrice { get; set; }

        [JsonProperty(PropertyName = "booking")]
        public string Booking { get; set; }

        [JsonProperty(PropertyName = "bus-name")]
        public string BusName { get; set; }

        [JsonProperty(PropertyName = "policy")]
        public Policy Policy { get; set; }

        [JsonProperty(PropertyName = "features")]
        public List<string> Features { get; set; }

        [JsonProperty(PropertyName = "features-description")]
        public string FeaturesDescription { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "available")]
        public object Available { get; set; }

        [JsonProperty(PropertyName = "partner-provider-code")]
        public string PartnerProviderCode { get; set; }

        [JsonProperty(PropertyName = "peron-no")]
        public string PeronNo { get; set; }

        [JsonProperty(PropertyName = "partner-provider-id")]
        public int PartnerProviderId { get; set; }

        [JsonProperty(PropertyName = "is-segmented")]
        public bool IsSegmented { get; set; }

        [JsonProperty(PropertyName = "partner-name")]
        public string PartnerName { get; set; }

        [JsonProperty(PropertyName = "provider-code")]
        public string ProviderCode { get; set; }

        [JsonProperty(PropertyName = "sorting-price")]
        public double SortingPrice { get; set; }
    }
}
