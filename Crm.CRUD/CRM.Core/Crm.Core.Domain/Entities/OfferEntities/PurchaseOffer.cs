using Crm.Core.Domain.Entities.DocumentEntities;
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
        public bool? PurchaseOfferStatus { get; set; }
        public string? PurchaseOfferPriority { get; set; } = string.Empty;
        public DateOnly? PurchaseOfferDate { get; set; } = null;
        public DateOnly? PurchaseOfferDueDate { get; set; } = null;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; } = null;
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;


        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; } = new Company();
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

        public ICollection<PurchaseOfferProduct> PurchaseOfferProducts { get; set; } = new List<PurchaseOfferProduct>();
        public ICollection<PurchaseOfferDocument> PurchaseOfferDocument { get; set; } = new List<PurchaseOfferDocument>();
    }
}
