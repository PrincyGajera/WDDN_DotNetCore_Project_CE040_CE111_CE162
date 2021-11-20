using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCore3.Data.Migrations
{
    public partial class Core : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rememberMe = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Branch = table.Column<string>(nullable: false),
                    Mobile = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    WDDN = table.Column<int>(nullable: false),
                    OS = table.Column<int>(nullable: false),
                    MFP = table.Column<int>(nullable: false),
                    AT = table.Column<int>(nullable: false),
                    AA = table.Column<int>(nullable: false),
                    Teacher_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
