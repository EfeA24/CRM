using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company
{
    public class CreateCompanyCommand : IRequest<Unit>
    {
        public string CompanyTag { get; set; }
        public string? CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string? CompanyAddressLine1 { get; set; }
        public string? CompanyAddressLine2 { get; set; }
        public string? CompanyCity { get; set; }
        public string? CompanyCountry { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyEmail { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
    }
}
