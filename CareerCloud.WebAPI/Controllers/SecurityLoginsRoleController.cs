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
    public class SecurityLoginsRoleController : ControllerBase
    {
        private readonly SecurityLoginsRoleLogic _logic;
        public SecurityLoginsRoleController()
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>();
            _logic = new SecurityLoginsRoleLogic(repo);
        }

        [HttpGet]
        [Route("LoginsRole/{Id}")]
        [ProducesResponseType(typeof(SecurityLoginsRolePoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetSecurityLoginsRole(Guid Id)
        {
            SecurityLoginsRolePoco poco = _logic.Get(Id);

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
        [Route("LoginsRole")]
        public ActionResult PostSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("LoginsRole")]
        public ActionResult PutSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("LoginsRole")]

        public ActionResult DeleteSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("LoginsRole")]
        [ProducesResponseType(typeof(List<SecurityLoginsRolePoco>), 200)]
        public ActionResult GetAllSecurityLoginRole()
        {
            return Ok(_logic.GetAll());
        }
    }
}
