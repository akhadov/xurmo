namespace Xurmo.Modules.Catalogs.Domain.Categories;
public interface ICategoryRepository
{
    Task<Category?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Category category);

    void Update(Category category);

    void Delete(Category category);
}
