using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Meeting
{
    public class DeleteMeetingCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteMeetingCommand(int id)
        {
            Id = id;
        }
    }
}
