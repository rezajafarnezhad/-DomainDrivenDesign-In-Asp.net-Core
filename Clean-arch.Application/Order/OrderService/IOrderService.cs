using Clean_arch.Application.Order.DTOs;

namespace Clean_arch.Application.Order.OrderService;

public interface IOrderService
{
    void AddOrder(AddOrderDTo command);
    void FinallyOrder(FinallyOrderDto commad);
    OrderDTo GetBy(long Id);
    List<OrderDTo> GetOrders();
}