using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class IdentityLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date_of_Birth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Display_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Middle_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Handle",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "U_ID", "Admin_User", "Date_of_Birth", "Display_Name", "Email_Address", "First_Name", "Last_Name", "Middle_Name", "Pass_word", "User_Handle" },
                values: new object[] { 20, false, new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", "Jonny", "Five", "", "P@$$W0rd", "@Number5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "U_ID",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Date_of_Birth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Display_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Middle_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "User_Handle",
                table: "AspNetUsers");
        }
    }
}
