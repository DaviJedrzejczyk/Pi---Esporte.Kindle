using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RG = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unidade_Federal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FORNECEDORES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    Nome_Contato = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORNECEDORES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOGINS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGINS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoFuncionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelAcesso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoFuncionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CEP = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    PontoReferencia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ENDERECO_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RG = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Nivel_AcessoId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOS_ENDERECO_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOS_TipoFuncionario_Nivel_AcessoId",
                        column: x => x.Nivel_AcessoId,
                        principalTable: "TipoFuncionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECO_EstadoId",
                table: "ENDERECO",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOS_EnderecoId",
                table: "FUNCIONARIOS",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOS_Nivel_AcessoId",
                table: "FUNCIONARIOS",
                column: "Nivel_AcessoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "FORNECEDORES");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "LOGINS");

            migrationBuilder.DropTable(
                name: "ENDERECO");

            migrationBuilder.DropTable(
                name: "TipoFuncionario");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
