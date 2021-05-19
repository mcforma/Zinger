using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class ChangeZingerFKToAppUserToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zingers_AspNetUsers_ApplicationUserId",
                table: "Zingers");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Zingers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Zingers_AspNetUsers_ApplicationUserId",
                table: "Zingers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zingers_AspNetUsers_ApplicationUserId",
                table: "Zingers");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Zingers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Zingers_AspNetUsers_ApplicationUserId",
                table: "Zingers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
