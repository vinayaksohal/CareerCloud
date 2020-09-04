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
    public class CompanyJobController : ControllerBase
    {
        private readonly CompanyJobLogic _logic;
        public CompanyJobController()
        {
            EFGenericRepository<CompanyJobPoco> repo = new EFGenericRepository<CompanyJobPoco>();
            _logic = new CompanyJobLogic(repo);
        }

        [HttpGet]
        [Route("job/{Id}")]
        [ProducesResponseType(typeof(CompanyJobPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetCompanyJob(Guid Id)
        {
            CompanyJobPoco poco = _logic.Get(Id);

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
        [Route("job")]
        public ActionResult PostCompanyJob([FromBody] CompanyJobPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("job")]
        public ActionResult PutCompanyJob([FromBody] CompanyJobPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("job")]

        public ActionResult DeleteCompanyJob([FromBody] CompanyJobPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("job")]
        [ProducesResponseType(typeof(List<CompanyJobPoco>), 200)]
        public ActionResult GetAllCompanyJob()
        {
            return Ok(_logic.GetAll());
        }
    }
}
