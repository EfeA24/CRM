using Crm.Core.Application.Interfaces.OfferInterfaces;
using Crm.Core.Domain.Entities.OfferEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Crm.Infrastructure.Persistance.Repositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Infrastructure.Persistance.Repositories.OfferRepositories
{
    public class PurchaseOfferRepository : GenericRepository<PurchaseOffer>, IPurchaseOfferRepository
    {
        private readonly AppDbContext _context;
        public PurchaseOfferRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<PurchaseOffer>> GetAllAsync()
        {
            return await _context.PurchaseOffers
                .Include(p => p.Company)
                .Include(p => p.PurchaseOfferProducts)
                .Where(p => !p.IsDeleted)
                .ToListAsync();
        }

        public override async Task<PurchaseOffer?> GetByIdAsync(Guid id)
        {
            return await _context.PurchaseOffers
                .Include(p => p.Company)
                .Include(p => p.PurchaseOfferProducts)
                .FirstOrDefaultAsync(p => p.PurchaseOfferId == id && !p.IsDeleted);
        }

    }
}
