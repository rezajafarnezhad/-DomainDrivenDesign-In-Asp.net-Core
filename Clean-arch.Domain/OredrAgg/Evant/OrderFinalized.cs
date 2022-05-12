using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.OredrAgg.Evant;

public class OrderFinalized:BaseDomainEvent
{
    public long OrderId { get; set; }
    public long UserId { get; set; }

    public OrderFinalized(long orderId, long userId)
    {
        OrderId = orderId;
        UserId = userId;
    }
}