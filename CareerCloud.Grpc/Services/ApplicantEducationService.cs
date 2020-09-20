using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Grpc.Protos;
using CareerCloud.Pocos;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CareerCloud.Grpc.Services
{
    public class ApplicantEducationService:Protos.ApplicantEducation.ApplicantEducationBase
    {
        private ApplicantEducationLogic _logic;

        public ApplicantEducationService()
        {
            _logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>());
        }

        public override Task<ApplicantEducationReply> GetApplicantEducation(IdRequest request,
            ServerCallContext context)
        {
            ApplicantEducationPoco poco =_logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<ApplicantEducationReply>(FromPoco(poco)) ; 
        }

        public override Task<ApplicantEducations> GetApplicantEducations(Empty request, ServerCallContext context)
        {
            ApplicantEducations edus = new ApplicantEducations();
            List<ApplicantEducationPoco> pocos = _logic.GetAll();
            foreach(ApplicantEducationPoco poco in pocos)
            {
                edus.ApplicationEducarionReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<ApplicantEducations>(edus);
        }

        public override Task<Empty> AddGetApplicantEducations(ApplicantEducations request, ServerCallContext context)
        {
            List<ApplicantEducationPoco> pocos = new List<ApplicantEducationPoco>();
            foreach(ApplicantEducationReply reply in request.ApplicationEducarionReplies)
            {
                pocos.Add(
                new ApplicantEducationPoco()
                {
                    Applicant = Guid.Parse(reply.Applicant),
                    Major = reply.Majot,
                    CertificateDiploma = reply.CertificateDiploma,
                    StartDate = reply.StartDate.ToDateTime(),
                    CompletionDate = reply.CompletionDate.ToDateTime(),
                    CompletionPercent = (byte?)reply.CompletionPercent
                });
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetApplicantEducations(ApplicantEducations request, ServerCallContext context)
        {
            List<ApplicantEducationPoco> pocos = new List<ApplicantEducationPoco>();
            foreach (ApplicantEducationReply reply in request.ApplicationEducarionReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetApplicantEducations(ApplicantEducations request, ServerCallContext context)
        {
            List<ApplicantEducationPoco> pocos = new List<ApplicantEducationPoco>();
            foreach (ApplicantEducationReply reply in request.ApplicationEducarionReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private ApplicantEducationReply FromPoco(ApplicantEducationPoco poco)
        {
            return new ApplicantEducationReply()
            {
                Id = poco.Id.ToString(),
                Applicant = poco.Applicant.ToString(),
                Majot = poco.Major,
                CertificateDiploma = poco.CertificateDiploma,
                StartDate = poco.StartDate == null ? null :
                                          Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)(poco.StartDate), DateTimeKind.Utc)),

                CompletionDate = poco.CompletionDate == null ? null :
                                          Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)(poco.CompletionDate), DateTimeKind.Utc)),
                CompletionPercent = poco.CompletionPercent == null ? 0 : (byte)(poco.CompletionPercent),
                TimeStamp = ByteString.CopyFrom(poco.TimeStamp)
            };
        }

        private ApplicantEducationPoco ToPoco(ApplicantEducationReply reply)
        {
            return new ApplicantEducationPoco()
            {
                Id = Guid.Parse(reply.Id),
                Applicant = Guid.Parse(reply.Applicant),
                Major=reply.Majot,
                CertificateDiploma = reply.CertificateDiploma,
                StartDate = reply.StartDate.ToDateTime(), 
                CompletionDate = reply.CompletionDate.ToDateTime(),
                CompletionPercent = (byte?)reply.CompletionPercent,
                TimeStamp = reply.TimeStamp.ToByteArray()
            };
        }
    }
}
