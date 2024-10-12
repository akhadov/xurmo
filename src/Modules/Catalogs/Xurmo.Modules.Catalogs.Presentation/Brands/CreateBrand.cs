using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Xurmo.Common.Domain;
using Xurmo.Common.Presentation.Endpoints;
using Xurmo.Common.Presentation.Results;
using Xurmo.Modules.Catalogs.Application.Brands.CreateBrand;

namespace Xurmo.Modules.Catalogs.Presentation.Brands;
internal sealed class CreateBrand : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("brands", async (Request request, ISender sender) =>
        {
            Result<Guid> result = await sender.Send(new CreateBrandCommand(request.Name));

            return result.Match(Results.Ok, ApiResults.Problem);
        })
        .WithTags(Tags.Brands);
    }

    internal sealed class Request
    {
        public string Name { get; init; }
    }
}
