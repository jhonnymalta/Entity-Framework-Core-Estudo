using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_001.Migrations
{
    public partial class changeTableArtigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Categorias_Categoria_ID",
                table: "Artigos");

            migrationBuilder.DropIndex(
                name: "IX_Artigos_Categoria_ID",
                table: "Artigos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Artigos_Categoria_ID",
                table: "Artigos",
                column: "Categoria_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Categorias_Categoria_ID",
                table: "Artigos",
                column: "Categoria_ID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
