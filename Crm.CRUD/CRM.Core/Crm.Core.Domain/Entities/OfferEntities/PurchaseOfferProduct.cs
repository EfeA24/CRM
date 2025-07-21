using Crm.Core.Domain.Entities.DocumentEntities;
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
        public string? ProductName { get; set; } = string.Empty;
        public string? ProductDescription { get; set; } = string.Empty;
        public decimal? ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; } = null;
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;

        public Guid PurchaseOfferId { get; private set; }
        public PurchaseOffer PurchaseOffer { get; private set; } = new PurchaseOffer();
        public ICollection<PurchaseOfferProductDocument> SalesOfferProductDocuments { get; set; } = new List<PurchaseOfferProductDocument>();
    }
}
