using VoutesCounter.Models;

namespace VoutesCounter.Core;

public interface IVoterRepository
{
    Task<Voter> GetVoter(int id, bool includeRelated = true);
    Task<IEnumerable<Voter>> GetVoters(bool includeRelated = true);
    void Add(Voter voter);
    void Update(Voter voter);
    void Remove(Voter voter);
    Task<IEnumerable<Voter>> GetAvailableVoters();
}