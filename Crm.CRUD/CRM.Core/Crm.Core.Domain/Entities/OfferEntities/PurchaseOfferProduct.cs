using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.OfferEntities
{
    public class PurchaseOfferProduct
    {
        [Key]
        public Guid PurchaseOfferProductId { get; set; }
        public string? PurchaseOfferProductName { get; set; } = string.Empty;
        public string? PurchaseOfferProductDescription { get; set; } = string.Empty;
        public decimal? PurchaseOfferProductPrice { get; set; }
        public string? PurchaseOfferProductCurrency { get; set; } = string.Empty;
        public int? PurchaseOfferProductQuantity { get; set; }
        public DateTime PurchaseOfferProductCreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? PurchaseOfferProductUpdateDate { get; set; } = null;
        public string? PurchaseOfferProductCreatedBy { get; set; } = string.Empty;
        public string? PurchaseOfferProductUpdatedBy { get; set; } = string.Empty;

        public Guid PurchaseOfferId { get; set; }
        public PurchaseOffer PurchaseOffer { get; set; } = new PurchaseOffer();
    }
}
