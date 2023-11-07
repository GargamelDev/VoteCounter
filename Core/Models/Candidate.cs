
namespace VoutesCounter.Models;

public class Candidate
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IList<Vote> Votes { get; set; }
}