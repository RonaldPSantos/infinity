using Microsoft.EntityFrameworkCore.Migrations;

namespace infinity_talent.Migrations
{
    public partial class reenviando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_candidate",
                table: "candidate");

            migrationBuilder.RenameTable(
                name: "candidate",
                newName: "Candidates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates");

            migrationBuilder.RenameTable(
                name: "Candidates",
                newName: "candidate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_candidate",
                table: "candidate",
                column: "Id");
        }
    }
}
