using AutoMapper;
using Mmu.Ct.Backend.WebApi.Areas.DataAccess.DataModeling;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Factories;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services.Implementation;

namespace Mmu.Ct.Backend.WebApi.Areas.DataAccess.Repositories.Adapters.Implementation
{
    public class IndividualDataModelAdapter : DataModelAdapterBase<IndividualDataModel, Individual, string>
    {
        private readonly IIndividualFactory _individualFactory;

        public IndividualDataModelAdapter(IIndividualFactory individualFactory, IMapper mapper) : base(mapper)
        {
            _individualFactory = individualFactory;
        }

        public override Individual Adapt(IndividualDataModel dataModel)
        {
            return _individualFactory.Create(
                dataModel.FirstName,
                dataModel.LastName,
                dataModel.Birthdate,
                dataModel.Id);
        }
    }
}