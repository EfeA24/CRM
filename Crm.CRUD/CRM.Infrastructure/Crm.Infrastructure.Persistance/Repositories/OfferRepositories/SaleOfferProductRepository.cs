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
    public class SaleOfferProductRepository : GenericRepository<SalesOfferProduct>, ISalesOfferProductRepository
    {
        private readonly AppDbContext _context;
        public SaleOfferProductRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<SalesOfferProduct>> GetAllAsync()
        {
            return await _context.SalesOfferProducts
                .Include(p => p.SalesOffer)
                .Where(p => !p.IsDeleted)
                .ToListAsync();
        }

        public override async Task<SalesOfferProduct?> GetByIdAsync(Guid id)
        {
            return await _context.SalesOfferProducts
                .Include(p => p.SalesOffer)
                .FirstOrDefaultAsync(p => p.SalesOfferProductId == id && !p.IsDeleted);
        }

    }
}
