using Clean_arch.Domain.OredrAgg.Evant;
using Clean_arch.Domain.OredrAgg.Services;
using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Oredr;

public class Order: AggregateRoot
{
    public long Id { get; private set; }
    public long UserId { get; private set; }

    public long TotalPrice;
    public long TotalItems { get; private set; }
    public bool IsFinally { get;private set; }
    public DateTime FinallyDateTime { get;private set; }

    public ICollection<OrderItem> Items { get;private set; }

    public Order(long userId)
    {
        UserId = userId;
      
    }

    public void AddItem(Guid ProductId,int count,int price,IOrderDomainService OrderDomainService)
    {
        if (OrderDomainService.IsProductNotExists(ProductId))
            throw new Exception("s");

        if(Items.Any(c=>c.ProductId == ProductId))
            throw new Exception("The product is in items");


        Items.Add(new OrderItem(Id,ProductId,count,price));
        TotalItems += count;
    }
    public void RemoveItem(Guid ProductId)
    {
        var item = Items.FirstOrDefault(c => c.ProductId == ProductId);
        if (item == null)
            throw new Exception("Null");

        TotalItems -= item.Count;
    }

    public void Finally()
    {
        IsFinally = true;
        FinallyDateTime = DateTime.Now;
        AddDomainEvent(new OrderFinalized(Id,UserId));
    }

}