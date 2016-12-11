using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppsPortal_Admin_dotNetCore.Migrations
{
    public partial class UpdateBannerToSlides : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buttons_Banners_BannerId",
                table: "Buttons");

            migrationBuilder.DropIndex(
                name: "IX_Buttons_BannerId",
                table: "Buttons");

            migrationBuilder.DropColumn(
                name: "BannerId",
                table: "Buttons");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "SlidesId",
                table: "Buttons",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Apps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Apps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Buttons_SlidesId",
                table: "Buttons",
                column: "SlidesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buttons_Slides_SlidesId",
                table: "Buttons",
                column: "SlidesId",
                principalTable: "Slides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buttons_Slides_SlidesId",
                table: "Buttons");

            migrationBuilder.DropIndex(
                name: "IX_Buttons_SlidesId",
                table: "Buttons");

            migrationBuilder.DropColumn(
                name: "SlidesId",
                table: "Buttons");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Apps");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Apps");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Context = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "BannerId",
                table: "Buttons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buttons_BannerId",
                table: "Buttons",
                column: "BannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buttons_Banners_BannerId",
                table: "Buttons",
                column: "BannerId",
                principalTable: "Banners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
