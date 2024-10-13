using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Xurmo.Common.Domain;
using Xurmo.Common.Presentation.Endpoints;
using Xurmo.Common.Presentation.Results;
using Xurmo.Modules.Catalogs.Application.Brands.UpdateBrand;

namespace Xurmo.Modules.Catalogs.Presentation.Brands;
internal sealed class UpdateBrand : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("catalogs/brands/{id}", async (Guid id, Request request, ISender sender) =>
        {
            Result result = await sender.Send(new UpdateBrandCommand(id, request.Name));

            return result.Match(() => Results.Ok(), ApiResults.Problem);
        })
         .WithTags(Tags.Brands);
    }

    internal sealed class Request
    {
        public string Name { get; init; }
    }
}
