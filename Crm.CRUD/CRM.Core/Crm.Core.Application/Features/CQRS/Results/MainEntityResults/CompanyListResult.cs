using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.MainEntityResults
{
    public class CompanyListResult
    {
        public string CompanyTag { get; set; } = string.Empty;
        public string? CompanyName { get; set; } = string.Empty;
        public string CompanyType { get; set; } = string.Empty;

        public List<ContactListResult> ContactLists { get; set; } = new();

    }
}
