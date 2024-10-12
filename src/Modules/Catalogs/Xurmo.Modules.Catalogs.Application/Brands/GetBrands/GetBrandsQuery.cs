using Xurmo.Common.Application.Messaging;
using Xurmo.Modules.Catalogs.Application.Brands.GetBrand;

namespace Xurmo.Modules.Catalogs.Application.Brands.GetBrands;
public sealed record GetBrandsQuery : IQuery<IReadOnlyCollection<BrandResponse>>;
