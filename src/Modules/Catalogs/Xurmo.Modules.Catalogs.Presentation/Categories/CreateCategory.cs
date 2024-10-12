using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Xurmo.Common.Domain;
using Xurmo.Common.Presentation.Endpoints;
using Xurmo.Common.Presentation.Results;
using Xurmo.Modules.Catalogs.Application.Categories.CreateCategory;

namespace Xurmo.Modules.Catalogs.Presentation.Categories;
internal sealed class CreateCategory : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("categories", async (Request request, ISender sender) =>
        {
            Result<Guid> result = await sender.Send(new CreateCategoryCommand(request.Name));

            return result.Match(Results.Ok, ApiResults.Problem);
        })
        .WithTags(Tags.Categories);
    }

    internal sealed class Request
    {
        public string Name { get; init; }
    }
}
