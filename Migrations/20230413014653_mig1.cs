using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbAdmin",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Confirm_Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAdmin", x => x.Admin_Id);
                });

            migrationBuilder.CreateTable(
                name: "TbFeedback",
                columns: table => new
                {
                    Feedback_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateRecorded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbFeedback", x => x.Feedback_Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPlaces",
                columns: table => new
                {
                    Place_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Place_Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ZIP_Code = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPlaces", x => x.Place_Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPromocode",
                columns: table => new
                {
                    promocode_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPromocode", x => x.promocode_Id);
                });

            migrationBuilder.CreateTable(
                name: "TbUsers",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Confirm_Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsers", x => x.User_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbAdmin");

            migrationBuilder.DropTable(
                name: "TbFeedback");

            migrationBuilder.DropTable(
                name: "TbPlaces");

            migrationBuilder.DropTable(
                name: "TbPromocode");

            migrationBuilder.DropTable(
                name: "TbUsers");
        }
    }
}
