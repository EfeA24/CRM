using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.MainEntities
{
    public class Meeting
    {
        public Guid MeetingId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Notes { get; set; }
        public string? MeetingType { get; set; } = string.Empty;
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }
        public Guid? SalesOfferId { get; set; }
        public SalesOffer? SalesOffer { get; set; }
    }

}
