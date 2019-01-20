using Microsoft.EntityFrameworkCore.Migrations;

namespace BTVBookRental.Migrations
{
    public partial class ByteToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AnAparitie",
                table: "Book",
                nullable: false,
                oldClrType: typeof(byte));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "AnAparitie",
                table: "Book",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
