using Microsoft.AspNetCore.Http;

namespace Xurmo.Modules.Catalogs.Application.Products.CreateProduct;
public sealed record CreateProductRequest(
    Guid CategoryId,
    Guid BrandId,
    string Name,
    string Description,
    IFormFile Image);
