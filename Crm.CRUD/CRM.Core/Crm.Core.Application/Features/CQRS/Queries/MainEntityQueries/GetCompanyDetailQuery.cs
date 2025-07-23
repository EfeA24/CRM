using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Queries.MainEntityQueries
{
    public class GetCompanyDetailQuery : IRequest<CompanyDetailResult>
    {
        public Guid CompanyId { get; set; }
        public GetCompanyDetailQuery(Guid companyId)
        {
            CompanyId = companyId;
        }
    }

}
