using Crm.Core.Application.Interfaces.DocumentInterfaces;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Application.Interfaces.MainEntityInterfaces;
using Crm.Core.Application.Interfaces.OfferInterfaces;
using Crm.Infrastructure.Persistance.DataContexts;
using System;
using System.Threading.Tasks;

namespace Crm.Infrastructure.Persistance.Repositories.GenericRepositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context,
                          IPurchaseOfferDocumentRepository purchaseOfferDocument,
                          IPurchaseOfferProductDocumentRepository purchaseOfferProductDocument,
                          ISalesOfferDocumentRepository salesOfferDocument,
                          ISalesOfferProductDocumentRepository salesOfferProductDocument,
                          ICompanyRepository company,
                          IContactRepository contact,
                          IMeetingRepository meeting,
                          IPurchaseOfferRepository purchaseOffer,
                          ISalesOfferRepository salesOffer,
                          IPurchaseOfferProductRepository purchaseOfferProduct,
                          ISalesOfferProductRepository salesOfferProduct)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            PurchaseOfferDocument = purchaseOfferDocument;
            PurchaseOfferProductDocument = purchaseOfferProductDocument;
            SalesOfferDocument = salesOfferDocument;
            SalesOfferProductDocument = salesOfferProductDocument;
            Company = company;
            Contact = contact;
            Meeting = meeting;
            PurchaseOffer = purchaseOffer;
            SalesOffer = salesOffer;
            PurchaseOfferProduct = purchaseOfferProduct;
            SalesOfferProduct = salesOfferProduct;
        }

        public IPurchaseOfferDocumentRepository PurchaseOfferDocument { get; }
        public IPurchaseOfferProductDocumentRepository PurchaseOfferProductDocument { get; }
        public ISalesOfferDocumentRepository SalesOfferDocument { get; }
        public ISalesOfferProductDocumentRepository SalesOfferProductDocument { get; }
        public ICompanyRepository Company { get; }
        public IContactRepository Contact { get; }
        public IMeetingRepository Meeting { get; }
        public IPurchaseOfferRepository PurchaseOffer { get; }
        public ISalesOfferRepository SalesOffer { get; }
        public IPurchaseOfferProductRepository PurchaseOfferProduct { get; }
        public ISalesOfferProductRepository SalesOfferProduct { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
