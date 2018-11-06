using AutoMapper;
using Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Dtos;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;

namespace Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Services.Adapters.Profiles
{
    public class IndividualDtoProfile : Profile
    {
        public IndividualDtoProfile()
        {
            CreateMap<Individual, IndividualDto>()
                .ForMember(d => d.Birthdate, c => c.MapFrom(f => f.Birthdate))
                .ForMember(d => d.FirstName, c => c.MapFrom(f => f.FirstName))
                .ForMember(d => d.Id, c => c.MapFrom(f => f.Id))
                .ForMember(d => d.LastName, c => c.MapFrom(f => f.LastName));
        }
    }
}