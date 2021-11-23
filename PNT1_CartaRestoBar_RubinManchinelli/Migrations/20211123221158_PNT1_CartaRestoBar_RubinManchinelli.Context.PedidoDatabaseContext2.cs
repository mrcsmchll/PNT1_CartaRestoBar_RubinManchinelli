using Microsoft.EntityFrameworkCore.Migrations;

namespace PNT1_CartaRestoBar_RubinManchinelli.Migrations
{
    public partial class PNT1_CartaRestoBar_RubinManchinelliContextPedidoDatabaseContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumTelefono",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPago",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "NumTelefono",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                table: "Cliente");
        }
    }
}
