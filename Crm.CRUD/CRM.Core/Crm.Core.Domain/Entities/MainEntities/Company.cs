using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.MainEntities
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }
        public string CompanyTag { get; set; } = string.Empty;
        public string? CompanyName { get; set; } = string.Empty;
        public string CompanyType { get; set; } = string.Empty;
        public string? CompanyAddressLine1 { get; set; } = string.Empty;
        public string? CompanyAddressLine2 { get; set; } = string.Empty;
        public string? CompanyCity { get; set; } = string.Empty;
        public string? CompanyCountry { get; set; } = string.Empty;
        public string? CompanyPhone { get; set; } = string.Empty;
        public string? CompanyEmail { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; } = null;
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;


        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
