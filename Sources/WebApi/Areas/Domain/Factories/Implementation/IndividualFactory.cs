using System;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;
using Mmu.Mlh.DomainExtensions.Areas.Factories;

namespace Mmu.Ct.Backend.WebApi.Areas.Domain.Factories.Implementation
{
    public class IndividualFactory : IIndividualFactory
    {
        private readonly IEntityIdFactory<string> _entityIdFactory;

        public IndividualFactory(IEntityIdFactory<string> entityIdFactory)
        {
            _entityIdFactory = entityIdFactory;
        }

        public Individual Create(string firstName, string lastName, DateTime birthdate, string id = null)
        {
            return new Individual(
                id ?? _entityIdFactory.CreateEntityId(),
                firstName,
                lastName,
                birthdate);
        }
    }
}