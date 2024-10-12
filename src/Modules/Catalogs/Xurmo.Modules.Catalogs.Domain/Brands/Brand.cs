using Xurmo.Common.Domain;

namespace Xurmo.Modules.Catalogs.Domain.Brands;
public sealed class Brand : Entity
{
    private Brand()
    {
    }

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public static Brand Create(
        string name)
    {
        var brand = new Brand
        {
            Id = Guid.NewGuid(),
            Name = name
        };

        brand.Raise(new BrandCreatedDomainEvent(brand.Id));

        return brand;
    }

    public void ChangeName(string name)
    {
        if (Name == name)
        {
            return;
        }

        Name = name;

        Raise(new BrandNameChangedDomainEvent(Id, Name));
    }
}
