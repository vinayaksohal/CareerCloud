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
    [Route("api/careercloud/system/v1/[controller]")]
    [ApiController]
    public class SystemCountryCodeController : ControllerBase
    {
        private readonly SystemCountryCodeLogic _logic;
        public SystemCountryCodeController()
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>();
            _logic = new SystemCountryCodeLogic(repo);
        }

        [HttpGet]
        [Route("countrycode/{Id}")]
        [ProducesResponseType(typeof(SystemCountryCodePoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetSystemCountryCode(string Id)
        {
            SystemCountryCodePoco poco = _logic.Get(Id);

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
        [Route("countrycode")]
        public ActionResult PostSystemCountryCode([FromBody] SystemCountryCodePoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("countrycode")]
        public ActionResult PutSystemCountryCode([FromBody] SystemCountryCodePoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("countrycode")]

        public ActionResult DeleteSystemCountryCode([FromBody] SystemCountryCodePoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("countrycode")]
        [ProducesResponseType(typeof(List<SystemCountryCodePoco>), 200)]
        public ActionResult GetAllSystemCountryCode()
        {
            return Ok(_logic.GetAll());
        }
    }
}
