﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company
{
    public class DeleteCompanyCommand : IRequest<Unit>
    {
        public Guid CompanyId { get; set; }

        public DeleteCompanyCommand(Guid companyId)
        {
            CompanyId = companyId;
        }
    }
}
