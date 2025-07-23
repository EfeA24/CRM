using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company
{
    public class DeleteCompanyCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteCompanyCommand(int id)
        {
            Id = id;
        }
    }
}
