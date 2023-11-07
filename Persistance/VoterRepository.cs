using Microsoft.EntityFrameworkCore;
using VoutesCounter.Core;
using VoutesCounter.Models;

namespace VoutesCounter.Persistance;



public class VoterRepository : IVoterRepository
{
    private readonly VoutesCounterDbContext context;
    public VoterRepository(VoutesCounterDbContext context)
    {
        this.context = context;
    }

    public async Task<Voter> GetVoter(int id, bool includeRelated = true)
    {
        if (!includeRelated)
            return await this.context.Voters.FindAsync(id);
        return await this.context.Voters.Include(x => x.Vote).SingleOrDefaultAsync(x => x.Id == id);

        // await context.Voters.Include(x => x.Vote).ToListAsync();
    }

    public async Task<IEnumerable<Voter>> GetVoters(bool includeRelated = true)
    {
        if (!includeRelated)
            return await context.Voters.ToListAsync();

        return await context.Voters.Include(x => x.Vote).ToListAsync();
    }

    public void Add(Voter voter)
    {
        this.context.Add(voter);
    }

    public void Update(Voter voter)
    {
        this.context.Update(voter);
    }

    public void Remove(Voter voter)
    {
        this.context.Remove(voter);
    }

    public async Task<IEnumerable<Voter>> GetAvailableVoters()
    {
        return await
        context
        .Voters
        .Include(x => x.Vote)
        .Where(x => x.Vote == null)
        .ToListAsync();
    }
}