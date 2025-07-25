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
    public class DeletePurchaseOfferCommandHandler : IRequestHandler<DeletePurchaseOfferCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeletePurchaseOfferCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeletePurchaseOfferCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.PurchaseOffer.GetByIdAsync(new Guid(request.Id.ToString()));
            if (entity != null)
            {
                _unitOfWork.PurchaseOffer.Remove(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
