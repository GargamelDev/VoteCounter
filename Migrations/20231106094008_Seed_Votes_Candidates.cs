using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoutesCounter.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Votes_Candidates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Candidates (Name) values ('Wojciech Jedliński')");
            migrationBuilder.Sql("INSERT INTO Candidates (Name) values ('Jan Kowalski')");
            migrationBuilder.Sql("INSERT INTO Candidates (Name) values ('Jarosław SamWieszKto')");

            migrationBuilder.Sql(
                @"INSERT INTO Votes (CandidateId, VoterId) SELECT 
                    ( SELECT TOP 1 c.Id FROM Candidates c WHERE c.Name = 'Wojciech Jedliński') as CandidateID, 
                    (SELECT TOP 1 v.Id FROM Voters v WHERE v.Name = 'Kacper Hofman') as VoterID");

            migrationBuilder.Sql(
                @"INSERT INTO Votes (CandidateId, VoterId) SELECT 
                    ( SELECT TOP 1 c.Id FROM Candidates c WHERE c.Name = 'Wojciech Jedliński') as CandidateID, 
                    (SELECT TOP 1 v.Id FROM Voters v WHERE v.Name = 'Emilia Pietrzak-Kosiewicz') as VoterID");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Candidates");
            migrationBuilder.Sql("DELETE FROM Votes");
        }
    }
}
