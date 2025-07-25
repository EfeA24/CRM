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
    public class GetAllMeetingsQueryHandler : IRequestHandler<GetAllMeetingsQuery, List<MeetingListResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllMeetingsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<MeetingListResult>> Handle(GetAllMeetingsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _unitOfWork.Meeting.GetAllAsync();
            return _mapper.Map<List<MeetingListResult>>(entities);
        }
    }
}
