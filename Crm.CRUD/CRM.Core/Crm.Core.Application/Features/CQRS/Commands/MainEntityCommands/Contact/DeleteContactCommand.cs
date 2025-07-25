﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Contact
{
    public class DeleteContactCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public DeleteContactCommand(Guid id)
        {
            Id = id;
        }
    }
}
