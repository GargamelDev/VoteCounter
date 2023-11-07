
namespace VoutesCounter.Models;

public class Voter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual Vote Vote { get; set; }
}