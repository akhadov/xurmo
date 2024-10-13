using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Xurmo.Common.Domain;
using Xurmo.Common.Presentation.Endpoints;
using Xurmo.Common.Presentation.Results;
using Xurmo.Modules.Catalogs.Application.Brands.GetBrand;
using Xurmo.Modules.Catalogs.Application.Brands.GetBrands;

namespace Xurmo.Modules.Catalogs.Presentation.Brands;
internal sealed class GetBrands : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("catalogs/brands", async (ISender sender) =>
        {
            Result<IReadOnlyCollection<BrandResponse>> result = await sender.Send(new GetBrandsQuery());

            return result.Match(Results.Ok, ApiResults.Problem);
        })
        .WithTags(Tags.Brands);
    }
}
