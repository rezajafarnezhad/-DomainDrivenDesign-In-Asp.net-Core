using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Product;

public class ProductImages:BaseEntity
{
    public long Id { get; private set; }
    public Guid ProductId { get; private set; }
    public string ImageName { get; private set; }


    public ProductImages( Guid productId, string imageName)
    {
        ProductId = productId;

        if (string.IsNullOrWhiteSpace(imageName))
            throw new Exception("ImageName is Null");

        ImageName = imageName;
    }
}