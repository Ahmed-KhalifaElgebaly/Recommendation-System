using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Admin_Id",
                table: "TbPromocode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbPromocode_Admin_Id",
                table: "TbPromocode",
                column: "Admin_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbPromocode_TbAdmin_Admin_Id",
                table: "TbPromocode",
                column: "Admin_Id",
                principalTable: "TbAdmin",
                principalColumn: "Admin_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbPromocode_TbAdmin_Admin_Id",
                table: "TbPromocode");

            migrationBuilder.DropIndex(
                name: "IX_TbPromocode_Admin_Id",
                table: "TbPromocode");

            migrationBuilder.DropColumn(
                name: "Admin_Id",
                table: "TbPromocode");
        }
    }
}
