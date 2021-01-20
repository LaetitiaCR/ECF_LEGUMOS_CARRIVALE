using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECF_LEGUMOS_CARRIVALE.Migrations
{
    public partial class LegumosBddMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaleWeight = table.Column<int>(type: "int", nullable: false),
                    SaleUnitPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SaleActive = table.Column<int>(type: "int", nullable: false),
                    VegetableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Vegetables",
                columns: table => new
                {
                    VegetableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Variety = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimaryColor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LifeTime = table.Column<int>(type: "int", nullable: false),
                    Fresh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetables", x => x.VegetableId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Vegetables");
        }
    }
}
