using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CareerCloud.Pocos;
using CareerCloud.EntityFrameworkDataAccess;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1/[controller]")]
    [ApiController]
    public class ApplicantWorkHistoryController : ControllerBase
    {
        private readonly ApplicantWorkHistoryLogic _logic;
        public ApplicantWorkHistoryController()
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>();
            _logic = new ApplicantWorkHistoryLogic(repo);
        }

        [HttpGet]
        [Route("workhistory/{Id}")]
        [ProducesResponseType(typeof(ApplicantWorkHistoryPoco), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetApplicantWorkHistory(Guid Id)
        {
            ApplicantWorkHistoryPoco poco = _logic.Get(Id);

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
        [Route("workhistory")]
        public ActionResult PostApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] poco)
        {
            _logic.Add(poco);
            return Ok();
        }

        [HttpPut]
        [Route("workhistory")]
        public ActionResult PutApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] poco)
        {
            _logic.Update(poco);
            return Ok();
        }

        [HttpDelete]
        [Route("workhistory")]

        public ActionResult DeleteApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] poco)
        {
            _logic.Delete(poco);
            return Ok();
        }

        [HttpGet]
        [Route("workhistory")]
        [ProducesResponseType(typeof(List<ApplicantWorkHistoryPoco>), 200)]
        public ActionResult GetAllApplicantWorkHistory()
        {
            return Ok(_logic.GetAll());
        }
    }
}
