using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastnMenu.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Companies_CompanyId",
                table: "Menus");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyTypeId",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 1, "Restoran" });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 2, "Kafe" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "CompanyTypeId", "Description", "Email", "IsActive", "Phone", "Picture", "QRCode", "SubscriptionExpiryDate", "SubscriptionStartDate", "WorkHour" },
                values: new object[] { 1, "Pendik/İstanbul", "Feramuz Restoran", 1, "Uygun Fiyat Kaliteli Yemek", "feramuzrestoran@gmail.com", true, "02164999999", "https://g7.pngresmi.com/preview/524/137/77/gluten-free-diet-logo-celiac-disease-wheat-vector-restaurant-logo.jpg", "5f3d7a4f29acbf385a539ee6", new DateTime(2020, 9, 7, 20, 33, 27, 819, DateTimeKind.Local).AddTicks(9118), new DateTime(2020, 9, 7, 19, 33, 27, 818, DateTimeKind.Local).AddTicks(6365), "8-20" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CompanyId", "Discount", "Explanation", "Name", "Picture", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, 0.0, null, "Sahanda Yumurta", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 10.0, "Tereyağlı sahanda yumurta" },
                    { 2, 1, 0.0, null, "Didi Soğuk Çay", "https://www.caykursatis.com/didi-500-ml-seftali-aromali-soguk-cay-caykur-soguk-cay-soguk-cay-caykur-soguk-cay-618-13-O.jpg", 4.0, "Kutu Didi Soğuk Çay" },
                    { 3, 1, 0.0, null, "Bardak Çay", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 2.0, "İnce belli bardak çay" },
                    { 4, 1, 0.0, null, "Fincan Çay", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 4.0, "Fincan Çay" },
                    { 5, 1, 0.0, null, "Fırında Çöp Şiş", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 30.0, "Fırında Tavuk Çöp Şiş" },
                    { 6, 1, 0.0, null, "Pilav", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 7.5, "Pirinç Pilavı" },
                    { 7, 1, 0.0, null, "Adana Kebap", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 10.0, "Nefis Adana Kebap" },
                    { 8, 1, 0.0, null, "Sütlaç", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 10.0, "Sütlaç" },
                    { 9, 1, 0.0, null, "Magnolia", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 10.0, "Kat kat puding ve bisküvi parçacıkları" },
                    { 10, 1, 0.0, null, "Tavuklu Patates Yemeği", "https://harbiyiyorum.com/wp-content/uploads/sahanda-yumurta-ft.jpg", 10.0, "Nefis Tavuklu Patates Yemeği" }
                });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "CategoryId", "MenuId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 4, 10 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Companies_CompanyId",
                table: "Menus",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Companies_CompanyId",
                table: "Menus");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumns: new[] { "CategoryId", "MenuId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Menus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyTypeId",
                table: "Companies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Companies_CompanyId",
                table: "Menus",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
