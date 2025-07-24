using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Domain.Entities.OfferEntities
{
    public class SalesOfferProduct
    {
        [Key]
        public Guid SalesOfferProductId{ get; set; }
        public string? SalesOfferProductName { get; set; } = string.Empty;
        public string? SalesOfferProductDescription { get; set; } = string.Empty;
        public string? Currency { get; set; } = string.Empty;
        public decimal? SalesOfferProductPrice { get; set; }
        public int? SalesOfferProductQuantity { get; set; }
        public DateTime SalesOfferProductCreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? SalesOfferProductUpdateDate { get; set; } = null;
        public string? SalesOfferProductCreatedBy { get; set; } = string.Empty;
        public string? SalesOfferProductUpdatedBy { get; set; } = string.Empty;

        public Guid SalesOfferId { get; set; }
        public SalesOffer SalesOffer { get; set; } = new SalesOffer();

    }
}
