using AutoMapper;
using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.ContactHandlers
{
    public class GetContactDetailQueryHandler : IRequestHandler<GetContactDetailQuery, ContactDetailResult?>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetContactDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ContactDetailResult?> Handle(GetContactDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Contact.GetByIdAsync(request.ContactId);
            return entity == null ? null : _mapper.Map<ContactDetailResult>(entity);
        }
    }
}
