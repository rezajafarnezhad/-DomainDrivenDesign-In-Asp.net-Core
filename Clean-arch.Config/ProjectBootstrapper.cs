using Clean_arch.Application.Order.DomainServices;
using Clean_arch.Application.Order.OrderService;
using Clean_arch.Application.Poduct.ProductService;
using Clean_arch.Contracts;
using Clean_arch.Domain.OredrAgg.Services;
using Clean_arch.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Clean_arch.Config;
public static class ProjectBootstrapper
{
    public static void Init(this IServiceCollection service)
    {
        service.AddScoped<IOrderService, OrderService>();
        service.AddScoped<IProductService, ProductService>();
        service.AddScoped<ISmsService,SmsService>();
        service.AddScoped<IOrderDomainService, OrderDomainService>();
    }
}