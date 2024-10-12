using FluentValidation;

namespace Xurmo.Modules.Catalogs.Application.Categories.CreateCategory;
internal sealed class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
    }
}
