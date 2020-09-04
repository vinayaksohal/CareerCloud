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
    public class CompanyDescriptionController : ControllerBase
    {
        private readonly CompanyDescriptionLogic _logic;
        public CompanyDescriptionController()
        {
            EFGenericRepository<CompanyDescriptionPoco> repo = new EFGenericRepository<CompanyDescriptionPoco>();
            _logic = new CompanyDescriptionLogic(repo);
        }

        [HttpGet]
        [Route("description/{Id}")]
        [ProducesResponseType(typeof(CompanyDescriptionPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetCompanyDescription(Guid Id)
        {
            CompanyDescriptionPoco poco = _logic.Get(Id);

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
        [Route("description")]
        public ActionResult PostCompanyDescription([FromBody] CompanyDescriptionPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("description")]
        public ActionResult PutCompanyDescription([FromBody] CompanyDescriptionPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("description")]

        public ActionResult DeleteCompanyDescription([FromBody] CompanyDescriptionPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("description")]
        [ProducesResponseType(typeof(List<CompanyDescriptionPoco>), 200)]
        public ActionResult GetAllCompanyDescription()
        {
            return Ok(_logic.GetAll());
        }
    }
}
