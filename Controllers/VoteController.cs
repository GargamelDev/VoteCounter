using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoutesCounter.DTOs;
using VoutesCounter.Models;
using VoutesCounter.Persistance;

namespace VoutesCounter.Controllers;

[ApiController]
[Route("[controller]")]
public class VoteController : ControllerBase
{
    public VoteController(VoutesCounterDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    private readonly VoutesCounterDbContext context;
    private IMapper mapper;

    [HttpPost()]
    public async Task<VoteDTO> CreateVote(VoteDTO vouter)
    {
        var voteModel = mapper.Map<Vote>(vouter);
        context.Votes.Add(voteModel);
        await context.SaveChangesAsync();
        return vouter;
    }
}
