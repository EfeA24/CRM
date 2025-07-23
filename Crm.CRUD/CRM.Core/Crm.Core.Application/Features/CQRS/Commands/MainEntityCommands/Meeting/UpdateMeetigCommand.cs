using Crm.Core.Domain.Entities.OfferEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Meeting
{
    public class UpdateMeetigCommand : IRequest<Unit>
    {
        public Guid MeetingId { get; set; }
        public string Subject { get; set; }
        public string Type { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Notes { get; set; }
        public string? MeetingType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } 

        public Guid? CompanyId { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? SalesOfferId { get; set; }
    }
}
