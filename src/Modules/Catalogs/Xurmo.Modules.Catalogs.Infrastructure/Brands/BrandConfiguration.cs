using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xurmo.Modules.Catalogs.Domain.Brands;

namespace Xurmo.Modules.Catalogs.Infrastructure.Brands;
internal sealed class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasKey(b => b.Id);

        builder.HasIndex(b => b.Name).IsUnique();
    }
}
