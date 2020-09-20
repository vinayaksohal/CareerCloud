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
    public class CompanyJobEducationService:Protos.CompanyJobEducation.CompanyJobEducationBase
    {
        private CompanyJobEducationLogic _logic;

        public CompanyJobEducationService()
        {
            _logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>());
        }

        public override Task<CompanyJobEducationReply> GetCompanyJobEducation(IdRequest5 request,
            ServerCallContext context)
        {
            CompanyJobEducationPoco poco =_logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<CompanyJobEducationReply>(FromPoco(poco)) ; 
        }

        public override Task<CompanyJobEducations> GetCompanyJobEducations(Empty request, ServerCallContext context)
        {
            CompanyJobEducations edus = new CompanyJobEducations();
            List<CompanyJobEducationPoco> pocos = _logic.GetAll();
            foreach(CompanyJobEducationPoco poco in pocos)
            {
                edus.CompanyJobEducationReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<CompanyJobEducations>(edus);
        }

        public override Task<Empty> AddGetCompanyJobEducations(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach(CompanyJobEducationReply reply in request.CompanyJobEducationReplies)
            {
                pocos.Add(
                new CompanyJobEducationPoco()
                {
                    Id = Guid.Parse(reply.Id),
                    Job = Guid.Parse(reply.Job),
                    Importance = (short)reply.Importance,
                    Major = reply.Major
                });               
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetCompanyJobEducations(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (CompanyJobEducationReply reply in request.CompanyJobEducationReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetCompanyJobEducations(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (CompanyJobEducationReply reply in request.CompanyJobEducationReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private CompanyJobEducationReply FromPoco(CompanyJobEducationPoco poco)
        {
            return new CompanyJobEducationReply()
            {
                Id = poco.Id.ToString(),
                Job = poco.Job.ToString(),
                Importance = poco.Importance,
                Major = poco.Major
            };
        }

        private CompanyJobEducationPoco ToPoco(CompanyJobEducationReply reply)
        {
            return new CompanyJobEducationPoco()
            {
                Id = Guid.Parse(reply.Id),
                Job = Guid.Parse(reply.Job),
                Importance = (short)reply.Importance,
                Major = reply.Major
            };
        }
    }
}
