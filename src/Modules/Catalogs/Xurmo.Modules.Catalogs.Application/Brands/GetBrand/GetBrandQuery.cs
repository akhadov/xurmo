using Xurmo.Common.Application.Messaging;

namespace Xurmo.Modules.Catalogs.Application.Brands.GetBrand;
public sealed record GetBrandQuery(Guid BrandId) : IQuery<BrandResponse>;
