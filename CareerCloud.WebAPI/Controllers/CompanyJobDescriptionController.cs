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
    public class CompanyJobsDescriptionController : ControllerBase
    {
        private readonly CompanyJobDescriptionLogic _logic;
        public CompanyJobsDescriptionController()
        {
            EFGenericRepository<CompanyJobDescriptionPoco> repo = new EFGenericRepository<CompanyJobDescriptionPoco>();
            _logic = new CompanyJobDescriptionLogic(repo);
        }

        [HttpGet]
        [Route("jobdescription/{Id}")]
        [ProducesResponseType(typeof(CompanyJobDescriptionPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetCompanyJobsDescription(Guid Id)
        {
            CompanyJobDescriptionPoco poco = _logic.Get(Id);

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
        [Route("jobdescription")]
        public ActionResult PostCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("jobdescription")]
        public ActionResult PutCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("jobdescription")]

        public ActionResult DeleteCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("jobdescription")]
        [ProducesResponseType(typeof(List<CompanyJobDescriptionPoco>), 200)]
        public ActionResult GetAllCompanyJobsDescription()
        {
            return Ok(_logic.GetAll());
        }
    }
}
