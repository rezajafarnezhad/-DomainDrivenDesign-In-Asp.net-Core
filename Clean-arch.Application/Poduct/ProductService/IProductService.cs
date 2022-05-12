using Clean_arch.Application.Poduct.DTOs;

namespace Clean_arch.Application.Poduct.ProductService;

public interface IProductService
{
    ProductDTo GetProductBy(Guid Id);
    List<ProductDTo> GetListProduct();
    void AddProduct(AddProductDTo command);
    void EditProduct(EditProduct command);
    void DeleteProduct(Guid Id);
}