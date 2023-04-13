using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Place_Id",
                table: "TbFeedback",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbFeedback_Place_Id",
                table: "TbFeedback",
                column: "Place_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbFeedback_TbPlaces_Place_Id",
                table: "TbFeedback",
                column: "Place_Id",
                principalTable: "TbPlaces",
                principalColumn: "Place_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbFeedback_TbPlaces_Place_Id",
                table: "TbFeedback");

            migrationBuilder.DropIndex(
                name: "IX_TbFeedback_Place_Id",
                table: "TbFeedback");

            migrationBuilder.DropColumn(
                name: "Place_Id",
                table: "TbFeedback");
        }
    }
}
