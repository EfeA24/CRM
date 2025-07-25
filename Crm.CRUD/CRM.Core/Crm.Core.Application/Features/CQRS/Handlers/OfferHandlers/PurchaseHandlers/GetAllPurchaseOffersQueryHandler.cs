using AutoMapper;
using Crm.Core.Application.Features.CQRS.Queries.PurchaseQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.PurchaseHandlers
{
    public class GetAllPurchaseOffersQueryHandler : IRequestHandler<GetAllPurchaseOffersQuery, List<PurchaseOfferListResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllPurchaseOffersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<PurchaseOfferListResult>> Handle(GetAllPurchaseOffersQuery request, CancellationToken cancellationToken)
        {
            var query = (await _unitOfWork.PurchaseOffer.GetAllAsync()).AsQueryable();
            if (request.Options != null)
            {
                query = (IQueryable<PurchaseOffer>)request.Options.ApplyTo(query, new ODataQuerySettings());
            }

            return _mapper.Map<List<PurchaseOfferListResult>>(query.ToList());
        }
    }
}
