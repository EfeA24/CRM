using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.DocumentResults.PurchaseDocuments
{
    public class PurchaseOfferDocumentResult
    {
        public Guid PurchaseOfferDocumentId { get; set; }
        public string PurchaseDocumentType { get; set; }
        public string PurchaseFileName { get; set; }
        public string PurchaseFileType { get; set; }
        public string PurchaseFilePath { get; set; }
        public DateTime PurchaseFileUploadedAt { get; set; }
        public string? PurchaseFileUploadedBy { get; set; }
        public string? PurchaseFileDescription { get; set; }

        public List<PurchaseOfferProductInfoResult> ProductDocuments { get; set; } = new();
    }
}
