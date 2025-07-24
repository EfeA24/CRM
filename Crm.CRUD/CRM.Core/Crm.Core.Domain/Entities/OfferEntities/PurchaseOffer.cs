using Crm.Core.Domain.Entities.MainEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.OfferEntities
{
    public class PurchaseOffer
    {
        [Key]
        public Guid PurchaseOfferId { get; set; }
        public string? PurchaseOfferName { get; set; } = string.Empty;
        public string? PurchaseOfferNumber { get; set; } = string.Empty;
        public string? PurchaseOfferDescription { get; set; } = string.Empty;
        public string? PurchaseOfferType { get; set; } = string.Empty;
        public bool? PurchaseOfferStatus { get; set; } = true;
        public string? PurchaseOfferCurrency { get; set; } = string.Empty;
        public decimal? PurchaseOfferTotalPrice { get; set; } = null;
        public string? PurchaseOfferPriority { get; set; } = string.Empty;
        public DateOnly? PurchaseOfferDate { get; set; } = null;
        public DateOnly? PurchaseOfferDueDate { get; set; } = null;
        public DateTime PurchaseOfferCreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? PurchaseOfferUpdateDate { get; set; } = null;
        public string? PurchaseOfferCreatedBy { get; set; } = string.Empty;
        public string? PurchaseOfferUpdatedBy { get; set; } = string.Empty;


        public Guid CompanyId { get; set; }
        public Company Company { get; set; } = new Company();
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

        public ICollection<PurchaseOfferProduct> PurchaseOfferProducts { get; set; } = new List<PurchaseOfferProduct>();
    }
}
