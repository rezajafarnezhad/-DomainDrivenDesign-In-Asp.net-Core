using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Oredr;

public class OrderItem : BaseEntity
{
    public long Id { get; private set; }
    public long OrderId { get; protected set; }
    public Guid ProductId { get; private set; }
    public int Count { get; private set; }
    public int Price { get; private set; }


    public OrderItem(long orderId, Guid productId, int count, int price)
    {
        OrderId = orderId;
        ProductId = productId;
        Count = count;
        Price = price;
    }
}