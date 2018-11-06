using Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Dtos;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services.Implementation;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;

namespace Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Services.Implementation
{
    public class IndividualDtoDataService : DtoDataServiceBase<IndividualDto, Individual, string>
    {
        public IndividualDtoDataService(IRepository<Individual, string> repository, IDtoAdapter<IndividualDto, Individual, string> dtoAdapter) : base(repository, dtoAdapter)
        {
        }
    }
}