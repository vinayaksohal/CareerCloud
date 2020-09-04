using System;
using Microsoft.AspNetCore.Mvc;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1/[controller]")]
    [ApiController]
    public class ApplicantEducationController : ControllerBase
    {
        private readonly ApplicantEducationLogic _logic;
        public ApplicantEducationController()
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>();
            _logic = new ApplicantEducationLogic(repo);
        }

        [HttpGet]
        [Route("education/{Id}")]
        [ProducesResponseType(typeof(ApplicantEducationPoco),200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetApplicantEducation(Guid Id)
        {
            ApplicantEducationPoco poco = _logic.Get(Id);
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
        [Route("education")]
        public ActionResult PostApplicantEducation([FromBody] ApplicantEducationPoco[] poco) 
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("education")]
        public ActionResult PutApplicantEducation([FromBody] ApplicantEducationPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("education")]

        public ActionResult DeleteApplicantEducation([FromBody] ApplicantEducationPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("education")]
        [ProducesResponseType(typeof(List<ApplicantEducationPoco>),200)]
        public ActionResult GetAllApplicantEducation()
        {
            return Ok(_logic.GetAll());
        }

    }
}
