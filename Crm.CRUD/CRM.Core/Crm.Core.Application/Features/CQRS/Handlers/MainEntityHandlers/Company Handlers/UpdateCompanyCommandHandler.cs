using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.MainEntityHandlers.Company_Handlers
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCompanyCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Company.GetByIdAsync(request.CompanyId);
            if (entity != null)
            {
                entity.CompanyTag = request.CompanyTag;
                entity.CompanyName = request.CompanyName;
                entity.CompanyType = request.CompanyType;
                entity.CompanyAddressLine1 = request.CompanyAddressLine1;
                entity.CompanyAddressLine2 = request.CompanyAddressLine2;
                entity.CompanyCity = request.CompanyCity;
                entity.CompanyCountry = request.CompanyCountry;
                entity.CompanyPhone = request.CompanyPhone;
                entity.CompanyEmail = request.CompanyEmail;
                entity.UpdateDate = request.UpdateDate;
                entity.UpdatedBy = request.UpdatedBy;
                _unitOfWork.Company.Update(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
