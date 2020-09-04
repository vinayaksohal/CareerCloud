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
    public class SystemLanguageCodeController : ControllerBase
    {
        private readonly SystemLanguageCodeLogic _logic;
        public SystemLanguageCodeController()
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>();
            _logic = new SystemLanguageCodeLogic(repo);
        }

        [HttpGet]
        [Route("languagecode/{Id}")]
        [ProducesResponseType(typeof(SystemLanguageCodePoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetSystemLanguageCode(string Id)
        {
            SystemLanguageCodePoco poco = _logic.Get(Id);

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
        [Route("languagecode")]
        public ActionResult PostSystemLanguageCode([FromBody] SystemLanguageCodePoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("languagecode")]
        public ActionResult PutSystemLanguageCode([FromBody] SystemLanguageCodePoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("languagecode")]

        public ActionResult DeleteSystemLanguageCode([FromBody] SystemLanguageCodePoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("languagecode")]
        [ProducesResponseType(typeof(List<SystemLanguageCodePoco>), 200)]
        public ActionResult GetAllSystemLanguageCode()
        {
            return Ok(_logic.GetAll());
        }
    }
}
