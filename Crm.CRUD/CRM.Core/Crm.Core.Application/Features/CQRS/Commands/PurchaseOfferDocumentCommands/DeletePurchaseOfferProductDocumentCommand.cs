using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.PurchaseOfferDocumentCommands
{
    public class DeletePurchaseOfferProductDocumentCommand : IRequest<Unit>
    {
        public Guid PurchaseOfferProductDocumentId { get; set; }
        public DeletePurchaseOfferProductDocumentCommand(Guid purchaseOfferProductDocumentId)
        {
            PurchaseOfferProductDocumentId = purchaseOfferProductDocumentId;
        }
    }
}
