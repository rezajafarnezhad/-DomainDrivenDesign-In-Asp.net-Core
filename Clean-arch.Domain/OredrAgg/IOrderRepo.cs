namespace Clean_arch.Domain.Oredr;

public interface IOrderRepo
{
    List<Order> GetList();
    Order GetOrderBy(long Id);
    void AddOrder(Order command);
    void UpdateOrder(Order command);
    void Save();

}