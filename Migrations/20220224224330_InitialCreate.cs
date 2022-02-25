using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWebVersion.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeskWidth = table.Column<int>(type: "int", nullable: false),
                    DeskDepth = table.Column<int>(type: "int", nullable: false),
                    NumberDrawers = table.Column<int>(type: "int", nullable: false),
                    DesktopMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RushOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
