using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Meeting;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.MeetingHandlers
{
    public class DeleteMeetingCommandHandler : IRequestHandler<DeleteMeetingCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteMeetingCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteMeetingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Meeting.GetByIdAsync(new Guid(request.Id.ToString()));
            if (entity != null)
            {
                _unitOfWork.Meeting.Remove(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
