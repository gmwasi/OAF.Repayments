using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repayments.Web.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Repayments",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSummaries_CustomerId",
                table: "CustomerSummaries",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSummaries_SeasonId",
                table: "CustomerSummaries",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSummaries_Customers_CustomerId",
                table: "CustomerSummaries",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSummaries_Seasons_SeasonId",
                table: "CustomerSummaries",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSummaries_Customers_CustomerId",
                table: "CustomerSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSummaries_Seasons_SeasonId",
                table: "CustomerSummaries");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSummaries_CustomerId",
                table: "CustomerSummaries");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSummaries_SeasonId",
                table: "CustomerSummaries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Repayments",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
