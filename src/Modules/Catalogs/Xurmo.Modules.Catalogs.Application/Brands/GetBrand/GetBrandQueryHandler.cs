using System.Data.Common;
using Dapper;
using Xurmo.Common.Application.Data;
using Xurmo.Common.Application.Messaging;
using Xurmo.Common.Domain;
using Xurmo.Modules.Catalogs.Domain.Brands;

namespace Xurmo.Modules.Catalogs.Application.Brands.GetBrand;
internal sealed class GetBrandQueryHandler(IDbConnectionFactory dbConnectionFactory)
    : IQueryHandler<GetBrandQuery, BrandResponse>
{
    public async Task<Result<BrandResponse>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
    {
        await using DbConnection connection = await dbConnectionFactory.OpenConnectionAsync();

        const string sql =
            $"""
             SELECT
                 id AS {nameof(BrandResponse.Id)},
                 name AS {nameof(BrandResponse.Name)}
             FROM catalogs.brands
             WHERE id = @BrandId
             """;

        BrandResponse? brand = await connection.QuerySingleOrDefaultAsync<BrandResponse>(sql, request);

        if (brand is null)
        {
            return Result.Failure<BrandResponse>(BrandErrors.NotFound(request.BrandId));
        }

        return brand;
    }
}
