using Xurmo.Common.Domain;
using Xurmo.Modules.Catalogs.Domain.Brands;
using Xurmo.Modules.Catalogs.Domain.Categories;

namespace Xurmo.Modules.Catalogs.Domain.Products;

public sealed class Product : Entity
{
    private Product() { }

    public Guid Id { get; private set; }

    public Guid CategoryId { get; private set; }

    public Guid BrandId { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public string ImagePath { get; private set; }

    public static Product Create(
        Category category,
        Brand brand,
        string name,
        string description,
        string imagePath)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            CategoryId = category.Id,
            BrandId = brand.Id,
            Name = name,
            Description = description,
            ImagePath = imagePath
        };

        product.Raise(new ProductCreatedDomainEvent(product.Id));

        return product;
    }
}
