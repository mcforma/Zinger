using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class Zinger_Replies_IDAddedToZingersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZingersZinger_Replies");

            migrationBuilder.DropTable(
                name: "Zinger_Replies");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cb197e2-70f5-4848-8379-2a5432c37ea1");

            migrationBuilder.AddColumn<int>(
                name: "Replying_Zinger_ID",
                table: "Zingers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date_of_Birth", "Display_Name", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "Middle_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "13ab1180-6043-4dc7-9c52-a405cea3aad6", 0, "ea5dc29e-327c-4c91-8f99-23d4f81e5175", new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", false, "Jonny", "Five", false, null, "", null, null, "P@$$W0rd", null, false, "44f19d8a-92d1-4351-ae1a-7abd3cc555ea", false, "@Number5" });

            migrationBuilder.CreateIndex(
                name: "IX_Zingers_Replying_Zinger_ID",
                table: "Zingers",
                column: "Replying_Zinger_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Zingers_Zingers_Replying_Zinger_ID",
                table: "Zingers",
                column: "Replying_Zinger_ID",
                principalTable: "Zingers",
                principalColumn: "Zinger_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zingers_Zingers_Replying_Zinger_ID",
                table: "Zingers");

            migrationBuilder.DropIndex(
                name: "IX_Zingers_Replying_Zinger_ID",
                table: "Zingers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13ab1180-6043-4dc7-9c52-a405cea3aad6");

            migrationBuilder.DropColumn(
                name: "Replying_Zinger_ID",
                table: "Zingers");

            migrationBuilder.CreateTable(
                name: "Zinger_Replies",
                columns: table => new
                {
                    Replying_Zinger_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time_Stamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Replying_U_ID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zinger_ID1 = table.Column<int>(type: "int", nullable: true),
                    Zinger_Reply_Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zinger_Replies", x => x.Replying_Zinger_ID);
                    table.ForeignKey(
                        name: "FK_Zinger_Replies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zinger_Replies_Zingers_Zinger_ID1",
                        column: x => x.Zinger_ID1,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZingersZinger_Replies",
                columns: table => new
                {
                    Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    Replying_Zinger_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZingersZinger_Replies", x => new { x.Zinger_ID, x.Replying_Zinger_ID });
                    table.ForeignKey(
                        name: "FK_ZingersZinger_Replies_Zinger_Replies_Replying_Zinger_ID",
                        column: x => x.Replying_Zinger_ID,
                        principalTable: "Zinger_Replies",
                        principalColumn: "Replying_Zinger_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZingersZinger_Replies_Zingers_Zinger_ID",
                        column: x => x.Zinger_ID,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date_of_Birth", "Display_Name", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "Middle_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0cb197e2-70f5-4848-8379-2a5432c37ea1", 0, "0193e801-a78f-4d93-8b0e-f39c8d481f56", new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", false, "Jonny", "Five", false, null, "", null, null, "P@$$W0rd", null, false, "1196902e-d421-40c4-9654-ea30e94e1c3c", false, "@Number5" });

            migrationBuilder.CreateIndex(
                name: "IX_Zinger_Replies_UserId",
                table: "Zinger_Replies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Zinger_Replies_Zinger_ID1",
                table: "Zinger_Replies",
                column: "Zinger_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersZinger_Replies_Replying_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Replying_Zinger_ID");
        }
    }
}
