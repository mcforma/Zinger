using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class addManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    Hashtag = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    Zinger_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtags", x => x.Hashtag);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Handle = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    First_Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Middle_Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Display_Name = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pass_word = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    Admin_User = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_ID);
                });

            migrationBuilder.CreateTable(
                name: "Zinger_Replies",
                columns: table => new
                {
                    Replying_Zinger_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Replying_U_ID = table.Column<int>(type: "int", nullable: false),
                    Zinger_Reply_Content = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Date_Time_Stamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zinger_Replies", x => x.Replying_Zinger_ID);
                });

            migrationBuilder.CreateTable(
                name: "Zingers",
                columns: table => new
                {
                    Zinger_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hashtag = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Zinger_Content = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Date_Time_Stamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zingers", x => x.Zinger_ID);
                });

            migrationBuilder.CreateTable(
                name: "UsersZingers",
                columns: table => new
                {
                    U_ID = table.Column<int>(type: "int", nullable: false),
                    Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    UsersU_ID = table.Column<int>(type: "int", nullable: true),
                    ZingersZinger_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersZingers", x => new { x.U_ID, x.Zinger_ID });
                    table.ForeignKey(
                        name: "FK_UsersZingers_Users",
                        column: x => x.UsersU_ID,
                        principalTable: "Users",
                        principalColumn: "U_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersZingers_Zingers",
                        column: x => x.ZingersZinger_ID,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZingersHashtags",
                columns: table => new
                {
                    Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    Hashtag = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    ZingersZinger_ID = table.Column<int>(type: "int", nullable: true),
                    HashtagsHashtag = table.Column<string>(type: "nvarchar(400)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZingersHashtags", x => new { x.Zinger_ID, x.Hashtag });
                    table.ForeignKey(
                        name: "FK_ZingersHashtags_Hashtags",
                        column: x => x.HashtagsHashtag,
                        principalTable: "Hashtags",
                        principalColumn: "Hashtag",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZingersHashtags_Zingers",
                        column: x => x.ZingersZinger_ID,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZingersZinger_Replies",
                columns: table => new
                {
                    Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    Replying_Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    ZingersZinger_ID = table.Column<int>(type: "int", nullable: true),
                    Zinger_RepliesReplying_Zinger_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZingersZinger_Replies", x => new { x.Zinger_ID, x.Replying_Zinger_ID });
                    table.ForeignKey(
                        name: "FK_ZingersZinger_Replies-Zinger_Replies",
                        column: x => x.Zinger_RepliesReplying_Zinger_ID,
                        principalTable: "Zinger_Replies",
                        principalColumn: "Replying_Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZingersZinger_Replies-Zingers",
                        column: x => x.ZingersZinger_ID,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersZingers_UsersU_ID",
                table: "UsersZingers",
                column: "UsersU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersZingers_ZingersZinger_ID",
                table: "UsersZingers",
                column: "ZingersZinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_HashtagsHashtag",
                table: "ZingersHashtags",
                column: "HashtagsHashtag");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_ZingersZinger_ID",
                table: "ZingersHashtags",
                column: "ZingersZinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersZinger_Replies_Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Zinger_RepliesReplying_Zinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersZinger_Replies_ZingersZinger_ID",
                table: "ZingersZinger_Replies",
                column: "ZingersZinger_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersZingers");

            migrationBuilder.DropTable(
                name: "ZingersHashtags");

            migrationBuilder.DropTable(
                name: "ZingersZinger_Replies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Zinger_Replies");

            migrationBuilder.DropTable(
                name: "Zingers");
        }
    }
}
