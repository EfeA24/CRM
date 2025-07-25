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
    public class DeleteSalesOfferCommandHandler : IRequestHandler<DeleteSalesOfferCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteSalesOfferCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteSalesOfferCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.SalesOffer.GetByIdAsync(new Guid(request.Id.ToString()));
            if (entity != null)
            {
                _unitOfWork.SalesOffer.Remove(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}
