using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class UsersZingersFKFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersZingers_AspNetUsers_ApplicationUserId",
                table: "UsersZingers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UsersZingers_ApplicationUserId",
                table: "UsersZingers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UsersZingers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date_of_Birth", "Display_Name", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "Middle_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "93c872c0-4bf0-486f-b69e-e1ef490eec18", 0, "e59695d8-92a2-4d61-8aa1-2ede4927a170", new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", false, "Jonny", "Five", false, null, "", null, null, "P@$$W0rd", null, false, "8f6eff09-8610-459d-88f8-5ab6188dec8c", false, "@Number5" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersZingers_AspNetUsers_Id",
                table: "UsersZingers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersZingers_AspNetUsers_Id",
                table: "UsersZingers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93c872c0-4bf0-486f-b69e-e1ef490eec18");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UsersZingers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_User = table.Column<bool>(type: "bit", nullable: false),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Display_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email_Address = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Middle_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pass_word = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    User_Handle = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_ID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "U_ID", "Admin_User", "Date_of_Birth", "Display_Name", "Email_Address", "First_Name", "Last_Name", "Middle_Name", "Pass_word", "User_Handle" },
                values: new object[] { 20, false, new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", "Jonny", "Five", "", "P@$$W0rd", "@Number5" });

            migrationBuilder.CreateIndex(
                name: "IX_UsersZingers_ApplicationUserId",
                table: "UsersZingers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_User_Handle",
                table: "Users",
                column: "User_Handle",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersZingers_AspNetUsers_ApplicationUserId",
                table: "UsersZingers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
