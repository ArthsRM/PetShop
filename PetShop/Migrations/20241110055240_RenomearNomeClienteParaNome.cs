using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    /// <inheritdoc />
    public partial class RenomearNomeClienteParaNome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Clientes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Clientes",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Clientes",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "Clientes",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Clientes",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Clientes",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "Clientes",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clientes",
                newName: "NomeCliente");
        }
    }
}
