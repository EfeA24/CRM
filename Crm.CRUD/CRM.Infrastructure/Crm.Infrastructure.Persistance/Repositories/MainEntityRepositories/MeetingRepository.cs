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
    public class MeetingRepository : GenericRepository<Meeting>, IMeetingRepository
    {
        private readonly AppDbContext _context;
        public MeetingRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public override async Task<IEnumerable<Meeting>> GetAllAsync()
        {
            return await _context.Meetings
                .Include(m => m.Company)
                .Include(m => m.Contact)
                .Where(m => !m.IsDeleted)
                .ToListAsync();
        }

        public override async Task<Meeting?> GetByIdAsync(Guid id)
        {
            return await _context.Meetings
                .Include(m => m.Company)
                .Include(m => m.Contact)
                .FirstOrDefaultAsync(m => m.MeetingId == id && !m.IsDeleted);
        }

    }
}
