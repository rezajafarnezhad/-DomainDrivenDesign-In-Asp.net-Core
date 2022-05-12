using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Product;

public class Product: AggregateRoot
{
    public Guid Id { get;private set; }
    public string Name { get; private set; }
    public int Price { get; private set; }

    public ICollection<ProductImages> Images { get; private set; }

    public Product(string name, int price)
    {
        Guard(name, price);
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
    }

    public void Edit(string name, int price)
    {
        Guard( name,price);
        Name = name;
        Price = price;
    }

    private void Guard(string Name, int Price)
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new ArgumentNullException();
        
        if (Price < 1)
            throw new ArgumentNullException();
    }

    public void AddImage(string ImageName)
    {
        Images.Add(new ProductImages(Id,ImageName));
    }
    public void RemoveImage(long id)
    {
        var Image = Images.FirstOrDefault(c => c.Id == id) ?? throw new ArgumentNullException("Images Null");
        Images.Remove(Image);
    }

}