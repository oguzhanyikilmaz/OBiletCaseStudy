using AutoMapper;
using OBilet.Case.Study.API.Client.Models;
using OBilet.Case.Study.API.Client.Models.RequestModels;
using OBilet.Case.Study.API.Client.Models.ResponseModels;
using OBilet.Case.Study.Business.DTO;
using OBilet.Case.Study.Business.DTO.RequestModels;
using OBilet.Case.Study.Business.DTO.ResponseModels;

namespace OBilet.Case.Study.Business.Utilities
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<Browser, BrowserDTO>().ReverseMap();
                CreateMap<Connection, ConnectionDTO>().ReverseMap();
                CreateMap<Data, DataDTO>().ReverseMap();
                CreateMap<Datum, DatumDTO>().ReverseMap();
                CreateMap<DeviceSession, DeviceSessionDTO>().ReverseMap();
                CreateMap<Feature, FeatureDTO>().ReverseMap();
                CreateMap<GeoLocation, GeoLocationDTO>().ReverseMap();
                CreateMap<Journey, JourneyDTO>().ReverseMap();
                CreateMap<Policy, PolicyDTO>().ReverseMap();
                CreateMap<Stop, StopDTO>().ReverseMap();
                CreateMap<GetBusJourneysRequestModel, GetBusJourneysRequestModelDTO>().ReverseMap();
                CreateMap<GetBusLocationsRequestModel, GetBusLocationsRequestModelDTO>().ReverseMap();
                CreateMap<GetSessionRequestModel, GetSessionRequestModelDTO>().ReverseMap();
                CreateMap<GetBusJourneysResponseModel, GetBusJourneysResponseModelDTO>().ReverseMap();
                CreateMap<GetBusLocationsResponseModel, GetBusLocationsResponseModelDTO>().ReverseMap();
                CreateMap<GetSessionResponseModel, GetSessionResponseModelDTO>().ReverseMap();
            }
        }
    }
}
