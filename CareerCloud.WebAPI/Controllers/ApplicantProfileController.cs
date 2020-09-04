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
    [Route("api/careercloud/applicant/v1/[controller]")]
    [ApiController]
    public class ApplicantProfileController : ControllerBase
    {
        private ApplicantProfileLogic _logic;
        public ApplicantProfileController()
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>();
            _logic = new ApplicantProfileLogic(repo);
        }

        [HttpGet]
        [Route("profile/{Id}")]
        [ProducesResponseType(typeof(ApplicantProfilePoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetApplicantProfile(Guid Id)
        {
            ApplicantProfilePoco poco = _logic.Get(Id);

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
        [Route("profile")]
        public ActionResult PostApplicantProfile([FromBody] ApplicantProfilePoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("profile")]
        public ActionResult PutApplicantProfile([FromBody] ApplicantProfilePoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("profile")]

        public ActionResult DeleteApplicantProfile([FromBody] ApplicantProfilePoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("profile")]
        [ProducesResponseType(typeof(List<ApplicantProfilePoco>), 200)]
        public ActionResult GetAllApplicantProfile()
        {
            return Ok(_logic.GetAll());
        }
    }
}
