using Mmu.Ct.Backend.WebApi.Areas.DataAccess.DataModels;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;
using Mmu.Mlh.DataAccess.Areas.DatabaseAccess;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.Areas.Repositories;

namespace Mmu.Ct.Backend.WebApi.Areas.DataAccess.Repositories.Implementation
{
    public class IndividualRepository : RepositoryBase<Individual, IndividualDataModel, string>
    {
        private readonly IDataModelAdapter<IndividualDataModel, Individual, string> _dataModelAdapter;
        private readonly IDataModelRepository<IndividualDataModel, string> _dataModelRepository;

        public IndividualRepository(IDataModelRepository<IndividualDataModel, string> dataModelRepository, IDataModelAdapter<IndividualDataModel, Individual, string> dataModelAdapter) : base(dataModelRepository, dataModelAdapter)
        {
            _dataModelRepository = dataModelRepository;
            _dataModelAdapter = dataModelAdapter;
        }
    }
}