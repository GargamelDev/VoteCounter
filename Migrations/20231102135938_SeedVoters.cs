using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoutesCounter.Migrations
{
    /// <inheritdoc />
    public partial class SeedVoters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Voters (Name, HasVoted) VALUES ('Emilia Pietrzak-Kosiewicz', 1)");
            migrationBuilder.Sql("INSERT INTO Voters (Name, HasVoted) VALUES ('Piotr Kowalski', 0)");
            migrationBuilder.Sql("INSERT INTO Voters (Name, HasVoted) VALUES ('Kacper Hofman', 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Voters");
        }
    }
}
