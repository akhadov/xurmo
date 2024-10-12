using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Brands.UpdateBrand;
public sealed record UpdateBrandCommand(Guid BrandId, string Name) : ICommand;
