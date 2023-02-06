using Microsoft.EntityFrameworkCore.Migrations;

namespace infinity_talent.Migrations
{
    public partial class CandidateContacts_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateContacts_Candidates_CandidateId",
                table: "CandidateContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateContacts",
                table: "CandidateContacts");

            migrationBuilder.RenameTable(
                name: "CandidateContacts",
                newName: "CandidatesContacts");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateContacts_CandidateId",
                table: "CandidatesContacts",
                newName: "IX_CandidatesContacts_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidatesContacts",
                table: "CandidatesContacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidatesContacts_Candidates_CandidateId",
                table: "CandidatesContacts",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidatesContacts_Candidates_CandidateId",
                table: "CandidatesContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidatesContacts",
                table: "CandidatesContacts");

            migrationBuilder.RenameTable(
                name: "CandidatesContacts",
                newName: "CandidateContacts");

            migrationBuilder.RenameIndex(
                name: "IX_CandidatesContacts_CandidateId",
                table: "CandidateContacts",
                newName: "IX_CandidateContacts_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateContacts",
                table: "CandidateContacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateContacts_Candidates_CandidateId",
                table: "CandidateContacts",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
