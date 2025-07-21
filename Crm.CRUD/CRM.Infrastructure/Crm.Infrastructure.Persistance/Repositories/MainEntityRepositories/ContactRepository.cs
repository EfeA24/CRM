using Crm.Core.Application.Interfaces.MainEntityInterfaces;
using Crm.Core.Domain.Entities.MainEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Crm.Infrastructure.Persistance.Repositories.GenericRepositories;
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
    }
}
