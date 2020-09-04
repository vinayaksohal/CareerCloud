using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/company/v1/[controller]")]
    [ApiController]
    public class CompanyProfileController : ControllerBase
    {
        private readonly CompanyProfileLogic _logic;
        public CompanyProfileController()
        {
            EFGenericRepository<CompanyProfilePoco> repo = new EFGenericRepository<CompanyProfilePoco>();
            _logic = new CompanyProfileLogic(repo);
        }

        [HttpGet]
        [Route("profile/{Id}")]
        [ProducesResponseType(typeof(CompanyProfilePoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetCompanyProfile(Guid Id)
        {
            CompanyProfilePoco poco = _logic.Get(Id);

            if (poco != null)
            {
                return Ok(poco);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("profile")]
        public ActionResult PostCompanyProfile([FromBody] CompanyProfilePoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("profile")]
        public ActionResult PutCompanyProfile([FromBody] CompanyProfilePoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("profile")]

        public ActionResult DeleteCompanyProfile([FromBody] CompanyProfilePoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("profile")]
        [ProducesResponseType(typeof(List<CompanyProfilePoco>), 200)]
        public ActionResult GetAllCompanyProfile()
        {
            return Ok(_logic.GetAll());
        }
    }
}
