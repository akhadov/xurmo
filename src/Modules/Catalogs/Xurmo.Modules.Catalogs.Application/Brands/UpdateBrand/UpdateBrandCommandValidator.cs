using FluentValidation;

namespace Xurmo.Modules.Catalogs.Application.Brands.UpdateBrand;
internal sealed class UpdateBrandCommandValidator : AbstractValidator<UpdateBrandCommand>
{
    public UpdateBrandCommandValidator()
    {
        RuleFor(b => b.BrandId).NotEmpty();
        RuleFor(b => b.Name).NotEmpty();
    }
}
