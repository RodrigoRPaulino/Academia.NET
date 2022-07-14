using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinal_RodrigoPaulino.Migrations
{
    public partial class CreateProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas");

            migrationBuilder.RenameTable(
                name: "Lojas",
                newName: "lojas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lojas",
                table: "lojas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLoja = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_lojas_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdLoja",
                table: "Produtos",
                column: "IdLoja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lojas",
                table: "lojas");

            migrationBuilder.RenameTable(
                name: "lojas",
                newName: "Lojas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas",
                column: "Id");
        }
    }
}
