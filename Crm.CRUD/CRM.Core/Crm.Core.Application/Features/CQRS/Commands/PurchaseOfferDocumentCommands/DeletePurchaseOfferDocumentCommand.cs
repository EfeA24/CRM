using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.PurchaseOfferDocumentCommands
{
    public class DeletePurchaseOfferDocumentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeletePurchaseOfferDocumentCommand(int id)
        {
            Id = id;
        }
    }
}
