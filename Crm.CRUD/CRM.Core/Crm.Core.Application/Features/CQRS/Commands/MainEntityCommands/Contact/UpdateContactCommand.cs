using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Contact
{
    public class UpdateContactCommand : IRequest<Unit>
    {
        public Guid ContactId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }
        public string? Department { get; set; }
        public DateTime CreatedDate { get; set; } 
        public DateTime? UpdateDate { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public Guid CompanyId { get; set; }
    }
}
