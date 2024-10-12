using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Categories.UpdateCategory;
public sealed record UpdateCategoryCommand(Guid CategoryId, string Name) : ICommand;
