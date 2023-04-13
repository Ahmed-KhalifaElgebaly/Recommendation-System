using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbUserSearchPlace",
                columns: table => new
                {
                    User_Search_Place_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Place_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUserSearchPlace", x => x.User_Search_Place_Id);
                    table.ForeignKey(
                        name: "FK_TbUserSearchPlace_TbPlaces_Place_Id",
                        column: x => x.Place_Id,
                        principalTable: "TbPlaces",
                        principalColumn: "Place_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbUserSearchPlace_TbUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "TbUsers",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSearchPlace_Place_Id",
                table: "TbUserSearchPlace",
                column: "Place_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSearchPlace_User_Id",
                table: "TbUserSearchPlace",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbUserSearchPlace");
        }
    }
}
