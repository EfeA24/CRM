using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.MainEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.Company_Handlers
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCompanyCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = new Company
            {
                CompanyTag = request.CompanyTag,
                CompanyName = request.CompanyName,
                CompanyType = request.CompanyType,
                CompanyAddressLine1 = request.CompanyAddressLine1,
                CompanyAddressLine2 = request.CompanyAddressLine2,
                CompanyCity = request.CompanyCity,
                CompanyCountry = request.CompanyCountry,
                CompanyPhone = request.CompanyPhone,
                CompanyEmail = request.CompanyEmail,
                CreatedDate = request.CreatedDate,
                CreatedBy = request.CreatedBy
            };

            await _unitOfWork.Company.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
