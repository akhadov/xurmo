using Microsoft.AspNetCore.Http;
using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Products.CreateProduct;
public sealed record CreateProductCommand(
    Guid CategoryId,
    Guid BrandId,
    string Name,
    string Description,
    IFormFile Image) : ICommand<Guid>;
