using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace API.Migrations
{
    public partial class SegundaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Filmes");

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Filmes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_GeneroId",
                table: "Filmes",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmes_Generos_GeneroId",
                table: "Filmes",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmes_Generos_GeneroId",
                table: "Filmes");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Filmes_GeneroId",
                table: "Filmes");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Filmes");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Filmes",
                type: "text",
                nullable: false);
        }
    }
}
