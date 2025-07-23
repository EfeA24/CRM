using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.MainEntityResults
{
    public class CompanyDetailResult
    {
        public Guid CompanyId { get; set; }
        public string CompanyTag { get; set; } = string.Empty;
        public string? CompanyName { get; set; } = string.Empty;
        public string CompanyType { get; set; } = string.Empty;
        public string? CompanyAddressLine1 { get; set; }
        public string? CompanyAddressLine2 { get; set; }
        public string? CompanyCity { get; set; }
        public string? CompanyCountry { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyEmail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public List<ContactListResult> ContactLists { get; set; } = new();
    }

}
