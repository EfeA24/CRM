using AutoMapper;
using Crm.Core.Application.Features.CQRS.Queries.PurchaseQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.PurchaseHandlers
{
    public class GetPurchaseOfferDetailQueryHandler : IRequestHandler<GetPurchaseOfferDetailQuery, PurchaseOfferDetailResult?>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPurchaseOfferDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PurchaseOfferDetailResult?> Handle(GetPurchaseOfferDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.PurchaseOffer.GetByIdAsync(request.PurchaseOfferId);
            return entity == null ? null : _mapper.Map<PurchaseOfferDetailResult>(entity);
        }
    }
}
