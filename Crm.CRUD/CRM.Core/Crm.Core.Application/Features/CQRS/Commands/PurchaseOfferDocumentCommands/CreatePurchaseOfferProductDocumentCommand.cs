using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.PurchaseOfferDocumentCommands
{
    public class CreatePurchaseOfferProductDocumentCommand : IRequest<Unit>
    {
        public string PurchaseFileName { get; set; } = string.Empty;
        public string PurchaseFileType { get; set; } = string.Empty;
        public string PurchaseFilePath { get; set; } = string.Empty;
        public DateTime PurchaseUploadedAt { get; set; } = DateTime.UtcNow;
        public string? PurchaseUploadedBy { get; set; } = string.Empty;
        public string? PurchaseDescription { get; set; } = string.Empty;

        public Guid PurchaseOfferId { get; set; }

    }
}
