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
    [Route("api/careercloud/security/v1/[controller]")]
    [ApiController]
    public class SecurityLoginsLogController : ControllerBase
    {
        private readonly SecurityLoginsLogLogic _logic;
        public SecurityLoginsLogController()
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>();
            _logic = new SecurityLoginsLogLogic(repo);
        }

        [HttpGet]
        [Route("LoginsLog/{Id}")]
        [ProducesResponseType(typeof(SecurityLoginsLogPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetSecurityLoginLog(Guid Id)
        {
            SecurityLoginsLogPoco poco = _logic.Get(Id);

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
        [Route("LoginsLog")]
        public ActionResult PostSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("LoginsLog")]
        public ActionResult PutSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("LoginsLog")]

        public ActionResult DeleteSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("LoginsLog")]
        [ProducesResponseType(typeof(List<SecurityLoginsLogPoco>), 200)]
        public ActionResult GetAllSecurityLoginLog()
        {
            return Ok(_logic.GetAll());
        }
    }
}
