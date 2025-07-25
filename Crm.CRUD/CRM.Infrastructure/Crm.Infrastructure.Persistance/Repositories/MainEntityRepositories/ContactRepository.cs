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
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        private readonly AppDbContext _context;
        public ContactRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<Contact>> GetAllAsync()
        {
            return await _context.Contacts
                .Include(c => c.Company)
                .Where(c => !c.IsDeleted)
                .ToListAsync();
        }

        public override async Task<Contact?> GetByIdAsync(Guid id)
        {
            return await _context.Contacts
                .Include(c => c.Company)
                .FirstOrDefaultAsync(c => c.ContactId == id && !c.IsDeleted);
        }
    }
}
