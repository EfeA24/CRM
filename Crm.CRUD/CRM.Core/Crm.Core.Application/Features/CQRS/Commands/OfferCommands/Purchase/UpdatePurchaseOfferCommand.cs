using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Purchase
{
    public class UpdatePurchaseOfferCommand : IRequest<Unit>
    {
        public Guid PurchaseOfferId { get; set; }
        public string? PurchaseOfferName { get; set; }
        public string? PurchaseOfferNumber { get; set; }
        public string? PurchaseOfferDescription { get; set; }
        public string? PurchaseOfferType { get; set; }
        public bool? PurchaseOfferStatus { get; set; }
        public string? PurchaseOfferCurrency { get; set; }
        public decimal? PurchaseOfferTotalPrice { get; set; }
        public string? PurchaseOfferPriority { get; set; }
        public DateOnly? PurchaseOfferDate { get; set; }
        public DateOnly? PurchaseOfferDueDate { get; set; }
        public DateTime PurchaseOfferCreatedDate { get; set; }
        public DateTime? PurchaseOfferUpdateDate { get; set; }
        public string? PurchaseOfferCreatedBy { get; set; }
        public Guid CompanyId { get; set; }
    }
}
