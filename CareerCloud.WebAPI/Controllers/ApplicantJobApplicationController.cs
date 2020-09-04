using System;
using System.Collections.Generic;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1/[controller]")]
    [ApiController]
    public class ApplicantJobApplicationController : ControllerBase
    {
        private readonly ApplicantJobApplicationLogic _logic;
        public ApplicantJobApplicationController()
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>();
            _logic = new ApplicantJobApplicationLogic(repo);
        }

        [HttpGet]
        [Route("jobapplication/{Id}")]
        [ProducesResponseType(typeof(ApplicantJobApplicationPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetApplicantJobApplication(Guid Id)
        {
            ApplicantJobApplicationPoco poco = _logic.Get(Id);
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
        [Route("jobapplication")]
        public ActionResult PostApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("jobapplication")]
        public ActionResult PutApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("jobapplication")]

        public ActionResult DeleteApplicantJobApplication([FromBody] ApplicantJobApplicationPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("jobapplication")]
        [ProducesResponseType(typeof(List<ApplicantJobApplicationPoco>), 200)]
        public ActionResult GetAllApplicantJobApplication()
        {
            return Ok(_logic.GetAll());
        }
    }
}
