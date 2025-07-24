using Crm.Core.Domain.Entities.MainEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.OfferEntities
{
    public class SalesOffer
    {
        [Key]
        public Guid SalesOfferId { get; set; }
        public string? SalesOfferName { get; set; } = string.Empty;
        public string? SalesOfferNumber { get; set; } = string.Empty;
        public string? SalesOfferDescription { get; set; } = string.Empty;
        public string? SalesOfferType { get; set; } = string.Empty;
        public bool? SalesOfferStatus { get; set; }
        public string? SalesOfferPriority { get; set; } = string.Empty;
        public DateOnly? SalesOfferDate { get; set; } = null;
        public DateOnly? SalesOfferDueDate { get; set; } = null;
        public DateTime SalesOfferCreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? SalesOfferUpdateDate { get; set; } = null;
        public string? SalesOfferCreatedBy { get; set; } = string.Empty;
        public string? SalesOfferUpdatedBy { get; set; } = string.Empty;


        public Guid CompanyId { get; set; }
        public Company Company { get; set; } = new Company();
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

        public ICollection<SalesOfferProduct> SalesOfferProducts { get; set; } = new List<SalesOfferProduct>();

    }
}
