using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO.ResponseModels
{
    public class GetBusJourneysResponseModelDTO
    {
        [JsonProperty(PropertyName="status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName="data")]
        public List<DatumDTO> Data { get; set; }

        [JsonProperty(PropertyName="message")]
        public object Message { get; set; }

        [JsonProperty(PropertyName="user-message")]
        public object UserMessage { get; set; }

        [JsonProperty(PropertyName="api-request-id")]
        public object ApiRequestId { get; set; }

        [JsonProperty(PropertyName="controller")]
        public string Controller { get; set; }

        [JsonProperty(PropertyName="client-request-id")]
        public object ClientRequestId { get; set; }

        [JsonProperty(PropertyName="web-correlation-id")]
        public object WebCorrelationId { get; set; }

        [JsonProperty(PropertyName="correlation-id")]
        public string CorrelationId { get; set; }

        [JsonProperty(PropertyName="parameters")]
        public object Parameters { get; set; }
    }
}
