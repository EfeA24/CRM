using AutoMapper;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer;
using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.Mapping.OfferMappings
{
    public class SaleOfferMappingProfile : Profile
    {
        public SaleOfferMappingProfile()
        {
            CreateMap<SalesOffer, SalesOfferListResult>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName));

            CreateMap<SalesOffer, SalesOfferDetailResult>()
                .ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.Company.CompanyId))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                .ForMember(dest => dest.CompanyTag, opt => opt.MapFrom(src => src.Company.CompanyTag))
                .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.Company.CompanyType))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.SalesOfferProducts));

            CreateMap<SalesOfferProduct, SalesOfferProductListResult>()
                .ForMember(dest => dest.SalesOfferName, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferName))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.SalesOffer.Company.CompanyName));

            CreateMap<SalesOfferProduct, SalesOfferProductDetailResult>()
                .ForMember(dest => dest.SalesOfferId, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferId))
                .ForMember(dest => dest.SalesOfferName, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferName))
                .ForMember(dest => dest.SalesOfferNumber, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferNumber))
                .ForMember(dest => dest.SalesOfferStatus, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferStatus))
                .ForMember(dest => dest.SalesOfferType, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferType))
                .ForMember(dest => dest.SalesOfferPriority, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferPriority))
                .ForMember(dest => dest.SalesOfferDate, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferDate))
                .ForMember(dest => dest.SalesOfferDueDate, opt => opt.MapFrom(src => src.SalesOffer.SalesOfferDueDate))
                .ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.SalesOffer.Company.CompanyId))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.SalesOffer.Company.CompanyName))
                .ForMember(dest => dest.CompanyTag, opt => opt.MapFrom(src => src.SalesOffer.Company.CompanyTag))
                .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.SalesOffer.Company.CompanyType));
        }
    }
}
