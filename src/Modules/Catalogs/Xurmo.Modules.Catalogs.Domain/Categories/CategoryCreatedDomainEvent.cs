using Xurmo.Common.Domain;

namespace Xurmo.Modules.Catalogs.Domain.Categories;
public sealed class CategoryCreatedDomainEvent(Guid categoryId) : DomainEvent
{
    public Guid CategoryId { get; init; } = categoryId;
}
