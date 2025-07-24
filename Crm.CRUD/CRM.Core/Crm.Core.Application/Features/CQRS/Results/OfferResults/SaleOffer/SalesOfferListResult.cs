using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer
{
    public class SalesOfferListResult
    {
        public string? SalesOfferName { get; set; }
        public string? SalesOfferNumber { get; set; }
        public bool? SalesOfferStatus { get; set; }
        public string? SalesOfferType { get; set; }
        public string? SalesOfferPriority { get; set; }
        public DateOnly? SalesOfferDueDate { get; set; }
        public string? CompanyName { get; set; }
    }
}
