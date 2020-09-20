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
    public class CompanyDescriptionService:Protos.CompanyDescription.CompanyDescriptionBase
    {
        private CompanyDescriptionLogic _logic;

        public CompanyDescriptionService()
        {
            _logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>());
        }

        public override Task<CompanyDescriptionReply> GetCompanyDescription(IdRequest3 request,
            ServerCallContext context)
        {
            CompanyDescriptionPoco poco =_logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<CompanyDescriptionReply>(FromPoco(poco)) ; 
        }

        public override Task<CompanyDescriptions> GetCompanyDescriptions(Empty request, ServerCallContext context)
        {
            CompanyDescriptions edus = new CompanyDescriptions();
            List<CompanyDescriptionPoco> pocos = _logic.GetAll();
            foreach(CompanyDescriptionPoco poco in pocos)
            {
                edus.CompanyDescriptionReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<CompanyDescriptions>(edus);
        }

        public override Task<Empty> AddGetCompanyDescriptions(CompanyDescriptions request, ServerCallContext context)
        {
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach(CompanyDescriptionReply reply in request.CompanyDescriptionReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetCompanyDescriptions(CompanyDescriptions request, ServerCallContext context)
        {
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (CompanyDescriptionReply reply in request.CompanyDescriptionReplies)
            {
                pocos.Add(
                new CompanyDescriptionPoco()
                {
                    Company = Guid.Parse(reply.Company),
                    LanguageId = reply.LanguageId,
                    CompanyName = reply.CompanyName,
                    CompanyDescription = reply.CompanyDescription
                });
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetCompanyDescriptions(CompanyDescriptions request, ServerCallContext context)
        {
            List<CompanyDescriptionPoco> pocos = new List<CompanyDescriptionPoco>();
            foreach (CompanyDescriptionReply reply in request.CompanyDescriptionReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private CompanyDescriptionReply FromPoco(CompanyDescriptionPoco poco)
        {
            return new CompanyDescriptionReply()
            {
                Id = poco.Id.ToString(),
                Company = poco.Company.ToString(),
                LanguageId = poco.LanguageId,
                CompanyName = poco.CompanyName,
                CompanyDescription = poco.CompanyDescription
            };
        }

        private CompanyDescriptionPoco ToPoco(CompanyDescriptionReply reply)
        {
            return new CompanyDescriptionPoco()
            {
                Id = Guid.Parse(reply.Id),
                Company = Guid.Parse(reply.Company),
                LanguageId = reply.LanguageId,
                CompanyName = reply.CompanyName,
                CompanyDescription = reply.CompanyDescription
            };
        }
    }
}
