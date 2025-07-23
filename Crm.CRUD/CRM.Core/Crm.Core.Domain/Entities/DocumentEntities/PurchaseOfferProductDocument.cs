using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.DocumentEntities
{
    public class PurchaseOfferProductDocument
    {
        [Key]
        public Guid PurchaseOfferProductDocumentId { get; set; }
        public string PurchaseOfferProductName { get; set; } = string.Empty;
        public string PurchaseOfferProductType { get; set; } = string.Empty;
        public string PurchaseOfferProductPath { get; set; } = string.Empty;
        public DateTime PurchaseOfferProductUploadedAt { get; set; } = DateTime.UtcNow;
        public string? PurchaseOfferProductUploadedBy { get; set; } = string.Empty;
        public string? PurchaseOfferProductDescription { get; set; } = string.Empty;

        public Guid PurchaseOfferId { get; set; }
        public PurchaseOffer PurchaseOffer { get; set; }
    }
}
