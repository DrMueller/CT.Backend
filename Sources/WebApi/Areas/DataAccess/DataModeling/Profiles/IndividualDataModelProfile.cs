﻿using AutoMapper;
using Mmu.Ct.Backend.WebApi.Areas.Domain.Models;

namespace Mmu.Ct.Backend.WebApi.Areas.DataAccess.DataModeling.Profiles
{
    public class IndividualDataModelProfile : Profile
    {
        public IndividualDataModelProfile()
        {
            CreateMap<Individual, IndividualDataModel>()
                .ForMember(d => d.Birthdate, c => c.MapFrom(f => f.Birthdate))
                .ForMember(d => d.FirstName, c => c.MapFrom(f => f.FirstName))
                .ForMember(d => d.Id, c => c.MapFrom(f => f.Id))
                .ForMember(d => d.LastName, c => c.MapFrom(f => f.LastName));
        }
    }
}