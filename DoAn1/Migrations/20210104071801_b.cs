using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAn1.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "255586ff-bd32-479d-ab17-2220244c809b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d17f7e-bf0a-4d6b-9e97-4c5ac8290086");

            migrationBuilder.AddColumn<double>(
                name: "TongTien",
                table: "HoaDon",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc24da37-94b9-41d3-bffa-22773f14f404", "62384bc3-a876-4b51-8886-93ad5e980d10", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2036579e-7f41-4b1b-9a60-5438abb51630", "9fbe114e-febf-49a3-8eaa-27ea22d3871e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2036579e-7f41-4b1b-9a60-5438abb51630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc24da37-94b9-41d3-bffa-22773f14f404");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "HoaDon");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3d17f7e-bf0a-4d6b-9e97-4c5ac8290086", "9fe9205b-7941-4eb4-aa5f-a8a7820d45f1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "255586ff-bd32-479d-ab17-2220244c809b", "88cc2aba-228d-4554-94f0-cd1863c36f2d", "Admin", "ADMIN" });
        }
    }
}
