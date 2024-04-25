using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class preFinalDbReady : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_BannerId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_BannerId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupMembers_Users_BannerId",
                table: "GroupMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_BannerId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_BannerId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_BannerId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_BannerId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_BannerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BannerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Posts_BannerId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Messages_BannerId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Likes_BannerId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Groups_BannerId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_GroupMembers_BannerId",
                table: "GroupMembers");

            migrationBuilder.DropIndex(
                name: "IX_Friends_BannerId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BannerId",
                table: "Comments");
            /*
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "GroupMembers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Comments");*/

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CommentId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserId",
                table: "Friends",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_UserId",
                table: "Friends",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_UserId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Messages");

            /*migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            */
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CommentId",
                table: "Likes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
            /*
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Likes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "GroupMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            */
            migrationBuilder.CreateIndex(
                name: "IX_Users_BannerId",
                table: "Users",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BannerId",
                table: "Posts",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_BannerId",
                table: "Messages",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_BannerId",
                table: "Likes",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_BannerId",
                table: "Groups",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_BannerId",
                table: "GroupMembers",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_BannerId",
                table: "Friends",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BannerId",
                table: "Comments",
                column: "BannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_BannerId",
                table: "Comments",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_BannerId",
                table: "Friends",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupMembers_Users_BannerId",
                table: "GroupMembers",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_BannerId",
                table: "Groups",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_BannerId",
                table: "Likes",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_BannerId",
                table: "Messages",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_BannerId",
                table: "Posts",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_BannerId",
                table: "Users",
                column: "BannerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
