﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ebook_cw.Migrations
{
    public partial class AddOrderIdToFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_OrderId",
                table: "Feedbacks",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Orders_OrderId",
                table: "Feedbacks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Orders_OrderId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_OrderId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Feedbacks");
        }
    }
}
