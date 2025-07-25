using AutoMapper;
using Crm.Core.Application.Features.CQRS.Queries.SaleQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.SaleHandlers
{
    public class GetSalesOfferDetailQueryHandler : IRequestHandler<GetSalesOfferDetailQuary, SalesOfferDetailResult?>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSalesOfferDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<SalesOfferDetailResult?> Handle(GetSalesOfferDetailQuary request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.SalesOffer.GetByIdAsync(request.SalesOfferId);
            return entity == null ? null : _mapper.Map<SalesOfferDetailResult>(entity);
        }
    }
}
