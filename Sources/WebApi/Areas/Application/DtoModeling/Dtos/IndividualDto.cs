using System;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Models;

namespace Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Dtos
{
    public class IndividualDto : DtoBase<string>
    {
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}