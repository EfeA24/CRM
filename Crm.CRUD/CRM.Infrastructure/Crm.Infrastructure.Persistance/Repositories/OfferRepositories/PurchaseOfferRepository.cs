using Crm.Core.Application.Interfaces.OfferInterfaces;
using Crm.Core.Domain.Entities.OfferEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Crm.Infrastructure.Persistance.Repositories.GenericRepositories;
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
    }
}
