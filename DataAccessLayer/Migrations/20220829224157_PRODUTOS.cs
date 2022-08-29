using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class PRODUTOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FORNECEDORES_ID = table.Column<int>(type: "int", nullable: false),
                    QTD_ESTOQUE = table.Column<int>(type: "int", nullable: false),
                    VALOR_UNITARIO = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_FORNECEDORES_FORNECEDORES_ID",
                        column: x => x.FORNECEDORES_ID,
                        principalTable: "FORNECEDORES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_FORNECEDORES_ID",
                table: "PRODUTOS",
                column: "FORNECEDORES_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTOS");
        }
    }
}
