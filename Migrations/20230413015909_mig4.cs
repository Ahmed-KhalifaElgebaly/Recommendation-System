using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Admin_Id",
                table: "TbUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbUsers_Admin_Id",
                table: "TbUsers",
                column: "Admin_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbUsers_TbAdmin_Admin_Id",
                table: "TbUsers",
                column: "Admin_Id",
                principalTable: "TbAdmin",
                principalColumn: "Admin_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbUsers_TbAdmin_Admin_Id",
                table: "TbUsers");

            migrationBuilder.DropIndex(
                name: "IX_TbUsers_Admin_Id",
                table: "TbUsers");

            migrationBuilder.DropColumn(
                name: "Admin_Id",
                table: "TbUsers");
        }
    }
}
