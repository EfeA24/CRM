using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Contact;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.ContactHandlers
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Contact.GetByIdAsync(request.ContactId);
            if (entity != null)
            {
                entity.FirstName = request.FirstName;
                entity.LastName = request.LastName;
                entity.Email = request.Email;
                entity.Phone = request.Phone;
                entity.Position = request.Position;
                entity.Department = request.Department;
                entity.CreatedDate = request.CreatedDate;
                entity.UpdateDate = request.UpdateDate;
                entity.CreatedBy = request.CreatedBy;
                entity.UpdatedBy = request.UpdatedBy;
                entity.CompanyId = request.CompanyId;

                _unitOfWork.Contact.Update(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
