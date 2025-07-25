using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Meeting;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.MainEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.MeetingHandlers
{
    public class CreateMeetingCommandHandler : IRequestHandler<CreateMeetingCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateMeetingCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
        {
            var entity = new Meeting
            {
                Subject = request.Subject,
                Type = request.Type,
                StartDateTime = request.StartDateTime,
                EndDateTime = request.EndDateTime,
                Notes = request.Notes,
                MeetingType = request.MeetingType,
                CreatedBy = request.CreatedBy,
                CreatedAt = request.CreatedAt,
                CompanyId = request.CompanyId,
                ContactId = request.ContactId
            };

            await _unitOfWork.Meeting.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
