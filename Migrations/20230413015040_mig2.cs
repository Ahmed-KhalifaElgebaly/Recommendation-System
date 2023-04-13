using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Admin_Id",
                table: "TbPlaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbPlaces_Admin_Id",
                table: "TbPlaces",
                column: "Admin_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbPlaces_TbAdmin_Admin_Id",
                table: "TbPlaces",
                column: "Admin_Id",
                principalTable: "TbAdmin",
                principalColumn: "Admin_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbPlaces_TbAdmin_Admin_Id",
                table: "TbPlaces");

            migrationBuilder.DropIndex(
                name: "IX_TbPlaces_Admin_Id",
                table: "TbPlaces");

            migrationBuilder.DropColumn(
                name: "Admin_Id",
                table: "TbPlaces");
        }
    }
}
