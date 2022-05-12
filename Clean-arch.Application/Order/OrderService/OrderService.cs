using Clean_arch.Application.Order.DTOs;
using Clean_arch.Contracts;
using Clean_arch.Domain.Oredr;

namespace Clean_arch.Application.Order.OrderService;

public class OrderService : IOrderService
{
    private readonly IOrderRepo _orderRepo;
    private readonly ISmsService _smsService;

    public OrderService(IOrderRepo orderRepo, ISmsService smsService)
    {
        _orderRepo = orderRepo;
        _smsService = smsService;
    }

    public void AddOrder(AddOrderDTo command)
    {
        throw new NotImplementedException();
    }

    public void FinallyOrder(FinallyOrderDto commad)
    {
        throw new NotImplementedException();
    }

    public OrderDTo GetBy(long Id)
    {
        throw new NotImplementedException();
    }

    public List<OrderDTo> GetOrders()
    {
        throw new NotImplementedException();
    }
}