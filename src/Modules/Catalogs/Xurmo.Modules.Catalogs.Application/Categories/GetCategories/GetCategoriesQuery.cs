using Xurmo.Common.Application.Messaging;
using Xurmo.Modules.Catalogs.Application.Categories.GetCategory;

namespace Xurmo.Modules.Catalogs.Application.Categories.GetCategories;
public sealed record GetCategoriesQuery : IQuery<IReadOnlyCollection<CategoryResponse>>;
