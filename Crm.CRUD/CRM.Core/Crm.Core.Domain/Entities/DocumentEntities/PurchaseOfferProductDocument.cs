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
        public string FileName { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
        public string? UploadedBy { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

        public Guid PurchaseOfferItemId { get; set; }
        public PurchaseOfferProduct PurchaseOfferProduct { get; set; }
    }
}
