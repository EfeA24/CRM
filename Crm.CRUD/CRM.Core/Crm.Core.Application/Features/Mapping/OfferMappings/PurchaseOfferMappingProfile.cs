using AutoMapper;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer;
using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.Mapping.OfferMappings
{
    public class PurchaseOfferMappingProfile : Profile
    {
        public PurchaseOfferMappingProfile()
        {
            CreateMap<PurchaseOffer, PurchaseOfferListResult>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName));

            CreateMap<PurchaseOffer, PurchaseOfferDetailResult>()
                .ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.Company.CompanyId))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                .ForMember(dest => dest.CompanyTag, opt => opt.MapFrom(src => src.Company.CompanyTag))
                .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.Company.CompanyType))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.PurchaseOfferProducts));

            CreateMap<PurchaseOfferProduct, PurchaseOfferProductListResult>()
                .ForMember(dest => dest.PurchaseOfferName, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferName))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.PurchaseOffer.Company.CompanyName));

            CreateMap<PurchaseOfferProduct, PurchaseOfferProductDetailResult>()
                .ForMember(dest => dest.PurchaseOfferId, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferId))
                .ForMember(dest => dest.PurchaseOfferName, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferName))
                .ForMember(dest => dest.PurchaseOfferNumber, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferNumber))
                .ForMember(dest => dest.PurchaseOfferStatus, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferStatus))
                .ForMember(dest => dest.PurchaseOfferCurrency, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferCurrency))
                .ForMember(dest => dest.PurchaseOfferTotalPrice, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferTotalPrice))
                .ForMember(dest => dest.PurchaseOfferDate, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferDate))
                .ForMember(dest => dest.PurchaseOfferDueDate, opt => opt.MapFrom(src => src.PurchaseOffer.PurchaseOfferDueDate))
                .ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.PurchaseOffer.Company.CompanyId))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.PurchaseOffer.Company.CompanyName))
                .ForMember(dest => dest.CompanyTag, opt => opt.MapFrom(src => src.PurchaseOffer.Company.CompanyTag))
                .ForMember(dest => dest.CompanyType, opt => opt.MapFrom(src => src.PurchaseOffer.Company.CompanyType));
        }
    }
