using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer
{
    public class PurchaseOfferProductListResult
    {
        public string? PurchaseOfferProductName { get; set; }
        public string? PurchaseOfferProductDescription { get; set; }
        public decimal? PurchaseOfferProductPrice { get; set; }
        public string? PurchaseOfferProductCurrency { get; set; }
        public int? PurchaseOfferProductQuantity { get; set; }

        public string? PurchaseOfferName { get; set; }
        public string? CompanyName { get; set; }
    }
}
