using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales
{
    internal class UpdateSalesOfferProductCommand : IRequest<Unit>
    {
        public Guid SalesOfferProductDocumentId { get; set; }
        public string SalesOfferProductDocumentFileName { get; set; }
        public string SalesOfferProductDocumentFileType { get; set; }
        public string SalesOfferProductDocumentFilePath { get; set; }
        public string? SalesOfferProductDocumentUploadedBy { get; set; }
        public string? SalesOfferProductDocumentDescription { get; set; }
        public Guid SalesOfferId { get; set; }
    }
}
