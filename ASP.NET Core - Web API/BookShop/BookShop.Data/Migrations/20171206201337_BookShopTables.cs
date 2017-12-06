using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookShop.Data.Migrations
{
    public partial class BookShopTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCayegories_Books_BookId",
                table: "BooksInCayegories");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCayegories_Categories_CategoryId",
                table: "BooksInCayegories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksInCayegories",
                table: "BooksInCayegories");

            migrationBuilder.RenameTable(
                name: "BooksInCayegories",
                newName: "BooksInCategories");

            migrationBuilder.RenameIndex(
                name: "IX_BooksInCayegories_CategoryId",
                table: "BooksInCategories",
                newName: "IX_BooksInCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksInCategories",
                table: "BooksInCategories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCategories_Books_BookId",
                table: "BooksInCategories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCategories_Categories_CategoryId",
                table: "BooksInCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCategories_Books_BookId",
                table: "BooksInCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksInCategories_Categories_CategoryId",
                table: "BooksInCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksInCategories",
                table: "BooksInCategories");

            migrationBuilder.RenameTable(
                name: "BooksInCategories",
                newName: "BooksInCayegories");

            migrationBuilder.RenameIndex(
                name: "IX_BooksInCategories_CategoryId",
                table: "BooksInCayegories",
                newName: "IX_BooksInCayegories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksInCayegories",
                table: "BooksInCayegories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCayegories_Books_BookId",
                table: "BooksInCayegories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInCayegories_Categories_CategoryId",
                table: "BooksInCayegories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
