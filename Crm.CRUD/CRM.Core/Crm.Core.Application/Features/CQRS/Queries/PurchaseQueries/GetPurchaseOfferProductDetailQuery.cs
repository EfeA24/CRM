using Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Queries.PurchaseQueries
{
    public class GetPurchaseOfferProductDetailQuery : IRequest<PurchaseOfferProductDetailResult>
    {
    }
}
