using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer
{
    public class SalesOfferDetailResult
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
        public string? CompanyName { get; set; }
        public string? CompanyTag { get; set; }
        public string? CompanyType { get; set; }

        public List<SalesOfferProductListResult> Products { get; set; } = new();
    }
}
