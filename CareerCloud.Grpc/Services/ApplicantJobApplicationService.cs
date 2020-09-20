using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Grpc.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerCloud.Grpc.Services
{
    public class ApplicantJobApplicationService:Protos.ApplicantJobApplication.ApplicantJobApplicationBase
    {
        private ApplicantJobApplicationLogic _logic;

        public ApplicantJobApplicationService()
        {
            _logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>());
        }

        public override Task<ApplicantJobApplicationReply> GetApplicantJobApplication(IdRequest1 request,
            ServerCallContext context)
        {
            ApplicantJobApplicationPoco poco =_logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<ApplicantJobApplicationReply>(FromPoco(poco)) ; 
        }

        public override Task<ApplicantJobApplications> GetApplicantJobApplications(Empty request, ServerCallContext context)
        {
            ApplicantJobApplications edus = new ApplicantJobApplications();
            List<ApplicantJobApplicationPoco> pocos = _logic.GetAll();
            foreach(ApplicantJobApplicationPoco poco in pocos)
            {
                edus.ApplicationJobApplicationReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<ApplicantJobApplications>(edus);
        }

        public override Task<Empty> AddGetApplicantJobApplications(ApplicantJobApplications request, ServerCallContext context)
        {
            List<ApplicantJobApplicationPoco> pocos = new List<ApplicantJobApplicationPoco>();
            foreach(ApplicantJobApplicationReply reply in request.ApplicationJobApplicationReplies)
            {
                pocos.Add(
                new ApplicantJobApplicationPoco()
                {
                    Applicant = Guid.Parse(reply.Applicant),
                    Job = Guid.Parse(reply.Job),
                    ApplicationDate = DateTime.Parse(reply.ApplicationDate.ToString())
                });
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetApplicantJobApplications(ApplicantJobApplications request, ServerCallContext context)
        {
            List<ApplicantJobApplicationPoco> pocos = new List<ApplicantJobApplicationPoco>();
            foreach (ApplicantJobApplicationReply reply in request.ApplicationJobApplicationReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetApplicantJobApplications(ApplicantJobApplications request, ServerCallContext context)
        {
            List<ApplicantJobApplicationPoco> pocos = new List<ApplicantJobApplicationPoco>();
            foreach (ApplicantJobApplicationReply reply in request.ApplicationJobApplicationReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private ApplicantJobApplicationReply FromPoco(ApplicantJobApplicationPoco poco)
        {
            return new ApplicantJobApplicationReply()
            {
                Id = poco.Id.ToString(),
                Applicant = poco.Applicant.ToString(),
                Job = poco.Job.ToString(),
                ApplicationDate = Timestamp.FromDateTime(DateTime.SpecifyKind(poco.ApplicationDate,DateTimeKind.Utc)),
                
            };
        }

        private ApplicantJobApplicationPoco ToPoco(ApplicantJobApplicationReply reply)
        {
            return new ApplicantJobApplicationPoco()
            {
                Id = Guid.Parse(reply.Id),
                Applicant = Guid.Parse(reply.Applicant),
                Job = Guid.Parse(reply.Job),
                ApplicationDate = DateTime.Parse(reply.ApplicationDate.ToString())
            };
        }
    }
}
