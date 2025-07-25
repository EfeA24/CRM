using AutoMapper;
using Crm.Core.Application.Features.CQRS.Queries.MainEntityQueries;
using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.Company_Handlers
{
    public class GetCompanyDetailQueryHandler : IRequestHandler<GetCompanyDetailQuery, CompanyDetailResult?>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCompanyDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CompanyDetailResult?> Handle(GetCompanyDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Company.GetByIdAsync(request.CompanyId);
            return entity == null ? null : _mapper.Map<CompanyDetailResult>(entity);
        }
    }
}
