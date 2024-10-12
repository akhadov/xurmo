using Xurmo.Common.Application.FileStorage;
using Xurmo.Common.Application.Messaging;
using Xurmo.Common.Domain;
using Xurmo.Modules.Catalogs.Application.Abstractions.Data;
using Xurmo.Modules.Catalogs.Domain.Brands;
using Xurmo.Modules.Catalogs.Domain.Categories;
using Xurmo.Modules.Catalogs.Domain.Products;

namespace Xurmo.Modules.Catalogs.Application.Products.CreateProduct;
internal sealed class CreateProductCommandHandler(
    IProductRepository productRepository,
    ICategoryRepository categoryRepository,
    IBrandRepository brandRepository,
    IFileStorageService file,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateProductCommand, Guid>
{
    public async Task<Result<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Category? category = await categoryRepository.GetAsync(request.CategoryId, cancellationToken);

        if (category is null)
        {
            return Result.Failure<Guid>(CategoryErrors.NotFound(request.CategoryId));
        }

        Brand? brand = await brandRepository.GetAsync(request.BrandId, cancellationToken);

        if (brand is null)
        {
            return Result.Failure<Guid>(BrandErrors.NotFound(request.BrandId));
        }

        string productImagePath = await file.UploadAsync(request.Image, cancellationToken);

        var product = Product.Create(category, brand, request.Name, request.Description, productImagePath);

        productRepository.Insert(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id;
    }
}
