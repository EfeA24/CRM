using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Purchase;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.PurchaseHandlers
{
    public class CreatePurchaseOfferCommandHandler : IRequestHandler<CreatePurchaseOfferCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreatePurchaseOfferCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreatePurchaseOfferCommand request, CancellationToken cancellationToken)
        {
            var entity = new PurchaseOffer
            {
                PurchaseOfferName = request.PurchaseOfferName,
                PurchaseOfferNumber = request.PurchaseOfferNumber,
                PurchaseOfferDescription = request.PurchaseOfferDescription,
                PurchaseOfferType = request.PurchaseOfferType,
                PurchaseOfferStatus = request.PurchaseOfferStatus,
                PurchaseOfferCurrency = request.PurchaseOfferCurrency,
                PurchaseOfferTotalPrice = request.PurchaseOfferTotalPrice,
                PurchaseOfferPriority = request.PurchaseOfferPriority,
                PurchaseOfferDate = request.PurchaseOfferDate,
                PurchaseOfferDueDate = request.PurchaseOfferDueDate,
                PurchaseOfferCreatedDate = request.PurchaseOfferCreatedDate,
                PurchaseOfferUpdateDate = request.PurchaseOfferUpdateDate,
                PurchaseOfferCreatedBy = request.PurchaseOfferCreatedBy,
                PurchaseOfferUpdatedBy = request.PurchaseOfferUpdatedBy,
                CompanyId = request.CompanyId
            };

            await _unitOfWork.PurchaseOffer.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
