using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zinger.Migrations
{
    public partial class ZingerHashtagsAndZingersZinger_RepliesFKFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZingersHashtags_Hashtags_HashtagsHashtag",
                table: "ZingersHashtags");

            migrationBuilder.DropForeignKey(
                name: "FK_ZingersHashtags_Zingers_Zingers_IDZinger_ID",
                table: "ZingersHashtags");

            migrationBuilder.DropForeignKey(
                name: "FK_ZingersZinger_Replies_Zinger_Replies_Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_ZingersZinger_Replies_Zingers_ZingersZinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropIndex(
                name: "IX_ZingersZinger_Replies_Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropIndex(
                name: "IX_ZingersZinger_Replies_ZingersZinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropIndex(
                name: "IX_ZingersHashtags_HashtagsHashtag",
                table: "ZingersHashtags");

            migrationBuilder.DropIndex(
                name: "IX_ZingersHashtags_Zingers_IDZinger_ID",
                table: "ZingersHashtags");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93c872c0-4bf0-486f-b69e-e1ef490eec18");

            migrationBuilder.DropColumn(
                name: "Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropColumn(
                name: "ZingersZinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropColumn(
                name: "HashtagsHashtag",
                table: "ZingersHashtags");

            migrationBuilder.DropColumn(
                name: "Zingers_IDZinger_ID",
                table: "ZingersHashtags");

            migrationBuilder.DropColumn(
                name: "Zinger_ID",
                table: "Hashtags");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date_of_Birth", "Display_Name", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "Middle_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0cb197e2-70f5-4848-8379-2a5432c37ea1", 0, "0193e801-a78f-4d93-8b0e-f39c8d481f56", new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", false, "Jonny", "Five", false, null, "", null, null, "P@$$W0rd", null, false, "1196902e-d421-40c4-9654-ea30e94e1c3c", false, "@Number5" });

            migrationBuilder.CreateIndex(
                name: "IX_ZingersZinger_Replies_Replying_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Replying_Zinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_Hashtag",
                table: "ZingersHashtags",
                column: "Hashtag");

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersHashtags_Hashtags_Hashtag",
                table: "ZingersHashtags",
                column: "Hashtag",
                principalTable: "Hashtags",
                principalColumn: "Hashtag",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersHashtags_Zingers_Zinger_ID",
                table: "ZingersHashtags",
                column: "Zinger_ID",
                principalTable: "Zingers",
                principalColumn: "Zinger_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersZinger_Replies_Zinger_Replies_Replying_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Replying_Zinger_ID",
                principalTable: "Zinger_Replies",
                principalColumn: "Replying_Zinger_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersZinger_Replies_Zingers_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Zinger_ID",
                principalTable: "Zingers",
                principalColumn: "Zinger_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZingersHashtags_Hashtags_Hashtag",
                table: "ZingersHashtags");

            migrationBuilder.DropForeignKey(
                name: "FK_ZingersHashtags_Zingers_Zinger_ID",
                table: "ZingersHashtags");

            migrationBuilder.DropForeignKey(
                name: "FK_ZingersZinger_Replies_Zinger_Replies_Replying_Zinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_ZingersZinger_Replies_Zingers_Zinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropIndex(
                name: "IX_ZingersZinger_Replies_Replying_Zinger_ID",
                table: "ZingersZinger_Replies");

            migrationBuilder.DropIndex(
                name: "IX_ZingersHashtags_Hashtag",
                table: "ZingersHashtags");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cb197e2-70f5-4848-8379-2a5432c37ea1");

            migrationBuilder.AddColumn<int>(
                name: "Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZingersZinger_ID",
                table: "ZingersZinger_Replies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HashtagsHashtag",
                table: "ZingersHashtags",
                type: "nvarchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Zingers_IDZinger_ID",
                table: "ZingersHashtags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Zinger_ID",
                table: "Hashtags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date_of_Birth", "Display_Name", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "Middle_Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "93c872c0-4bf0-486f-b69e-e1ef490eec18", 0, "e59695d8-92a2-4d61-8aa1-2ede4927a170", new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonny5", "jonny5@number5.com", false, "Jonny", "Five", false, null, "", null, null, "P@$$W0rd", null, false, "8f6eff09-8610-459d-88f8-5ab6188dec8c", false, "@Number5" });

            migrationBuilder.CreateIndex(
                name: "IX_ZingersZinger_Replies_Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Zinger_RepliesReplying_Zinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersZinger_Replies_ZingersZinger_ID",
                table: "ZingersZinger_Replies",
                column: "ZingersZinger_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_HashtagsHashtag",
                table: "ZingersHashtags",
                column: "HashtagsHashtag");

            migrationBuilder.CreateIndex(
                name: "IX_ZingersHashtags_Zingers_IDZinger_ID",
                table: "ZingersHashtags",
                column: "Zingers_IDZinger_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersHashtags_Hashtags_HashtagsHashtag",
                table: "ZingersHashtags",
                column: "HashtagsHashtag",
                principalTable: "Hashtags",
                principalColumn: "Hashtag",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersHashtags_Zingers_Zingers_IDZinger_ID",
                table: "ZingersHashtags",
                column: "Zingers_IDZinger_ID",
                principalTable: "Zingers",
                principalColumn: "Zinger_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersZinger_Replies_Zinger_Replies_Zinger_RepliesReplying_Zinger_ID",
                table: "ZingersZinger_Replies",
                column: "Zinger_RepliesReplying_Zinger_ID",
                principalTable: "Zinger_Replies",
                principalColumn: "Replying_Zinger_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZingersZinger_Replies_Zingers_ZingersZinger_ID",
                table: "ZingersZinger_Replies",
                column: "ZingersZinger_ID",
                principalTable: "Zingers",
                principalColumn: "Zinger_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
