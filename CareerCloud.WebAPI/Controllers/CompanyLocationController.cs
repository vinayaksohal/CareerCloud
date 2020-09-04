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
    public class CompanyLocationController : ControllerBase
    {
        private readonly CompanyLocationLogic _logic;
        public CompanyLocationController()
        {
            EFGenericRepository<CompanyLocationPoco> repo = new EFGenericRepository<CompanyLocationPoco>();
            _logic = new CompanyLocationLogic(repo);
        }

        [HttpGet]
        [Route("Location/{Id}")]
        [ProducesResponseType(typeof(CompanyLocationPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetCompanyLocation(Guid Id)
        {
            CompanyLocationPoco poco = _logic.Get(Id);

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
        [Route("Location")]
        public ActionResult PostCompanyLocation([FromBody] CompanyLocationPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("Location")]
        public ActionResult PutCompanyLocation([FromBody] CompanyLocationPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("Location")]

        public ActionResult DeleteCompanyLocation([FromBody] CompanyLocationPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("Location")]
        [ProducesResponseType(typeof(List<CompanyLocationPoco>), 200)]
        public ActionResult GetAllCompanyLocation()
        {
            return Ok(_logic.GetAll());
        }
    }
}
