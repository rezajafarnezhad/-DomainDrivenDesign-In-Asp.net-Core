namespace Clean_arch.Application.Poduct.DTOs;



public class ProductDTo
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}

public class AddProductDTo
{
    public string Name { get; set; }
    public int Price { get; set; }
}


public class EditProduct : AddProductDTo
{
    public Guid Id { get; set; }
}