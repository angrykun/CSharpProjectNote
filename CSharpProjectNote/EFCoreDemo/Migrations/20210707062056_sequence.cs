using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo.Migrations
{
    public partial class sequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "shared");

            migrationBuilder.CreateSequence<int>(
                name: "OrderNumbers",
                schema: "shared",
                startValue: 1000L,
                incrementBy: 5);

            migrationBuilder.AddColumn<int>(
                name: "OrderNumbers",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "OrderNumbers",
                schema: "shared");

            migrationBuilder.DropColumn(
                name: "OrderNumbers",
                table: "Orders");
        }
    }
}
