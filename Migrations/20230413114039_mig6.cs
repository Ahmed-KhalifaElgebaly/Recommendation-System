using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbUserRating",
                columns: table => new
                {
                    User_Rating_Place_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Place_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUserRating", x => x.User_Rating_Place_Id);
                    table.ForeignKey(
                        name: "FK_TbUserRating_TbPlaces_Place_Id",
                        column: x => x.Place_Id,
                        principalTable: "TbPlaces",
                        principalColumn: "Place_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbUserRating_TbUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "TbUsers",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbUserRating_Place_Id",
                table: "TbUserRating",
                column: "Place_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserRating_User_Id",
                table: "TbUserRating",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbUserRating");
        }
    }
}
