using Crm.Core.Application.Interfaces.MainEntityInterfaces;
using Crm.Core.Domain.Entities.MainEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Crm.Infrastructure.Persistance.Repositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Infrastructure.Persistance.Repositories.MainEntityRepositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly AppDbContext _context;
        public CompanyRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _context.Companies
                .Include(c => c.Contacts)
                .Include(c => c.PurchaseOffers)
                .Include(c => c.SalesOffers)
                .Where(c => !c.IsDeleted)
                .ToListAsync();
        }

        public override async Task<Company?> GetByIdAsync(Guid id)
        {
            return await _context.Companies
                .Include(c => c.Contacts)
                .Include(c => c.PurchaseOffers)
                .Include(c => c.SalesOffers)
                .FirstOrDefaultAsync(c => c.CompanyId == id && !c.IsDeleted);
        }
    }
}
