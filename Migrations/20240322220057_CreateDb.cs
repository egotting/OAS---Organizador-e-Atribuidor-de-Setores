using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OASv1.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    NomeDoProduto = table.Column<string>(type: "TEXT", nullable: false),
                    ResponsavelPelaBuscaDoProduto = table.Column<string>(type: "TEXT", nullable: false),
                    NotaFiscal = table.Column<string>(type: "TEXT", nullable: false),
                    Validade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDeRecebimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDeAlteracao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
