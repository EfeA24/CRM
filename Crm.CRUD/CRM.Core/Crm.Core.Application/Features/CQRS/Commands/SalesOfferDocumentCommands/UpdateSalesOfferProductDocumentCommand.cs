using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.SalesOfferDocumentCommands
{
    public class UpdateSalesOfferProductDocumentCommand : IRequest<Unit>
    {
        public Guid SalesOfferProductDocumentId { get; set; }
        public string SalesOfferProductDocumentFileName { get; set; }
        public string SalesOfferProductDocumentFileType { get; set; }
        public string SalesOfferProductDocumentFilePath { get; set; }
        public DateTime SalesOfferProductDocumentUploadedAt { get; set; }
        public string? SalesOfferProductDocumentUploadedBy { get; set; }
        public string? SalesOfferProductDocumentDescription { get; set; }
        public Guid SalesOfferId { get; set; }
    }
}
