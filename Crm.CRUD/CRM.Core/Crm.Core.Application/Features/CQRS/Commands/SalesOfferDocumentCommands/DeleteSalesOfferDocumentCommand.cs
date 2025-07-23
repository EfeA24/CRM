using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.SalesOfferDocumentCommands
{
    public class DeleteSalesOfferDocumentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteSalesOfferDocumentCommand(int id)
        {
            Id = id;
        }
    }
}
