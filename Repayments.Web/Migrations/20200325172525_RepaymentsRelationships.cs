using Microsoft.EntityFrameworkCore.Migrations;

namespace Repayments.Web.Migrations
{
    public partial class RepaymentsRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Repayments_CustomerId",
                table: "Repayments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Repayments_SeasonId",
                table: "Repayments",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Repayments_Customers_CustomerId",
                table: "Repayments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repayments_Seasons_SeasonId",
                table: "Repayments",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repayments_Customers_CustomerId",
                table: "Repayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Repayments_Seasons_SeasonId",
                table: "Repayments");

            migrationBuilder.DropIndex(
                name: "IX_Repayments_CustomerId",
                table: "Repayments");

            migrationBuilder.DropIndex(
                name: "IX_Repayments_SeasonId",
                table: "Repayments");
        }
    }
}
