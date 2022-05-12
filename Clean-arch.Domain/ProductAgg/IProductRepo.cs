namespace Clean_arch.Domain.Product;

public interface IProductRepo
{
    List<Product> GetList();
    Product GetProductBy(Guid Id);
    void AddProduct(Product command);
    void UpdateProduct(Product command);
    void DeleteProduct(Product command);
    void Save();
    bool IsProductExists(Guid Id);
}