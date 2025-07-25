using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.SaleHandlers
{
    public class UpdateSalesOfferCommandHandler : IRequestHandler<UpdateSalesOfferCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateSalesOfferCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateSalesOfferCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.SalesOffer.GetByIdAsync(request.SalesOfferId);
            if (entity != null)
            {
                entity.SalesOfferName = request.SalesOfferName;
                entity.SalesOfferNumber = request.SalesOfferNumber;
                entity.SalesOfferDescription = request.SalesOfferDescription;
                entity.SalesOfferType = request.SalesOfferType;
                entity.SalesOfferStatus = request.SalesOfferStatus;
                entity.SalesOfferPriority = request.SalesOfferPriority;
                entity.SalesOfferDate = request.SalesOfferDate;
                entity.SalesOfferDueDate = request.SalesOfferDueDate;
                entity.SalesOfferCreatedDate = request.SalesOfferCreatedDate;
                entity.SalesOfferUpdateDate = request.SalesOfferUpdateDate;
                entity.SalesOfferCreatedBy = request.SalesOfferCreatedBy;
                entity.SalesOfferUpdatedBy = request.SalesOfferUpdatedBy;
                entity.CompanyId = request.CompanyId;

                _unitOfWork.SalesOffer.Update(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
