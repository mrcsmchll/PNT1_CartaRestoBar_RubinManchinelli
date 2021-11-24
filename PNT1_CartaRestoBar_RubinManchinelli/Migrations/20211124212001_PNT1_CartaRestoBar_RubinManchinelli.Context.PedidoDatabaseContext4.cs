using Microsoft.EntityFrameworkCore.Migrations;

namespace PNT1_CartaRestoBar_RubinManchinelli.Migrations
{
    public partial class PNT1_CartaRestoBar_RubinManchinelliContextPedidoDatabaseContext4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Cliente_ClienteId",
                table: "Pedidos");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCliente",
                table: "Pedidos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomPedido",
                table: "Pedidos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Pedidos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlatoId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPlatos",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Plato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<double>(nullable: false),
                    esAptoCeliaco = table.Column<bool>(nullable: false),
                    esAptoVegano = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plato", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PlatoId",
                table: "Pedidos",
                column: "PlatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Cliente_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Plato_PlatoId",
                table: "Pedidos",
                column: "PlatoId",
                principalTable: "Plato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Cliente_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Plato_PlatoId",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "Plato");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_PlatoId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PlatoId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "TipoPlatos",
                table: "Pedidos");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCliente",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomPedido",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Cliente_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
