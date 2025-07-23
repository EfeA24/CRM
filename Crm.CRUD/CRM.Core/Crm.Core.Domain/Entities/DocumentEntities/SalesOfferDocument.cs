using Crm.Core.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.DocumentEntities
{
    public class SalesOfferDocument
    {
        [Key]
        public Guid SalesOfferDocumentId { get; set; }
        public string SaleDocumentType { get; set; } = string.Empty;
        public string SaleFileName { get; set; } = string.Empty;
        public string SaleFileType { get; set; } = string.Empty;
        public string SaleFilePath { get; set; } = string.Empty;
        public DateTime SaleUploadedAt { get; set; } = DateTime.UtcNow;
        public string? SaleUploadedBy { get; set; } = string.Empty;
        public string? SaleDescription { get; set; } = string.Empty;


    }
}
