using Crm.Core.Domain.Entities.DocumentEntities;
using Crm.Core.Domain.Entities.MainEntities;
using Crm.Core.Domain.Entities.OfferEntities;
using Crm.Core.Domain.Entities.SystemEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Infrastructure.Persistance.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PurchaseOfferDocument> PurchaseOfferDocuments { get; set; }
        public DbSet<PurchaseOfferProductDocument> PurchaseOfferProductDocuments { get; set; }
        public DbSet<SalesOfferDocument> SalesOfferDocuments { get; set; }
        public DbSet<SalesOfferProductDocument> SalesOfferProductDocuments { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<PurchaseOffer> PurchaseOffers { get; set; }
        public DbSet<SalesOffer> SalesOffers { get; set; }
        public DbSet<PurchaseOfferProduct> PurchaseOfferProducts { get; set; }
        public DbSet<SalesOfferProduct> SalesOfferProducts { get; set; }

        public DbSet<BaseEntity> BaseEntities { get; set; }
    }
}
