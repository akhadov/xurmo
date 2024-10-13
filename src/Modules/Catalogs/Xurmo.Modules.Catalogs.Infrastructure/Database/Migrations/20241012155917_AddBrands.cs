// < auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xurmo.Modules.Catalogs.Infrastructure.Database.Migrations;

/// <inheritdoc />
public partial class AddBrands : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<Guid>(
            name: "brand_id",
            schema: "catalogs",
            table: "products",
            type: "uuid",
            nullable: false,
            defaultValue: Guid.Empty);

        migrationBuilder.AddColumn<Guid>(
            name: "category_id",
            schema: "catalogs",
            table: "products",
            type: "uuid",
            nullable: false,
            defaultValue: Guid.Empty);

        migrationBuilder.CreateTable(
            name: "brands",
            schema: "catalogs",
            columns: table => new
            {
                id = table.Column<Guid>(type: "uuid", nullable: false),
                name = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_brands", x => x.id);
            });

        migrationBuilder.CreateTable(
            name: "categories",
            schema: "catalogs",
            columns: table => new
            {
                id = table.Column<Guid>(type: "uuid", nullable: false),
                name = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_categories", x => x.id);
            });

        migrationBuilder.CreateIndex(
            name: "ix_products_brand_id",
            schema: "catalogs",
            table: "products",
            column: "brand_id");

        migrationBuilder.CreateIndex(
            name: "ix_products_category_id",
            schema: "catalogs",
            table: "products",
            column: "category_id");

        migrationBuilder.AddForeignKey(
            name: "fk_products_brands_brand_id",
            schema: "catalogs",
            table: "products",
            column: "brand_id",
            principalSchema: "catalogs",
            principalTable: "brands",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "fk_products_categories_category_id",
            schema: "catalogs",
            table: "products",
            column: "category_id",
            principalSchema: "catalogs",
            principalTable: "categories",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "fk_products_brands_brand_id",
            schema: "catalogs",
            table: "products");

        migrationBuilder.DropForeignKey(
            name: "fk_products_categories_category_id",
            schema: "catalogs",
            table: "products");

        migrationBuilder.DropTable(
            name: "brands",
            schema: "catalogs");

        migrationBuilder.DropTable(
            name: "categories",
            schema: "catalogs");

        migrationBuilder.DropIndex(
            name: "ix_products_brand_id",
            schema: "catalogs",
            table: "products");

        migrationBuilder.DropIndex(
            name: "ix_products_category_id",
            schema: "catalogs",
            table: "products");

        migrationBuilder.DropColumn(
            name: "brand_id",
            schema: "catalogs",
            table: "products");

        migrationBuilder.DropColumn(
            name: "category_id",
            schema: "catalogs",
            table: "products");
    }
}
