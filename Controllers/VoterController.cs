using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VoutesCounter.Core;
using VoutesCounter.DTOs;
using VoutesCounter.Models;

namespace VoutesCounter.Controllers;

[ApiController]
[Route("[controller]")]
public class VoterController : ControllerBase
{
    private readonly IVoterRepository repository;
    private readonly IUnitOfWork uow;
    private readonly IMapper mapper;

    public VoterController(IVoterRepository repository, IMapper mapper, IUnitOfWork uow)
    {
        this.mapper = mapper;
        this.repository = repository;
        this.uow = uow;
    }


    [HttpGet()]
    public async Task<IEnumerable<VoterDTO>> GetVoters()
    {
        var voters = await this.repository.GetVoters();
        return mapper.Map<IEnumerable<VoterDTO>>(voters);
    }

    [Route("Available")]
    [HttpGet]
    public async Task<IEnumerable<VoterDTO>> GetAvailableVoters()
    {
        var voters = await this.repository.GetAvailableVoters();
        return mapper.Map<IEnumerable<VoterDTO>>(voters);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetVoter(int id)
    {
        var voter = await repository.GetVoter(id);

        if (voter == null)
            return NotFound();

        var result = mapper.Map<VoterDTO>(voter);
        return Ok(result);
    }


    [HttpPost()]
    public async Task<IActionResult> CreateVoter([FromBody] VoterDTO vouterDTO)
    {
        var voterModel = this.mapper.Map<Voter>(vouterDTO);

        this.repository.Add(voterModel);
        await this.uow.Complete();

        var result = this.mapper.Map<Voter, VoterDTO>(voterModel);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateVoter(int id, [FromBody] VoterDTO vouterDTO)
    {
        var voterModel = await this.repository.GetVoter(id);
        mapper.Map<VoterDTO, Voter>(vouterDTO, voterModel);

        await this.uow.Complete();

        var result = this.mapper.Map<Voter, VoterDTO>(voterModel);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVoter(int id)
    {
        var voterModel = await repository.GetVoter(id, true);
        if (voterModel == null) return NotFound();

        this.repository.Remove(voterModel);
        await this.uow.Complete();

        return Ok(id);
    }
}
