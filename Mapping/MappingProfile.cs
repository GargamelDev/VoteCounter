using AutoMapper;
using VoutesCounter.DTOs;
using VoutesCounter.Models;

namespace VoutesCounter.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Voter, VoterDTO>()
            .ForMember(x => x.HasVoted, opt => opt.MapFrom(y => y.Vote != null));
        CreateMap<Candidate, CandidateDTO>()
            .ForMember(x => x.Votes, opt => opt.MapFrom(y => y.Votes.Count));
        CreateMap<Vote, VoteDTO>();


        CreateMap<VoterDTO, Voter>()
            .ForMember(x => x.Id, opt => opt.Ignore());

        CreateMap<CandidateDTO, Candidate>()
            .ForMember(x => x.Votes, opt => opt.Ignore());
        // .AfterMap((source, destination) =>
        // {
        //     destination.Votes = source.Votes.Count();
        // });
        CreateMap<VoteDTO, Vote>();
    }
}