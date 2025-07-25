using Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer;
using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;

namespace Crm.Core.Application.Features.CQRS.Queries.PurchaseQueries
{
    public class GetAllPurchaseOffersQuery : IRequest<List<PurchaseOfferListResult>>
    {
        public ODataQueryOptions<PurchaseOffer>? Options { get; }

        public GetAllPurchaseOffersQuery(ODataQueryOptions<PurchaseOffer>? options)
        {
            Options = options;
        }
    }
}
