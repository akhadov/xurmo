using FluentValidation;

namespace Xurmo.Modules.Catalogs.Application.Products.CreateProduct;
internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.CategoryId).NotEmpty();
        RuleFor(p => p.BrandId).NotEmpty();
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Description).NotEmpty();
        RuleFor(p => p.Image).NotEmpty();
    }
}
