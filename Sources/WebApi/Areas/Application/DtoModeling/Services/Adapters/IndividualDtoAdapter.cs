using AutoMapper;
using Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Dtos;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Factories;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services.Implementation;

namespace Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Services.Adapters
{
    public class IndividualDtoAdapter : DtoAdapterBase<IndividualDto, Individual, string>
    {
        private readonly IIndividualFactory _individualFactory;

        public IndividualDtoAdapter(IMapper mapper, IIndividualFactory individualFactory) : base(mapper)
        {
            _individualFactory = individualFactory;
        }

        public override Individual Adapt(IndividualDto dto)
        {
            return _individualFactory.Create(
                dto.FirstName,
                dto.LastName,
                dto.Birthdate,
                dto.Id);
        }
    }
}