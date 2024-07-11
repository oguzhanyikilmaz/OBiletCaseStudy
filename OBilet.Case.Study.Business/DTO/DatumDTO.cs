using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.DTO
{
    public class DatumDTO
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "parent-id")]
        public int ParentId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "geo-location")]
        public GeoLocationDTO GeoLocation { get; set; }

        [JsonProperty(PropertyName = "zoom")]
        public int Zoom { get; set; }

        [JsonProperty(PropertyName = "tz-code")]
        public string TzCode { get; set; }

        [JsonProperty(PropertyName = "weather-code")]
        public object WeatherCode { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }

        [JsonProperty(PropertyName = "reference-code")]
        public string ReferenceCode { get; set; }

        [JsonProperty(PropertyName = "city-id")]
        public int CityId { get; set; }

        [JsonProperty(PropertyName = "reference-country")]
        public object ReferenceCountry { get; set; }

        [JsonProperty(PropertyName = "country-id")]
        public int CountryId { get; set; }

        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        [JsonProperty(PropertyName = "city-name")]
        public string CityName { get; set; }

        [JsonProperty(PropertyName = "languages")]
        public object Languages { get; set; }

        [JsonProperty(PropertyName = "country-name")]
        public string CountryName { get; set; }

        [JsonProperty(PropertyName = "code")]
        public object Code { get; set; }

        [JsonProperty(PropertyName = "show-country")]
        public bool ShowCountry { get; set; }

        [JsonProperty(PropertyName = "area-code")]
        public object AreaCode { get; set; }

        [JsonProperty(PropertyName = "long-name")]
        public string LongName { get; set; }

        [JsonProperty(PropertyName = "is-city-center")]
        public bool IsCityCenter { get; set; }

        [JsonProperty(PropertyName = "partner-id")]
        public int PartnerId { get; set; }

        [JsonProperty(PropertyName = "partner-name")]
        public string PartnerName { get; set; }

        [JsonProperty(PropertyName = "route-id")]
        public int RouteId { get; set; }

        [JsonProperty(PropertyName = "bus-type")]
        public string BusType { get; set; }

        [JsonProperty(PropertyName = "bus-type-name")]
        public string BusTypeName { get; set; }

        [JsonProperty(PropertyName = "total-seats")]
        public int TotalSeats { get; set; }

        [JsonProperty(PropertyName = "available-seats")]
        public int AvailableSeats { get; set; }

        [JsonProperty(PropertyName = "journey")]
        public JourneyDTO Journey { get; set; }

        [JsonProperty(PropertyName = "features")]
        public List<FeatureDTO> Features { get; set; }

        [JsonProperty(PropertyName = "origin-location")]
        public string OriginLocation { get; set; }

        [JsonProperty(PropertyName = "destination-location")]
        public string DestinationLocation { get; set; }

        [JsonProperty(PropertyName = "is-active")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "origin-location-id")]
        public int OriginLocationId { get; set; }

        [JsonProperty(PropertyName = "destination-location-id")]
        public int DestinationLocationId { get; set; }

        [JsonProperty(PropertyName = "is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty(PropertyName = "cancellation-offset")]
        public int CancellationOffset { get; set; }

        [JsonProperty(PropertyName = "has-bus-shuttle")]
        public bool HasBusShuttle { get; set; }

        [JsonProperty(PropertyName = "disable-sales-without-gov-id")]
        public bool DisableSalesWithoutGovId { get; set; }

        [JsonProperty(PropertyName = "display-offset")]
        public string DisplayOffset { get; set; }

        [JsonProperty(PropertyName = "partner-rating")]
        public double? PartnerRating { get; set; }

        [JsonProperty(PropertyName = "has-dynamic-pricing")]
        public bool HasDynamicPricing { get; set; }

        [JsonProperty(PropertyName = "disable-sales-without-hes-code")]
        public bool DisableSalesWithoutHesCode { get; set; }

        [JsonProperty(PropertyName = "disable-single-seat-selection")]
        public bool DisableSingleSeatSelection { get; set; }

        [JsonProperty(PropertyName = "change-offset")]
        public int ChangeOffset { get; set; }

        [JsonProperty(PropertyName = "display-coupon-code-input")]
        public bool DisplayCouponCodeInput { get; set; }

        [JsonProperty(PropertyName = "disable-sales-without-date-of-birth")]
        public bool DisableSalesWithoutDateOfBirth { get; set; }

        [JsonProperty(PropertyName = "open-offset")]
        public int OpenOffset { get; set; }

        [JsonProperty(PropertyName = "display-buffer")]
        public object DisplayBuffer { get; set; }

        [JsonProperty(PropertyName = "allow-sales-foreign-passenger")]
        public bool AllowSalesForeignPassenger { get; set; }

        [JsonProperty(PropertyName = "has-seat-selection")]
        public bool HasSeatSelection { get; set; }

        [JsonProperty(PropertyName = "branded-fares")]
        public List<object> BrandedFares { get; set; }

        [JsonProperty(PropertyName = "has-gender-selection")]
        public bool HasGenderSelection { get; set; }

        [JsonProperty(PropertyName = "has-dynamic-cancellation")]
        public bool HasDynamicCancellation { get; set; }

        [JsonProperty(PropertyName = "partner-terms-and-conditions")]
        public object PartnerTermsAndConditions { get; set; }

        [JsonProperty(PropertyName = "partner-available-alphabets")]
        public string PartnerAvailableAlphabets { get; set; }

        [JsonProperty(PropertyName = "provider-id")]
        public int ProviderId { get; set; }

        [JsonProperty(PropertyName = "partner-code")]
        public string PartnerCode { get; set; }

        [JsonProperty(PropertyName = "enable-full-journey-display")]
        public bool EnableFullJourneyDisplay { get; set; }

        [JsonProperty(PropertyName = "provider-name")]
        public string ProviderName { get; set; }

        [JsonProperty(PropertyName = "enable-all-stops-display")]
        public bool EnableAllStopsDisplay { get; set; }

        [JsonProperty(PropertyName = "is-destination-domestic")]
        public bool IsDestinationDomestic { get; set; }

        [JsonProperty(PropertyName = "min-len-gov-id")]
        public object MinLenGovId { get; set; }

        [JsonProperty(PropertyName = "max-len-gov-id")]
        public object MaxLenGovId { get; set; }

        [JsonProperty(PropertyName = "require-foreign-gov-id")]
        public bool RequireForeignGovId { get; set; }

        [JsonProperty(PropertyName = "is-cancellation-info-text")]
        public bool IsCancellationInfoText { get; set; }

        [JsonProperty(PropertyName = "cancellation-offset-info-text")]
        public object CancellationOffsetInfoText { get; set; }

        [JsonProperty(PropertyName = "is-time-zone-not-equal")]
        public bool IsTimeZoneNotEqual { get; set; }

        [JsonProperty(PropertyName = "markup-rate")]
        public double MarkupRate { get; set; }

        [JsonProperty(PropertyName = "is-print-ticket-before-journey")]
        public bool IsPrintTicketBeforeJourney { get; set; }

        [JsonProperty(PropertyName = "is-extended-journey-detail")]
        public bool IsExtendedJourneyDetail { get; set; }

        [JsonProperty(PropertyName = "is-payment-select-gender")]
        public bool IsPaymentSelectGender { get; set; }

        [JsonProperty(PropertyName = "should-turkey-on-the-nationality-list")]
        public bool ShouldTurkeyOnTheNationalityList { get; set; }

        [JsonProperty(PropertyName = "markup-fee")]
        public double MarkupFee { get; set; }

        [JsonProperty(PropertyName = "partner-nationality")]
        public object PartnerNationality { get; set; }

        [JsonProperty(PropertyName = "generate-barcode")]
        public bool GenerateBarcode { get; set; }

        [JsonProperty(PropertyName = "is-print-ticket-before-journey-badge")]
        public bool IsPrintTicketBeforeJourneyBadge { get; set; }

        [JsonProperty(PropertyName = "is-print-ticket-before-journey-mail")]
        public bool IsPrintTicketBeforeJourneyMail { get; set; }

        [JsonProperty(PropertyName = "is-show-fare-rules")]
        public bool IsShowFareRules { get; set; }

        [JsonProperty(PropertyName = "is-different-seat-price")]
        public bool IsDifferentSeatPrice { get; set; }

        [JsonProperty(PropertyName = "redirect-to-checkout")]
        public bool RedirectToCheckout { get; set; }

        [JsonProperty(PropertyName = "is-show-rating-avarage")]
        public bool IsShowRatingAvarage { get; set; }

        [JsonProperty(PropertyName = "partner-route-rating")]
        public double PartnerRouteRating { get; set; }

        [JsonProperty(PropertyName = "partner-route-rating-vote-count")]
        public int PartnerRouteRatingVoteCount { get; set; }

        [JsonProperty(PropertyName = "partner-rating-vote-count")]
        public int? PartnerRatingVoteCount { get; set; }
    }

}
