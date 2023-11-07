using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoutesCounter.DTOs;
using VoutesCounter.Models;
using VoutesCounter.Persistance;

namespace VoutesCounter.Controllers;

[ApiController]
[Route("[controller]")]
public class CandidateController : ControllerBase
{
    public CandidateController(VoutesCounterDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }
    private readonly VoutesCounterDbContext context;
    private IMapper mapper;

    [HttpGet()]
    public async Task<IEnumerable<CandidateDTO>> GetCandidates()
    {
        var candidates = await context.Candidates.Include(x => x.Votes).ToListAsync();
        return mapper.Map<List<CandidateDTO>>(candidates);
    }

    [HttpPost()]
    public async Task<CandidateDTO> CreateCandidate(CandidateDTO candidate)
    {
        var candidateModel = mapper.Map<Candidate>(candidate);
        context.Candidates.Add(candidateModel);
        await context.SaveChangesAsync();
        return candidate;
    }
}