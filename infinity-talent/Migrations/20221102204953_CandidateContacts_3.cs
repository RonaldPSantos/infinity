using Microsoft.EntityFrameworkCore.Migrations;

namespace infinity_talent.Migrations
{
    public partial class CandidateContacts_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidatesContacts_Candidates_CandidateId",
                table: "CandidatesContacts");

            migrationBuilder.DropIndex(
                name: "IX_CandidatesContacts_CandidateId",
                table: "CandidatesContacts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CandidatesContacts_CandidateId",
                table: "CandidatesContacts",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidatesContacts_Candidates_CandidateId",
                table: "CandidatesContacts",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
