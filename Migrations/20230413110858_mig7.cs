using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "TbPromocode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "TbFeedback",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbPromocode_User_Id",
                table: "TbPromocode",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TbFeedback_User_Id",
                table: "TbFeedback",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbFeedback_TbUsers_User_Id",
                table: "TbFeedback",
                column: "User_Id",
                principalTable: "TbUsers",
                principalColumn: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbPromocode_TbUsers_User_Id",
                table: "TbPromocode",
                column: "User_Id",
                principalTable: "TbUsers",
                principalColumn: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbFeedback_TbUsers_User_Id",
                table: "TbFeedback");

            migrationBuilder.DropForeignKey(
                name: "FK_TbPromocode_TbUsers_User_Id",
                table: "TbPromocode");

            migrationBuilder.DropIndex(
                name: "IX_TbPromocode_User_Id",
                table: "TbPromocode");

            migrationBuilder.DropIndex(
                name: "IX_TbFeedback_User_Id",
                table: "TbFeedback");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "TbPromocode");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "TbFeedback");
        }
    }
}
