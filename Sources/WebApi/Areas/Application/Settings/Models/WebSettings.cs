using Mmu.Mlh.DataAccess.MongoDb.Infrastructure.Settings.Models;
using Mmu.Mlh.WebApiExtensions.Infrastructure.Settings.Models;

namespace Mmu.Ct.Backend.WebApi.Areas.Application.Settings.Models
{
    public class WebSettings
    {
        public MongoDbSettings MongoDbSettings { get; set; }
        public SecuritySettings SecuritySettings { get; set; }
    }
}