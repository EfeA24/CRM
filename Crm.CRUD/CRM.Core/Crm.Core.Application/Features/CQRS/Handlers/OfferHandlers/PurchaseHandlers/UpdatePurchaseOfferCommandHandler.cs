using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Purchase;
using Crm.Core.Application.Interfaces.Generic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.PurchaseHandlers
{
    public class UpdatePurchaseOfferCommandHandler : IRequestHandler<UpdatePurchaseOfferCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePurchaseOfferCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdatePurchaseOfferCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.PurchaseOffer.GetByIdAsync(request.PurchaseOfferId);
            if (entity != null)
            {
                entity.PurchaseOfferName = request.PurchaseOfferName;
                entity.PurchaseOfferNumber = request.PurchaseOfferNumber;
                entity.PurchaseOfferDescription = request.PurchaseOfferDescription;
                entity.PurchaseOfferType = request.PurchaseOfferType;
                entity.PurchaseOfferStatus = request.PurchaseOfferStatus;
                entity.PurchaseOfferCurrency = request.PurchaseOfferCurrency;
                entity.PurchaseOfferTotalPrice = request.PurchaseOfferTotalPrice;
                entity.PurchaseOfferPriority = request.PurchaseOfferPriority;
                entity.PurchaseOfferDate = request.PurchaseOfferDate;
                entity.PurchaseOfferDueDate = request.PurchaseOfferDueDate;
                entity.PurchaseOfferCreatedDate = request.PurchaseOfferCreatedDate;
                entity.PurchaseOfferUpdateDate = request.PurchaseOfferUpdateDate;
                entity.PurchaseOfferCreatedBy = request.PurchaseOfferCreatedBy;
                entity.CompanyId = request.CompanyId;

                _unitOfWork.PurchaseOffer.Update(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
