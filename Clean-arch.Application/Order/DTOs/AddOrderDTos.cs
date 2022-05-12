namespace Clean_arch.Application.Order.DTOs;

public class AddOrderDTo
{
    public Guid ProductId { get; set; }
    public int Count { get;  set; }
    public int Price { get;  set; }
}

public class OrderDTo
{
    public long Id { get; set; }
    public Guid ProductId { get; set; }
    public int Count { get;  set; }
    public int Price { get;  set; }
}

public class FinallyOrderDto
{
    public long  Id { get; set; }
}