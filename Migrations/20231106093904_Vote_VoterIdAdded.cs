using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoutesCounter.Migrations
{
    /// <inheritdoc />
    public partial class Vote_VoterIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Votes_VoterId",
                table: "Votes");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Votes_VoterId",
                table: "Votes");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId");
        }
    }
}
