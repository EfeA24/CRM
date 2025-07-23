using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Purchase
{
    public class UpdatePurchaseOfferProductCommand : IRequest<Unit>
    {
        public Guid PurchaseOfferProductId { get; set; }
        public string? PurchaseOfferProductName { get; set; }
        public string? PurchaseOfferProductDescription { get; set; }
        public decimal? PurchaseOfferProductPrice { get; set; }
        public string? PurchaseOfferProductCurrency { get; set; }
        public int? PurchaseOfferProductQuantity { get; set; }
        public DateTime PurchaseOfferProductCreatedDate { get; set; }
        public DateTime? PurchaseOfferProductUpdateDate { get; set; }
        public string? PurchaseOfferProductCreatedBy { get; set; }
        public string? PurchaseOfferProductUpdatedBy { get; set; }
        public Guid PurchaseOfferId { get; set; }
    }
}
