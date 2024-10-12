using Microsoft.EntityFrameworkCore;
using Xurmo.Modules.Catalogs.Domain.Categories;
using Xurmo.Modules.Catalogs.Infrastructure.Database;

namespace Xurmo.Modules.Catalogs.Infrastructure.Categories;
internal sealed class CategoryRepository(CatalogsDbContext context) : ICategoryRepository
{
    public async Task<Category?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await context.Categories.SingleOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public void Insert(Category category)
    {
        context.Categories.Add(category);
    }

    public void Update(Category category)
    {
        context.Update(category);
    }
    public void Delete(Category category)
    {
        context.Remove(category);
    }
}
