using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.MainEntityResults
{
    public class MeetingListResult
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

        public CompanySummaryResult? Company { get; set; }
        public ContactSummaryResult? Contact { get; set; }
    }

}
