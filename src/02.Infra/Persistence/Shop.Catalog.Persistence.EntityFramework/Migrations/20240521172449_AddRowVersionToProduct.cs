using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Catalog.Persistence.EntityFramework.Migrations
{
    public partial class AddRowVersionToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "catalog",
                table: "ParentCategory",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                schema: "catalog",
                table: "Category",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                schema: "catalog",
                table: "ParentCategory");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                schema: "catalog",
                table: "Category");
        }
    }
}
