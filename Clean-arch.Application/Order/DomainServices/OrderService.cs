using Clean_arch.Domain.OredrAgg.Services;
using Clean_arch.Domain.Product;

namespace Clean_arch.Application.Order.DomainServices;

public class OrderDomainService : IOrderDomainService
{
    private IProductRepo _productRepo;
    public OrderDomainService(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }
    public bool IsProductNotExists(Guid ProductId)
    {
        return !_productRepo.IsProductExists(ProductId);
    }
}