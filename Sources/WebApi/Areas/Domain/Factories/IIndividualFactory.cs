using System;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;

namespace Mmu.Ct.Backend.WebApi.Areas.Domain.Factories
{
    public interface IIndividualFactory
    {
        Individual Create(string firstName, string lastName, DateTime birthdate, string id = null);
    }
}