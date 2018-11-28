using System;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;

namespace Mmu.Ct.Backend.WebApi.Areas.DataAccess.DataModeling
{
    public class IndividualDataModel : DataModelBase<string>
    {
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}