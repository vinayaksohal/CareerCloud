using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using CareerCloud.EntityFrameworkDataAccess;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1/[controller]")]
    [ApiController]
    public class ApplicantSkillController : ControllerBase
    {
        private ApplicantSkillLogic _logic;
        public ApplicantSkillController()
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>();
            _logic = new ApplicantSkillLogic(repo);
        }

        [HttpGet]
        [Route("skill/{Id}")]
        [ProducesResponseType(typeof(ApplicantSkillPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetApplicantSkill(Guid Id)
        {
            ApplicantSkillPoco poco = _logic.Get(Id);

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
        [Route("skill")]
        public ActionResult PostApplicantSkill([FromBody] ApplicantSkillPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("skill")]
        public ActionResult PutApplicantSkill([FromBody] ApplicantSkillPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("skill")]

        public ActionResult DeleteApplicantSkill([FromBody] ApplicantSkillPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("skill")]
        [ProducesResponseType(typeof(List<ApplicantSkillPoco>), 200)]
        public ActionResult GetAllApplicantSkill()
        {
            return Ok(_logic.GetAll());
        }
    }
}
