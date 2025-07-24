using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer
{
    public class PurchaseOfferProductDetailResult
    {
        public Guid PurchaseOfferProductId { get; set; }
        public string? PurchaseOfferProductName { get; set; }
        public string? PurchaseOfferProductDescription { get; set; }
        public decimal? PurchaseOfferProductPrice { get; set; }
        public string? PurchaseOfferProductCurrency { get; set; }
        public int? PurchaseOfferProductQuantity { get; set; }
        public DateTime PurchaseOfferProductCreatedDate { get; set; }
        public DateTime? PurchaseOfferProductUpdateDate { get; set; }
        public string? PurchaseOfferProductCreatedBy { get; set; }
        public string? PurchaseOfferProductUpdatedBy { get; set; }

        public Guid PurchaseOfferId { get; set; }
        public string? PurchaseOfferName { get; set; }
        public string? PurchaseOfferNumber { get; set; }
        public bool? PurchaseOfferStatus { get; set; }
        public string? PurchaseOfferCurrency { get; set; }
        public decimal? PurchaseOfferTotalPrice { get; set; }
        public DateOnly? PurchaseOfferDate { get; set; }
        public DateOnly? PurchaseOfferDueDate { get; set; }

        public Guid CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyTag { get; set; }
        public string? CompanyType { get; set; }
    }
}
