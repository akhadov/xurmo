using Xurmo.Common.Domain;

namespace Xurmo.Modules.Catalogs.Domain.Brands;
public static class BrandErrors
{
    public static Error NotFound(Guid brandId) =>
        Error.NotFound("Brands.NotFound", $"The brand with the identifier {brandId} was not found");
}
