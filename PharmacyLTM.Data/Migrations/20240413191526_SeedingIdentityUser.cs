using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyLTM.Data.Migrations
{
    public partial class SeedingIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 14, 2, 15, 25, 570, DateTimeKind.Local).AddTicks(2501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 13, 22, 12, 52, 160, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "e1ca813a-20d3-4442-ac03-b8c092c429b7", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "aa63b35b-873d-41a2-b337-7bfa6f319c14", new DateTime(2003, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "minltgcd210648@fpt.edu.vn", true, "Trungmin", "Le", false, null, "minltgcd210648@fpt.edu.vn", "admin", "AQAAAAEAACcQAAAAELN7Dx/yTJrdqlJsOhhHkoVQ/YadkzQ4uye3ZVu6TzC8FF3ZlpkKQKW2ObApVyigtw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 14, 2, 15, 25, 594, DateTimeKind.Local).AddTicks(7043));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 13, 22, 12, 52, 160, DateTimeKind.Local).AddTicks(3023),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 14, 2, 15, 25, 570, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 13, 22, 12, 52, 184, DateTimeKind.Local).AddTicks(7936));
        }
    }
}
