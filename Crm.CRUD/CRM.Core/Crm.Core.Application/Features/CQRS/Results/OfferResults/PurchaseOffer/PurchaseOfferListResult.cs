using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer
{
    public class PurchaseOfferListResult
    {
        public string? PurchaseOfferName { get; set; }
        public string? PurchaseOfferNumber { get; set; }
        public bool? PurchaseOfferStatus { get; set; }
        public string? PurchaseOfferCurrency { get; set; }
        public decimal? PurchaseOfferTotalPrice { get; set; }
        public DateOnly? PurchaseOfferDueDate { get; set; }

        public Guid CompanyId { get; set; }
        public string? CompanyName { get; set; }
    }
}
