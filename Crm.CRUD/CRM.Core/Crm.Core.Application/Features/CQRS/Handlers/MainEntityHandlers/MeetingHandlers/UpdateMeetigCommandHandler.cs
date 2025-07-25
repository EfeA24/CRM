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
    public class UpdateMeetigCommandHandler : IRequestHandler<UpdateMeetigCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateMeetigCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateMeetigCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Meeting.GetByIdAsync(request.MeetingId);
            if (entity != null)
            {
                entity.Subject = request.Subject;
                entity.Type = request.Type;
                entity.StartDateTime = request.StartDateTime;
                entity.EndDateTime = request.EndDateTime;
                entity.Notes = request.Notes;
                entity.MeetingType = request.MeetingType;
                entity.CreatedBy = request.CreatedBy;
                entity.CreatedAt = request.CreatedAt;
                entity.CompanyId = request.CompanyId;
                entity.ContactId = request.ContactId;

                _unitOfWork.Meeting.Update(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
