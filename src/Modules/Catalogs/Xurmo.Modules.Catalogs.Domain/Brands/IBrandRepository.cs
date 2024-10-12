namespace Xurmo.Modules.Catalogs.Domain.Brands;
public interface IBrandRepository
{
    Task<Brand?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Brand brand);

    void Update(Brand brand);

    void Delete(Brand brand);
}
