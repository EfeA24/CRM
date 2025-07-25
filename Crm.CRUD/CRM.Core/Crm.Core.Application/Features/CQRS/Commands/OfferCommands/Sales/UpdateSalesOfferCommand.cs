using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales
{
    public class UpdateSalesOfferCommand : IRequest<Unit>, IBaseRequest
    {
        public Guid SalesOfferId { get; set; }
        public string? SalesOfferName { get; set; }
        public string? SalesOfferNumber { get; set; }
        public string? SalesOfferDescription { get; set; }
        public string? SalesOfferType { get; set; }
        public bool? SalesOfferStatus { get; set; }
        public string? SalesOfferPriority { get; set; }
        public DateOnly? SalesOfferDate { get; set; }
        public DateOnly? SalesOfferDueDate { get; set; }
        public DateTime SalesOfferCreatedDate { get; set; }
        public DateTime? SalesOfferUpdateDate { get; set; }
        public string? SalesOfferCreatedBy { get; set; }
        public string? SalesOfferUpdatedBy { get; set; }
        public Guid CompanyId { get; set; }
    }
}
