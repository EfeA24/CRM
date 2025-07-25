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
    public class PurchaseOfferProductRepository : GenericRepository<PurchaseOfferProduct>, IPurchaseOfferProductRepository
    {
        private readonly AppDbContext _context;
        public PurchaseOfferProductRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<PurchaseOfferProduct>> GetAllAsync()
        {
            return await _context.PurchaseOfferProducts
                .Include(p => p.PurchaseOffer)
                .Where(p => !p.IsDeleted)
                .ToListAsync();
        }

        public override async Task<PurchaseOfferProduct?> GetByIdAsync(Guid id)
        {
            return await _context.PurchaseOfferProducts
                .Include(p => p.PurchaseOffer)
                .FirstOrDefaultAsync(p => p.PurchaseOfferProductId == id && !p.IsDeleted);
        }

    }
}
