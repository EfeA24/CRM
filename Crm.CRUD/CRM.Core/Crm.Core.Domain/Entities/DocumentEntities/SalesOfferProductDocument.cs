using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.DocumentEntities
{
    public class SalesOfferProductDocument
    {
        [Key]
        public Guid SalesOfferProductDocumentId { get; set; }
        public string SalesOfferProductDocumentFileName { get; set; } = string.Empty;
        public string SalesOfferProductDocumentFileType { get; set; } = string.Empty;
        public string SalesOfferProductDocumentFilePath { get; set; } = string.Empty;
        public DateTime SalesOfferProductDocumentUploadedAt { get; set; } = DateTime.UtcNow;
        public string? SalesOfferProductDocumentUploadedBy { get; set; } = string.Empty;
        public string? SalesOfferProductDocumentDescription { get; set; } = string.Empty;


        public Guid SalesOfferId { get; set; }
        public SalesOffer SalesOffer { get; set; }
    }
}
