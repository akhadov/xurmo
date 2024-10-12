using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Brands.CreateBrand;
public sealed record CreateBrandCommand(string Name) : ICommand<Guid>;
