using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductManagementApi.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    HsnCode = table.Column<int>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    Sgst = table.Column<int>(nullable: true),
                    Igst = table.Column<int>(nullable: true),
                    Mrp = table.Column<double>(nullable: true),
                    PurchaseWithoutTax = table.Column<double>(nullable: true),
                    PuchaseWithTax = table.Column<double>(nullable: true),
                    SellingPrice = table.Column<double>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.HsnCode);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "HsnCode", "Company", "Description", "Igst", "Mrp", "Name", "PartNumber", "PuchaseWithTax", "PurchaseWithoutTax", "Qty", "SellingPrice", "Sgst" },
                values: new object[] { 85365090, "BOSCH", "RBCSBC(BATTERY CUT)", 9, 866.0, "Battery Cut", "RBCSBC", 750.0, 650.0, 30, 850.0, 9 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "HsnCode", "Company", "Description", "Igst", "Mrp", "Name", "PartNumber", "PuchaseWithTax", "PurchaseWithoutTax", "Qty", "SellingPrice", "Sgst" },
                values: new object[] { 85365060, "TELCO", "TX 88512WOS-AL (Bearing)", 9, 1600.0, "Bearing", "TX 88512WOS-AL", 1200.0, 1100.0, 10, 1550.0, 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
