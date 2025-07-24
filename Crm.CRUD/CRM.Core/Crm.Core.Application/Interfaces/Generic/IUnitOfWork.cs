using Crm.Core.Application.Interfaces.MainEntityInterfaces;
using Crm.Core.Application.Interfaces.OfferInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Interfaces.Generic
{
    public interface IUnitOfWork : IDisposable
    {

        ICompanyRepository Company { get; }
        IContactRepository Contact { get; }
        IMeetingRepository Meeting { get; }

        IPurchaseOfferRepository PurchaseOffer { get; }
        ISalesOfferRepository SalesOffer { get; }
        IPurchaseOfferProductRepository PurchaseOfferProduct { get; }
        ISalesOfferProductRepository SalesOfferProduct { get; }

        Task<int> SaveChangesAsync();
    }
}
