using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Contact;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.MainEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.ContactHandlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var entity = new Contact
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                Position = request.Position,
                Department = request.Department,
                CreatedDate = request.CreatedDate,
                CreatedBy = request.CreatedBy,
                CompanyId = request.CompanyId
            };

            await _unitOfWork.Contact.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
