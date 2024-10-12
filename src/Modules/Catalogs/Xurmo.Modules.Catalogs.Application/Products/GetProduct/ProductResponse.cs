namespace Xurmo.Modules.Catalogs.Application.Products.GetProduct;
public sealed record ProductResponse(
    Guid Id,
    Guid CategoryId,
    Guid BrandId,
    string Name,
    string Description,
    string ImagePath);
