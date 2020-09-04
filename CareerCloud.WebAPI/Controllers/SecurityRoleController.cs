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
    public class SecurityRoleController : ControllerBase
    {
        private readonly SecurityRoleLogic _logic;
        public SecurityRoleController()
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>();
            _logic = new SecurityRoleLogic(repo);
        }

        [HttpGet]
        [Route("Role/{Id}")]
        [ProducesResponseType(typeof(SecurityRolePoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetSecurityRole(Guid Id)
        {
            SecurityRolePoco poco = _logic.Get(Id);

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
        [Route("Role")]
        public ActionResult PostSecurityRole([FromBody] SecurityRolePoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("Role")]
        public ActionResult PutSecurityRole([FromBody] SecurityRolePoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("Role")]

        public ActionResult DeleteSecurityRole([FromBody] SecurityRolePoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("Role")]
        [ProducesResponseType(typeof(List<SecurityRolePoco>), 200)]
        public ActionResult GetAllSecurityRole()
        {
            return Ok(_logic.GetAll());
        }
    }
}
