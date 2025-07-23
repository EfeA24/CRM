using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.PurchaseOfferDocumentCommands
{
    public class UpdatePurchaseOfferProductDocumentCommand : IRequest<Unit>
    {
        public Guid PurchaseOfferProductDocumentId { get; set; }
        public string PurchaseFileName { get; set; }
        public string PurchaseFileType { get; set; }
        public string PurchaseFilePath { get; set; }
        public string? PurchaseUploadedBy { get; set; }
        public string? PurchaseDescription { get; set; }
    }
}
