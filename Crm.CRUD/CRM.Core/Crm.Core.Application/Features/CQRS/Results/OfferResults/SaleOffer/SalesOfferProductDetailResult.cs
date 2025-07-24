using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer
{
    public class SalesOfferProductDetailResult
    {
        public Guid SalesOfferProductId { get; set; }
        public string? SalesOfferProductName { get; set; }
        public string? SalesOfferProductDescription { get; set; }
        public decimal? SalesOfferProductPrice { get; set; }
        public string? Currency { get; set; }
        public int? SalesOfferProductQuantity { get; set; }
        public DateTime SalesOfferProductCreatedDate { get; set; }
        public DateTime? SalesOfferProductUpdateDate { get; set; }
        public string? SalesOfferProductCreatedBy { get; set; }
        public string? SalesOfferProductUpdatedBy { get; set; }

        public Guid SalesOfferId { get; set; }
        public string? SalesOfferName { get; set; }
        public string? SalesOfferNumber { get; set; }
        public bool? SalesOfferStatus { get; set; }
        public string? SalesOfferType { get; set; }
        public string? SalesOfferPriority { get; set; }
        public DateOnly? SalesOfferDate { get; set; }
        public DateOnly? SalesOfferDueDate { get; set; }

        public Guid CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyTag { get; set; }
        public string? CompanyType { get; set; }
    }
}
