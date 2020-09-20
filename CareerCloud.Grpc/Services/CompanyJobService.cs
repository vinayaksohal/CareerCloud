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
    public class CompanyJobService:Protos.CompanyJob.CompanyJobBase
    {
        private CompanyJobLogic _logic;

        public CompanyJobService()
        {
            _logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>());
        }

        public override Task<CompanyJobReply> GetCompanyJob(IdRequest4 request,
            ServerCallContext context)
        {
            CompanyJobPoco poco =_logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<CompanyJobReply>(FromPoco(poco)) ; 
        }

        public override Task<CompanyJobs> GetCompanyJobs(Empty request, ServerCallContext context)
        {
            CompanyJobs edus = new CompanyJobs();
            List<CompanyJobPoco> pocos = _logic.GetAll();
            foreach(CompanyJobPoco poco in pocos)
            {
                edus.CompanyJobReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<CompanyJobs>(edus);
        }

        public override Task<Empty> AddGetCompanyJobs(CompanyJobs request, ServerCallContext context)
        {
            List<CompanyJobPoco> pocos = new List<CompanyJobPoco>();
            foreach(CompanyJobReply reply in request.CompanyJobReplies)
            {
                pocos.Add(
                new CompanyJobPoco()
                {
                    Company = Guid.Parse(reply.Company),
                    IsCompanyHidden = reply.IsCompanyHidden,
                    IsInactive = reply.IsInactive,
                    ProfileCreated = DateTime.Parse(reply.ProfileCreated.ToString())
                });
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetCompanyJobs(CompanyJobs request, ServerCallContext context)
        {
            List<CompanyJobPoco> pocos = new List<CompanyJobPoco>();
            foreach (CompanyJobReply reply in request.CompanyJobReplies)
            {
                pocos.Add(
                new CompanyJobPoco()
                {
                    Company = Guid.Parse(reply.Company),
                    IsCompanyHidden = reply.IsCompanyHidden,
                    IsInactive = reply.IsInactive,
                    ProfileCreated = DateTime.Parse(reply.ProfileCreated.ToString())
                });
                
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetCompanyJobs(CompanyJobs request, ServerCallContext context)
        {
            List<CompanyJobPoco> pocos = new List<CompanyJobPoco>();
            foreach (CompanyJobReply reply in request.CompanyJobReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private CompanyJobReply FromPoco(CompanyJobPoco poco)
        {
            return new CompanyJobReply()
            {
                Id = poco.Id.ToString(),
                Company = poco.Company.ToString(),
                IsCompanyHidden = poco.IsCompanyHidden,
                IsInactive = poco.IsInactive,
                ProfileCreated = Timestamp.FromDateTime(DateTime.SpecifyKind(poco.ProfileCreated,DateTimeKind.Utc))
            };
        }

        private CompanyJobPoco ToPoco(CompanyJobReply reply)
        {
            return new CompanyJobPoco()
            {
                Id = Guid.Parse(reply.Id),
                Company = Guid.Parse(reply.Company),
                IsCompanyHidden = reply.IsCompanyHidden,
                IsInactive = reply.IsInactive,
                ProfileCreated = DateTime.Parse(reply.ProfileCreated.ToString())
            };
        }
    }
}
