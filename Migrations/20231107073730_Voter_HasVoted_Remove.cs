using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoutesCounter.Migrations
{
    /// <inheritdoc />
    public partial class Voter_HasVoted_Remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasVoted",
                table: "Voters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasVoted",
                table: "Voters",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
