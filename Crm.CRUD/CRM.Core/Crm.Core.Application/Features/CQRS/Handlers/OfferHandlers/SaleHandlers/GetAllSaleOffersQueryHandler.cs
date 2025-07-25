using AutoMapper;
using Crm.Core.Application.Features.CQRS.Queries.SaleQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.OData.Query;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.SaleHandlers
{
    public class GetAllSaleOffersQueryHandler : IRequestHandler<GetAllSaleOffersQuery, List<SalesOfferListResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllSaleOffersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<SalesOfferListResult>> Handle(GetAllSaleOffersQuery request, CancellationToken cancellationToken)
        {
            var query = (await _unitOfWork.SalesOffer.GetAllAsync()).AsQueryable();
            if (request.Options != null)
            {
                query = (IQueryable<SalesOffer>)request.Options.ApplyTo(query, new ODataQuerySettings());
            }

            return _mapper.Map<List<SalesOfferListResult>>(query.ToList());
        }
    }
}
