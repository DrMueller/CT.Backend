using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmu.Ct.Backend.WebApi.Areas.Application.DtoModeling.Dtos;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services;
using Mmu.Mlh.WebApiExtensions.Areas.Controllers;

namespace Mmu.Ct.Backend.WebApi.Areas.Web.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class IndividualsController : ControllerBase<IndividualDto, string>
    {
        public IndividualsController(IDtoDataService<IndividualDto, string> dataService) : base(dataService)
        {
        }
    }
}