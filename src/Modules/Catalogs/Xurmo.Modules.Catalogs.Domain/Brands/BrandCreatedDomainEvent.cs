using Xurmo.Common.Domain;

namespace Xurmo.Modules.Catalogs.Domain.Brands;
public sealed class BrandCreatedDomainEvent(Guid brandId) : DomainEvent
{
    public Guid brandId { get; init; } = brandId;
}
