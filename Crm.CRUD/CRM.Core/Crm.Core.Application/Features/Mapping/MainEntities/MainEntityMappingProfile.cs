using AutoMapper;
using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using Crm.Core.Domain.Entities.MainEntities;

namespace Crm.Core.Application.Features.Mapping.MainEntities
{
    public class MainEntityMappingProfile : Profile
    {
        public MainEntityMappingProfile()
        {
            CreateMap<Contact, ContactListResult>();
            CreateMap<Contact, ContactDetailResult>()
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company));
            CreateMap<Contact, ContactSummaryResult>();

            CreateMap<Company, CompanyListResult>()
                .ForMember(dest => dest.ContactLists, opt => opt.MapFrom(src => src.Contacts));
            CreateMap<Company, CompanyDetailResult>()
                .ForMember(dest => dest.ContactLists, opt => opt.MapFrom(src => src.Contacts));
            CreateMap<Company, CompanySummaryResult>();

            CreateMap<Meeting, MeetingListResult>()
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company))
                .ForMember(dest => dest.Contact, opt => opt.MapFrom(src => src.Contact));
            CreateMap<Meeting, MeetingDetailResult>()
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company))
                .ForMember(dest => dest.Contact, opt => opt.MapFrom(src => src.Contact));
        }
    }
}
