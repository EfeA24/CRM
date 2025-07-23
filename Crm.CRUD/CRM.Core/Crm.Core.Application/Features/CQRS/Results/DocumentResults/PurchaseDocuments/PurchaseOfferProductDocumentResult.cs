using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.DocumentResults.PurchaseDocuments
{
    public class PurchaseOfferProductDocumentResult
    {
        public Guid PurchaseOfferProductDocumentId { get; set; }
        public string PurchaseOfferProductName { get; set; }
        public string PurchaseOfferProductType { get; set; }
        public string PurchaseOfferProductPath { get; set; }
        public DateTime PurchaseOfferProductUploadedAt { get; set; }
        public string? PurchaseOfferProductUploadedBy { get; set; }
        public string? PurchaseOfferProductDescription { get; set; }
        public Guid PurchaseOfferId { get; set; }
    }
}
