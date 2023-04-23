using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFood",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(16)", unicode: true, maxLength: 16, nullable: true),
                    category = table.Column<string>(type: "nvarchar(32)", unicode: true, maxLength: 32, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", unicode: true, nullable: true),
                    country_of_origin = table.Column<string>(type: "nvarchar(32)", unicode: true, maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Favorite__3213E83F78BE5829", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(16)", unicode: true, maxLength: 16, nullable: true),
                    category = table.Column<string>(type: "nvarchar(16)", unicode: true, maxLength: 16, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", unicode: true, nullable: true),
                    difficulty = table.Column<string>(type: "nvarchar(16)", unicode: true, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hobby__3213E83FDED86595", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MemberInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "varchar(16)", unicode: true, maxLength: 16, nullable: true),
                    last_name = table.Column<string>(type: "varchar(16)", unicode: true, maxLength: 16, nullable: true),
                    birthdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    college_program = table.Column<string>(type: "varchar(16)", unicode: true, maxLength: 16, nullable: true),
                    year = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    hobby_id = table.Column<int>(type: "int", nullable: true),
                    pet_id = table.Column<int>(type: "int", nullable: true),
                    favorite_food_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MemberIn__3213E83FDCEB11A7", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MemberPets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(16)", unicode: true, maxLength: 16, nullable: true),
                    type = table.Column<string>(type: "varchar(16)", unicode: true, maxLength: 16, nullable: true),
                    gender = table.Column<string>(type: "varchar(8)", unicode: true, maxLength: 8, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MemberPe__3213E83F19ED9B2B", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFood");

            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "MemberInfo");

            migrationBuilder.DropTable(
                name: "MemberPets");
        }
    }
}
