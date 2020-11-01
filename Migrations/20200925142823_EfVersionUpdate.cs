using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastnMenu.Migrations
{
    public partial class EfVersionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.CreateTable(
                name: "CategoryMenu",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Menu_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMenu", x => new { x.Category_Id, x.Menu_Id });
                    table.ForeignKey(
                        name: "FK_CategoryMenu_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMenu_Menus_Menu_Id",
                        column: x => x.Menu_Id,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SubscriptionExpiryDate", "SubscriptionStartDate" },
                values: new object[] { new DateTime(2020, 9, 25, 18, 28, 22, 400, DateTimeKind.Local).AddTicks(7121), new DateTime(2020, 9, 25, 17, 28, 22, 399, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMenu_Menu_Id",
                table: "CategoryMenu",
                column: "Menu_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryMenu");

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => new { x.CategoryId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_MenuCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuCategories_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SubscriptionExpiryDate", "SubscriptionStartDate" },
                values: new object[] { new DateTime(2020, 9, 7, 20, 33, 27, 819, DateTimeKind.Local).AddTicks(9118), new DateTime(2020, 9, 7, 19, 33, 27, 818, DateTimeKind.Local).AddTicks(6365) });

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
                    { 4, 10 },
                    { 5, 8 },
                    { 5, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategories_MenuId",
                table: "MenuCategories",
                column: "MenuId");
        }
    }
}
