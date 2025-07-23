using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.MainEntityResults
{
    public class CompanySummaryResult
    {
        public Guid CompanyId { get; set; }
        public string CompanyTag { get; set; }
        public string? CompanyName { get; set; }
        public string CompanyType { get; set; }
    }

}
