using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LidellBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fighters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FighterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FighterReach = table.Column<int>(type: "int", nullable: false),
                    HomeTown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FightStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Record = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ranking = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fighters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fighters");
        }
    }
}
