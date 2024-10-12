using Xurmo.Common.Application.Messaging;
using Xurmo.Common.Domain;
using Xurmo.Modules.Catalogs.Application.Abstractions.Data;
using Xurmo.Modules.Catalogs.Domain.Brands;

namespace Xurmo.Modules.Catalogs.Application.Brands.CreateBrand;
internal sealed class CreateBrandCommandHandler(
    IBrandRepository brandRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateBrandCommand, Guid>
{
    public async Task<Result<Guid>> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        var brand = Brand.Create(request.Name);

        brandRepository.Insert(brand);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return brand.Id;
    }
}
