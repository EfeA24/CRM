using Crm.Core.Application.Interfaces.DocumentInterfaces;
using Crm.Core.Domain.Entities.DocumentEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Crm.Infrastructure.Persistance.Repositories.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Infrastructure.Persistance.Repositories.DocumentRepositories
{
    public class PurchaseOfferProductDocumentRepository : GenericRepository<PurchaseOfferProductDocument>, IPurchaseOfferProductDocumentRepository
    {
        private readonly AppDbContext _context;
        public PurchaseOfferProductDocumentRepository(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
