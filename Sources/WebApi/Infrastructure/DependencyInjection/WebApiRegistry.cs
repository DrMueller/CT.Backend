using Mmu.Ct.Backend.WebApi.Areas.Application.Settings.Services;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services;
using Mmu.Mlh.DataAccess.Areas.DatabaseAccess;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.MongoDb.Infrastructure.Settings.Services;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;
using Mmu.Mlh.WebApiExtensions.Infrastructure.Settings.Services;
using StructureMap;

namespace Mmu.Ct.Backend.WebApi.Infrastructure.DependencyInjection
{
    public class WebApiRegistry : Registry
    {
        public WebApiRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.TheCallingAssembly();
                    scanner.AddAllTypesOf(typeof(IDtoDataService<,>));
                    scanner.AddAllTypesOf(typeof(IDtoAdapter<,,>));
                    scanner.AddAllTypesOf(typeof(IRepository<,>));
                    scanner.AddAllTypesOf(typeof(IDataModelAdapter<,,>));
                    scanner.AddAllTypesOf(typeof(IDataModelRepository<,>));
                    scanner.WithDefaultConventions();
                });

            For<ISecuritySettingsProvider>().Use<WebSettingsProvider>().Singleton();
            For<IMongoDbSettingsProvider>().Use<WebSettingsProvider>().Singleton();
        }
    }
}