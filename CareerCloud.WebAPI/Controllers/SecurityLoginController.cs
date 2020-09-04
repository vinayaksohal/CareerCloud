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
    public class SecurityLoginController : ControllerBase
    {
        private readonly SecurityLoginLogic _logic;
        public SecurityLoginController()
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>();
            _logic = new SecurityLoginLogic(repo);
        }

        [HttpGet]
        [Route("Login/{Id}")]
        [ProducesResponseType(typeof(SecurityLoginPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetSecurityLogin(Guid Id)
        {
            SecurityLoginPoco poco = _logic.Get(Id);

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
        [Route("Login")]
        public ActionResult PostSecurityLogin([FromBody] SecurityLoginPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("Login")]
        public ActionResult PutSecurityLogin([FromBody] SecurityLoginPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("Login")]

        public ActionResult DeleteSecurityLogin([FromBody] SecurityLoginPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("Login")]
        [ProducesResponseType(typeof(List<SecurityLoginPoco>), 200)]
        public ActionResult GetAllSecurityLogin()
        {
            return Ok(_logic.GetAll());
        }
    }
}
