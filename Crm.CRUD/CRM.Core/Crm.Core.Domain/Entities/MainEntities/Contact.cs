using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.MainEntities
{
    public class Contact
    {
        [Key]
        public Guid ContactId { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        public string? Position { get; set; } = string.Empty;
        public string? Department { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; } = null;
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;

        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; } = new Company();
    }
}
