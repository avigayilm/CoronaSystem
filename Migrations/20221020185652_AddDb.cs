using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoronaSystem.Migrations
{
    public partial class AddDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstShot = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SecondShot = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThirdShot = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FourthShot = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vaccine4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NegativeDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
