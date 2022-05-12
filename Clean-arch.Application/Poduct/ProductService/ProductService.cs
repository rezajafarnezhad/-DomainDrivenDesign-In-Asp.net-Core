using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean_arch.Application.Poduct.DTOs;
using Clean_arch.Domain.Product;

namespace Clean_arch.Application.Poduct.ProductService;

public class ProductService : IProductService
{
    private readonly IProductRepo _productRepo;

    public ProductService(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    public ProductDTo GetProductBy(Guid Id)
    {
        var Product = _productRepo.GetProductBy(Id);
        return new()
        {
            Id = Product.Id,
            Price = Product.Price,
            Name = Product.Name,
        };
    }

    public List<ProductDTo> GetListProduct()
    {
        return _productRepo.GetList().Select(c => new ProductDTo()
        {
            Price = c.Price,
            Id = c.Id,
            Name = c.Name
        }).ToList();
    }

    public void AddProduct(AddProductDTo command)
    {
        var Product = new Product(command.Name, command.Price);
        _productRepo.AddProduct(Product);
        _productRepo.Save();
    }

    public void EditProduct(EditProduct command)
    {
        var Product = _productRepo.GetProductBy(command.Id);
        Product.Edit(command.Name,command.Price);
        _productRepo.UpdateProduct(Product);
        _productRepo.Save();
    }

    public void DeleteProduct(Guid Id)
    {
        var Product = _productRepo.GetProductBy(Id);
        _productRepo.DeleteProduct(Product);
        _productRepo.Save();
    }

}