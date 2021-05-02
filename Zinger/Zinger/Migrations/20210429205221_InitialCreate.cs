using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Middle_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Display_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    Hashtag = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
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
                    User_Handle = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Middle_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Display_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pass_word = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email_Address = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Admin_User = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_ID);
                });

            migrationBuilder.CreateTable(
                name: "Zingers",
                columns: table => new
                {
                    Zinger_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hashtag = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Zinger_Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Date_Time_Stamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zingers", x => x.Zinger_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersZingers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersZingers", x => new { x.Id, x.Zinger_ID });
                    table.ForeignKey(
                        name: "FK_UsersZingers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersZingers_Zingers_Zinger_ID",
                        column: x => x.Zinger_ID,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zinger_Replies",
                columns: table => new
                {
                    Replying_Zinger_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zinger_ID1 = table.Column<int>(type: "int", nullable: true),
                    Replying_U_ID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Zinger_Reply_Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Date_Time_Stamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                name: "ZingersHashtags",
                columns: table => new
                {
                    Zinger_ID = table.Column<int>(type: "int", nullable: false),
                    Hashtag = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Zingers_IDZinger_ID = table.Column<int>(type: "int", nullable: true),
                    HashtagsHashtag = table.Column<string>(type: "nvarchar(400)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZingersHashtags", x => new { x.Zinger_ID, x.Hashtag });
                    table.ForeignKey(
                        name: "FK_ZingersHashtags_Hashtags_HashtagsHashtag",
                        column: x => x.HashtagsHashtag,
                        principalTable: "Hashtags",
                        principalColumn: "Hashtag",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZingersHashtags_Zingers_Zingers_IDZinger_ID",
                        column: x => x.Zingers_IDZinger_ID,
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
                        name: "FK_ZingersZinger_Replies_Zinger_Replies_Zinger_RepliesReplying_Zinger_ID",
                        column: x => x.Zinger_RepliesReplying_Zinger_ID,
                        principalTable: "Zinger_Replies",
                        principalColumn: "Replying_Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZingersZinger_Replies_Zingers_ZingersZinger_ID",
                        column: x => x.ZingersZinger_ID,
                        principalTable: "Zingers",
                        principalColumn: "Zinger_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "U_ID", "Admin_User", "Date_of_Birth", "Display_Name", "Email_Address", "First_Name", "Last_Name", "Middle_Name", "Pass_word", "User_Handle" },
                values: new object[] { 20, false, new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", "Jonny", "Five", "", "P@$$W0rd", "@Number5" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_User_Handle",
                table: "Users",
                column: "User_Handle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersZingers_ApplicationUserId",
                table: "UsersZingers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersZingers_Zinger_ID",
                table: "UsersZingers",
                column: "Zinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Zinger_Replies_UserId",
                table: "Zinger_Replies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Zinger_Replies_Zinger_ID1",
                table: "Zinger_Replies",
                column: "Zinger_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_HashtagsHashtag",
                table: "ZingersHashtags",
                column: "HashtagsHashtag");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_Zingers_IDZinger_ID",
                table: "ZingersHashtags",
                column: "Zingers_IDZinger_ID");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersZingers");

            migrationBuilder.DropTable(
                name: "ZingersHashtags");

            migrationBuilder.DropTable(
                name: "ZingersZinger_Replies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Zinger_Replies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Zingers");
        }
    }
}
