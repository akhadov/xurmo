using Xurmo.Common.Domain;

namespace Xurmo.Modules.Catalogs.Domain.Brands;
public sealed class BrandNameChangedDomainEvent(Guid brandId, string name) : DomainEvent
{
    public Guid BrandId { get; init; } = brandId;

    public string Name { get; init; } = name;
}
