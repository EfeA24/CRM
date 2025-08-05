using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company;
using Crm.Core.Application.Features.Mapping.MainEntities;
using Crm.Infrastructure.Persistance.DataContexts;
using Crm.Infrastructure.Persistance.Repositories.GenericRepositories;
using Crm.Infrastructure.Persistance.Repositories.MainEntityRepositories;
using Crm.Infrastructure.Persistance.Repositories.OfferRepositories;
using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Application.Interfaces.MainEntityInterfaces;
using Crm.Core.Application.Interfaces.OfferInterfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CRM.Presentation.Api.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddCrmServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IMeetingRepository, MeetingRepository>();
        services.AddScoped<IPurchaseOfferRepository, PurchaseOfferRepository>();
        services.AddScoped<ISalesOfferRepository, SalesOfferRepository>();
        services.AddScoped<IPurchaseOfferProductRepository, PurchaseOfferProductRepository>();
        services.AddScoped<ISalesOfferProductRepository, SaleOfferProductRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddAutoMapper(typeof(MainEntityMappingProfile));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateCompanyCommand>());

        return services;
    }
}