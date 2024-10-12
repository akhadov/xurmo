using Microsoft.EntityFrameworkCore;
using Xurmo.Modules.Catalogs.Domain.Brands;
using Xurmo.Modules.Catalogs.Infrastructure.Database;

namespace Xurmo.Modules.Catalogs.Infrastructure.Brands;
internal sealed class BrandRepository(CatalogsDbContext context) : IBrandRepository
{

    public async Task<Brand?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await context.Brands.SingleOrDefaultAsync(b => b.Id == id, cancellationToken);
    }

    public void Insert(Brand brand)
    {
        context.Brands.Add(brand);
    }

    public void Update(Brand brand)
    {
        context.Brands.Update(brand);
    }
    public void Delete(Brand brand)
    {
        context.Brands.Remove(brand);
    }
}
