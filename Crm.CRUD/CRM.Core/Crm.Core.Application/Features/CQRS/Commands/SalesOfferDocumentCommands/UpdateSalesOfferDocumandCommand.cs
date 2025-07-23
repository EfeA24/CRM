using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.SalesOfferDocumentCommands
{
    public class UpdateSalesOfferDocumandCommand : IRequest<Unit>
    {
        public Guid SalesOfferDocumentId { get; set; }
        public string SaleDocumentType { get; set; }
        public string SaleFileName { get; set; }
        public string SaleFileType { get; set; }
        public string SaleFilePath { get; set; }
        public DateTime SaleUploadedAt { get; set; }
        public string? SaleUploadedBy { get; set; }
        public string? SaleDescription { get; set; }
    }
}
