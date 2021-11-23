using Microsoft.EntityFrameworkCore.Migrations;

namespace PNT1_CartaRestoBar_RubinManchinelli.Migrations
{
    public partial class PNT1_CartaRestoBar_RubinManchinelliContextPedidoDataBaseContext3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomPedido",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCliente",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomPedido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "NombreCliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Pedidos");
        }
    }
}
