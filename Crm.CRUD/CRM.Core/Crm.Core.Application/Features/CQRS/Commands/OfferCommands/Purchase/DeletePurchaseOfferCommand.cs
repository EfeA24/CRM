using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Purchase
{
    public class DeletePurchaseOfferCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeletePurchaseOfferCommand(int id)
        {
            Id = id;
        }
    }
}
