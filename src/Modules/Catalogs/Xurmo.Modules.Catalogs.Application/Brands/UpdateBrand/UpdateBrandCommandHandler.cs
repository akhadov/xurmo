using Xurmo.Common.Application.Messaging;
using Xurmo.Common.Domain;
using Xurmo.Modules.Catalogs.Application.Abstractions.Data;
using Xurmo.Modules.Catalogs.Domain.Brands;
using Xurmo.Modules.Catalogs.Domain.Categories;

namespace Xurmo.Modules.Catalogs.Application.Brands.UpdateBrand;
internal sealed class UpdateBrandCommandHandler(
    IBrandRepository brandRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<UpdateBrandCommand>
{
    public async Task<Result> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
    {
        Brand? brand = await brandRepository.GetAsync(request.BrandId, cancellationToken);

        if (brand is null)
        {
            return Result.Failure(CategoryErrors.NotFound(request.BrandId));
        }

        brand.ChangeName(request.Name);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
