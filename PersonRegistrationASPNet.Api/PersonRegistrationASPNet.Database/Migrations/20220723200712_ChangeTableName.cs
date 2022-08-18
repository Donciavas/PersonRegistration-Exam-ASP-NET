using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonRegistrationASPNet.Database.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Asmenskodas",
                table: "UserInfo",
                newName: "PersonalNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonalNumber",
                table: "UserInfo",
                newName: "Asmenskodas");
        }
    }
}
