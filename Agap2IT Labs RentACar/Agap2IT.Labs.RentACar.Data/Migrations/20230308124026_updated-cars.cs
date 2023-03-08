using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agap2IT.Labs.RentACar.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedcars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BuildDate",
                table: "Cars",
                type: "datetime2(3)",
                precision: 3,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Observations",
                table: "Cars",
                type: "varchar(2000)",
                unicode: false,
                maxLength: 2000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observations",
                table: "Cars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuildDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(3)",
                oldPrecision: 3);
        }
    }
}
