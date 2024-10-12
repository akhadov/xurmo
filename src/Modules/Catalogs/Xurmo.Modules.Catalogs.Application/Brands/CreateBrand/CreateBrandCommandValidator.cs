using FluentValidation;

namespace Xurmo.Modules.Catalogs.Application.Brands.CreateBrand;
internal sealed class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        RuleFor(b => b.Name).NotEmpty();
    }
}
