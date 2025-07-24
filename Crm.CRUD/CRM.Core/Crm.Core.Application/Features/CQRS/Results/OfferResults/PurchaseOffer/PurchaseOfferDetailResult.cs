using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer
{
    public class PurchaseOfferDetailResult
    {
        public Guid PurchaseOfferId { get; set; }
        public string? PurchaseOfferName { get; set; }
        public string? PurchaseOfferNumber { get; set; }
        public string? PurchaseOfferDescription { get; set; }
        public string? PurchaseOfferType { get; set; }
        public bool? PurchaseOfferStatus { get; set; }
        public string? PurchaseOfferCurrency { get; set; }
        public decimal? PurchaseOfferTotalPrice { get; set; }
        public string? PurchaseOfferPriority { get; set; }
        public DateOnly? PurchaseOfferDate { get; set; }
        public DateOnly? PurchaseOfferDueDate { get; set; }
        public DateTime PurchaseOfferCreatedDate { get; set; }
        public DateTime? PurchaseOfferUpdateDate { get; set; }
        public string? PurchaseOfferCreatedBy { get; set; }
        public string? PurchaseOfferUpdatedBy { get; set; }

        // Company
        public Guid CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyTag { get; set; }
        public string? CompanyType { get; set; }

        // Products
        public List<PurchaseOfferProductListResult> Products { get; set; } = new();
    }
}
