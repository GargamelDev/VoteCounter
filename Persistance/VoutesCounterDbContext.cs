
using Microsoft.EntityFrameworkCore;
using VoutesCounter.Models;

namespace VoutesCounter.Persistance;

public class VoutesCounterDbContext : DbContext
{
    public DbSet<Voter> Voters { get; set; }
    public DbSet<Vote> Votes { get; set; }
    public DbSet<Candidate> Candidates { get; set; }
    public VoutesCounterDbContext(DbContextOptions<VoutesCounterDbContext> options) : base(options)
    {

    }
}

