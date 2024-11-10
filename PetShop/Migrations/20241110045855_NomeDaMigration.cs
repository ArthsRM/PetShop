using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomeAnimal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<int>(type: "int", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    cep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEmpregado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataAdmissao = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empregados");

            migrationBuilder.DropTable(
                name: "Servicos");
        }
    }
}
