using System.Data.Common;
using Dapper;
using Xurmo.Common.Application.Data;
using Xurmo.Common.Application.Messaging;
using Xurmo.Common.Domain;
using Xurmo.Modules.Catalogs.Application.Brands.GetBrand;

namespace Xurmo.Modules.Catalogs.Application.Brands.GetBrands;
internal sealed class GetBrandsQueryHandler(IDbConnectionFactory dbConnectionFactory)
    : IQueryHandler<GetBrandsQuery, IReadOnlyCollection<BrandResponse>>
{
    public async Task<Result<IReadOnlyCollection<BrandResponse>>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
    {
        await using DbConnection connection = await dbConnectionFactory.OpenConnectionAsync();

        const string sql =
            $"""
             SELECT
                 id AS {nameof(BrandResponse.Id)},
                 name AS {nameof(BrandResponse.Name)}
             FROM catalogs.brands
             """;

        List<BrandResponse> brands = (await connection.QueryAsync<BrandResponse>(sql, request)).AsList();

        return brands;
    }
}
