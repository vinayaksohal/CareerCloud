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
    public class CompanyJobEducationController : ControllerBase
    {
        private readonly CompanyJobEducationLogic _logic;
        public CompanyJobEducationController()
        {
            EFGenericRepository<CompanyJobEducationPoco> repo = new EFGenericRepository<CompanyJobEducationPoco>();
            _logic = new CompanyJobEducationLogic(repo);
        }

        [HttpGet]
        [Route("jobeducation/{Id}")]
        [ProducesResponseType(typeof(CompanyJobEducationPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetCompanyJobEducation(Guid Id)
        {
            CompanyJobEducationPoco poco = _logic.Get(Id);

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
        [Route("jobeducation")]
        public ActionResult PostCompanyJobEducation([FromBody] CompanyJobEducationPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("jobeducation")]
        public ActionResult PutCompanyJobEducation([FromBody] CompanyJobEducationPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("jobeducation")]

        public ActionResult DeleteCompanyJobEducation([FromBody] CompanyJobEducationPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("jobeducation")]
        [ProducesResponseType(typeof(List<CompanyJobEducationPoco>), 200)]
        public ActionResult GetAllCompanyJobEducation()
        {
            return Ok(_logic.GetAll());
        }
    }
}
