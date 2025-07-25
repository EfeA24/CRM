using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Handlers.OfferHandlers.SaleHandlers
{
    public class CreateSalesOfferCommandHandler : IRequestHandler<CreateSalesOfferCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateSalesOfferCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateSalesOfferCommand request, CancellationToken cancellationToken)
        {
            var entity = new SalesOffer
            {
                SalesOfferName = request.SalesOfferName,
                SalesOfferNumber = request.SalesOfferNumber,
                SalesOfferDescription = request.SalesOfferDescription,
                SalesOfferType = request.SalesOfferType,
                SalesOfferStatus = request.SalesOfferStatus,
                SalesOfferPriority = request.SalesOfferPriority,
                SalesOfferDate = request.SalesOfferDate,
                SalesOfferDueDate = request.SalesOfferDueDate,
                SalesOfferCreatedBy = request.SalesOfferCreatedBy,
                SalesOfferUpdatedBy = request.SalesOfferUpdatedBy,
                CompanyId = request.CompanyId
            };

            await _unitOfWork.SalesOffer.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
