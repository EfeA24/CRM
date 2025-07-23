using AutoMapper;
using Crm.Core.Application.Features.CQRS.Results.DocumentResults.SalesOfferDocuments;
using Crm.Core.Domain.Entities.DocumentEntities;
using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.Mapping.Documents
{
    public class SalesDocumentMappingProfile : Profile
    {
        public SalesDocumentMappingProfile()
        {
            CreateMap<SalesOfferDocument, SalesOfferDocumentResult>().ReverseMap();
            CreateMap<SalesOfferProductDocument, SalesOfferProductInfoResult>().ReverseMap();
            CreateMap<SalesOfferProductDocument, SalesOfferProductDocumentResult>().ReverseMap();
        }
    }
}
