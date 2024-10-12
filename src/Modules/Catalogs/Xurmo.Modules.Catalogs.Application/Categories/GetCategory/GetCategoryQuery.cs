using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Categories.GetCategory;
public sealed record GetCategoryQuery(Guid CategoryId) : IQuery<CategoryResponse>;
