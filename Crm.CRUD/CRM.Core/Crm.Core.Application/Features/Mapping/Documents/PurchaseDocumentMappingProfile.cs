using AutoMapper;
using Crm.Core.Application.Features.CQRS.Results.DocumentResults.PurchaseDocuments;
using Crm.Core.Domain.Entities.DocumentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.Mapping.Documents
{
    public class PurchaseDocumentMappingProfile : Profile
    {
        public PurchaseDocumentMappingProfile()
        {
            CreateMap<PurchaseOfferDocument, PurchaseOfferDocumentResult>().ReverseMap();
            CreateMap<PurchaseOfferProductDocument, PurchaseOfferProductDocumentResult>().ReverseMap();
            CreateMap<PurchaseOfferProductDocument, PurchaseOfferProductInfoResult>().ReverseMap();
        }
    }
}
