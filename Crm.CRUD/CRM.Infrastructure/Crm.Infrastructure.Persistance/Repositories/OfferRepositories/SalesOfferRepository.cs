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
    public class SalesOfferRepository : GenericRepository<SalesOffer>, ISalesOfferRepository
    {
        private readonly AppDbContext _context;
        public SalesOfferRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<SalesOffer>> GetAllAsync()
        {
            return await _context.SalesOffers
                .Include(x => x.Company)
                .Include(x => x.SalesOfferProducts)
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public override async Task<SalesOffer?> GetByIdAsync(Guid id)
        {
            return await _context.SalesOffers
                .Include(x => x.Company)
                .Include(x => x.SalesOfferProducts)
                .FirstOrDefaultAsync(x => x.SalesOfferId == id && !x.IsDeleted);
        }

    }
}
