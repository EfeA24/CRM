using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.DocumentEntities
{
    public class PurchaseOfferDocument
    {
        [Key]
        public Guid PurchaseOfferDocumentId { get; set; }
        public string PurchaseDocumentType { get; set; } = string.Empty;
        public string PurchaseFileName { get; set; } = string.Empty;
        public string PurchaseFileType { get; set; } = string.Empty;
        public string PurchaseFilePath { get; set; } = string.Empty;
        public DateTime PurchaseFileUploadedAt { get; set; } = DateTime.UtcNow;
        public string? PurchaseFileUploadedBy { get; set; } = string.Empty;
        public string? PurchaseFileDescription { get; set; } = string.Empty;

        public Guid PurchaseOfferId { get; set; }
        public virtual PurchaseOffer? PurchaseOffer { get; set; }

    }
}
