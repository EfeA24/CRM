using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales
{
    public class DeleteSalesOfferProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteSalesOfferProductCommand(int id)
        {
            Id = id;
        }
    }
}
