using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OASv1.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableValidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "Produtos",
                newName: "ValidadeDoProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValidadeDoProduto",
                table: "Produtos",
                newName: "Validade");
        }
    }
}
