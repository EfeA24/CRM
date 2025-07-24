using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer
{
    public class SalesOfferProductListResult
    {
        public string? SalesOfferProductName { get; set; }
        public string? SalesOfferProductDescription { get; set; }
        public decimal? SalesOfferProductPrice { get; set; }
        public string? Currency { get; set; }
        public int? SalesOfferProductQuantity { get; set; }

        public string? SalesOfferName { get; set; }
        public string? CompanyName { get; set; }
    }
}
