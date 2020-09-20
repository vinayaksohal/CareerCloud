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
    public class ApplicantProfileService:Protos.ApplicantProfile.ApplicantProfileBase
    {
        private ApplicantProfileLogic _logic;

        public ApplicantProfileService()
        {
            _logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>());
        }

        public override Task<ApplicantProfileReply> GetApplicantProfile(IdRequest2 request,
            ServerCallContext context)
        {
            ApplicantProfilePoco poco =_logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<ApplicantProfileReply>(FromPoco(poco)) ; 
        }

        public override Task<ApplicantProfiles> GetApplicantProfiles(Empty request, ServerCallContext context)
        {
            ApplicantProfiles edus = new ApplicantProfiles();
            List<ApplicantProfilePoco> pocos = _logic.GetAll();
            foreach(ApplicantProfilePoco poco in pocos)
            {
                edus.ApplicantProfileReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<ApplicantProfiles>(edus);
        }

        public override Task<Empty> AddGetApplicantProfiles(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach(ApplicantProfileReply reply in request.ApplicantProfileReplies)
            {
                pocos.Add(
                new ApplicantProfilePoco()
                {
                    Login = Guid.Parse(reply.Login),
                    CurrentSalary = (DecimalValue.ToDecimal(reply.CurrentSalary)),
                    CurrentRate = (DecimalValue.ToDecimal(reply.CurrentRate)),
                    Currency = reply.Currency,
                    Country = reply.Country,
                    Province = reply.Province,
                    Street = reply.Street,
                    City = reply.City,
                    PostalCode = reply.PostalCode
                });
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetApplicantProfiles(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (ApplicantProfileReply reply in request.ApplicantProfileReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetApplicantProfiles(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (ApplicantProfileReply reply in request.ApplicantProfileReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private ApplicantProfileReply FromPoco(ApplicantProfilePoco poco)
        {

            return new ApplicantProfileReply()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login.ToString(),
                CurrentSalary = poco.CurrentSalary == null ?
                                     DecimalValue.FromDecimal(0):
                                     DecimalValue.FromDecimal((decimal)poco.CurrentSalary),
                CurrentRate = poco.CurrentRate == null ?
                                     DecimalValue.FromDecimal(0) :
                                     DecimalValue.FromDecimal((decimal)poco.CurrentRate),
                Currency = poco.Currency,
                Country = poco.Country,
                Province = poco.Province,
                Street = poco.Street,
                City = poco.City,
                PostalCode = poco.PostalCode
            };
        }

        private ApplicantProfilePoco ToPoco(ApplicantProfileReply reply)
        {
            return new ApplicantProfilePoco()
            {
                Id = Guid.Parse(reply.Id),
                Login = Guid.Parse(reply.Login),
                CurrentSalary = (DecimalValue.ToDecimal(reply.CurrentSalary)),
                CurrentRate = (DecimalValue.ToDecimal(reply.CurrentRate)),
                Currency = reply.Currency,
                Country = reply.Country,
                Province = reply.Province,
                Street = reply.Street,
                City = reply.City,
                PostalCode = reply.PostalCode
            };
        }
    }
}
