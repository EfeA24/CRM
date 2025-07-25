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

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.MeetingHandlers
{
    public class GetMeetingDetailQueryHandler : IRequestHandler<GetMeetingDetailQuery, MeetingDetailResult?>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetMeetingDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<MeetingDetailResult?> Handle(GetMeetingDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Meeting.GetByIdAsync(request.MeetingId);
            return entity == null ? null : _mapper.Map<MeetingDetailResult>(entity);
        }
    }
}
