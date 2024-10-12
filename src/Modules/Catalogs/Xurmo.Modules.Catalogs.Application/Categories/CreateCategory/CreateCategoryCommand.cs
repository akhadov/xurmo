using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Categories.CreateCategory;
public sealed record CreateCategoryCommand(string Name) : ICommand<Guid>;
