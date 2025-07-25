using Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer;
using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;

namespace Crm.Core.Application.Features.CQRS.Queries.SaleQueries
{
    public class GetAllSaleOffersQuery : IRequest<List<SalesOfferListResult>>
    {
        public ODataQueryOptions<SalesOffer>? Options { get; }

        public GetAllSaleOffersQuery(ODataQueryOptions<SalesOffer>? options)
        {
            Options = options;
        }
    }
}
