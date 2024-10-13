using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Xurmo.Common.Domain;
using Xurmo.Common.Presentation.Endpoints;
using Xurmo.Common.Presentation.Results;
using Xurmo.Modules.Catalogs.Application.Brands.GetBrand;

namespace Xurmo.Modules.Catalogs.Presentation.Brands;
internal sealed class GetBrand : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("catalogs/brands/{id}", async (Guid id, ISender sender) =>
        {
            Result<BrandResponse> result = await sender.Send(new GetBrandQuery(id));

            return result.Match(Results.Ok, ApiResults.Problem);
        })
        .WithTags(Tags.Brands);
    }
}
