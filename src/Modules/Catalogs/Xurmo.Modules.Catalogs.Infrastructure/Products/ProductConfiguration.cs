using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xurmo.Modules.Catalogs.Domain.Brands;
using Xurmo.Modules.Catalogs.Domain.Categories;
using Xurmo.Modules.Catalogs.Domain.Products;

namespace Xurmo.Modules.Catalogs.Infrastructure.Products;
internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne<Category>().WithMany().HasForeignKey(p => p.CategoryId);

        builder.HasOne<Brand>().WithMany().HasForeignKey(p => p.BrandId);
    }
}
