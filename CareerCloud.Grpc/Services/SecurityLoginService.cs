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
    public class SecurityLoginService:Protos.SecurityLogin.SecurityLoginBase
    {
        private SecurityLoginLogic _logic;

        public SecurityLoginService()
        {
            _logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>());
        }

        public override Task<SecurityLoginReply> GetSecurityLogin(IdRequest6 request, ServerCallContext context)
        {
            SecurityLoginPoco poco = _logic.Get(Guid.Parse(request.Id));
            return Task.FromResult<SecurityLoginReply>(FromPoco(poco));
        }

        public override Task<SecurityLogins> GetSecurityLogins(Empty request, ServerCallContext context)
        {
            SecurityLogins edus = new SecurityLogins();
            List<SecurityLoginPoco> pocos = _logic.GetAll();
            foreach(SecurityLoginPoco poco in pocos)
            {
                edus.SecurityLoginReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<SecurityLogins>(edus);
        }

        public override Task<Empty> AddGetSecurityLogins(SecurityLogins request, ServerCallContext context)
        {
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach(SecurityLoginReply reply in request.SecurityLoginReplies)
            {
                pocos.Add(
                new SecurityLoginPoco()
                {                   
                    Login = reply.Login,
                    AgreementAccepted = DateTime.Parse(reply.AgreementAccepted.ToString()),
                    Created = DateTime.Parse(reply.Created.ToString()),
                    EmailAddress = reply.EmailAddress,
                    FullName = reply.FullName,
                    ForceChangePassword = reply.ForceChangePassword,
                    IsInactive = reply.IsInactive,
                    IsLocked = reply.IsLocked,
                    Password = reply.Password,
                    PasswordUpdate = DateTime.Parse(reply.PasswordUpdate.ToString()),
                    PhoneNumber = reply.PhoneNumber,
                    PrefferredLanguage = reply.PrefferredLanguage
                });
               
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetSecurityLogins(SecurityLogins request, ServerCallContext context)
        {
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (SecurityLoginReply reply in request.SecurityLoginReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetSecurityLogins(SecurityLogins request, ServerCallContext context)
        {
            List<SecurityLoginPoco> pocos = new List<SecurityLoginPoco>();
            foreach (SecurityLoginReply reply in request.SecurityLoginReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private SecurityLoginReply FromPoco(SecurityLoginPoco poco)
        {
            return new SecurityLoginReply()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login,
                AgreementAccepted = poco.AgreementAccepted is null ?
                                 null :
                                 Timestamp.FromDateTime((DateTime)poco.AgreementAccepted),
                Created = Timestamp.FromDateTime(poco.Created),
                EmailAddress = poco.EmailAddress,
                FullName = poco.FullName,
                ForceChangePassword = poco.ForceChangePassword,
                IsInactive = poco.IsInactive,
                IsLocked = poco.IsLocked,
                Password = poco.Password,
                PasswordUpdate = poco.PasswordUpdate is null ?
                                 null :
                                 Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)poco.PasswordUpdate,DateTimeKind.Utc)),
                PhoneNumber = poco.PhoneNumber,
                PrefferredLanguage = poco.PrefferredLanguage
            };
        }

        private SecurityLoginPoco ToPoco(SecurityLoginReply reply)
        {
            return new SecurityLoginPoco()
            {
                Id = Guid.Parse(reply.Id),
                Login = reply.Login,
                AgreementAccepted = DateTime.Parse(reply.AgreementAccepted.ToString()),
                Created = DateTime.Parse(reply.Created.ToString()),
                EmailAddress = reply.EmailAddress,
                FullName = reply.FullName,
                ForceChangePassword = reply.ForceChangePassword,
                IsInactive = reply.IsInactive,
                IsLocked = reply.IsLocked,
                Password = reply.Password,
                PasswordUpdate = DateTime.Parse(reply.PasswordUpdate.ToString()),
                PhoneNumber = reply.PhoneNumber,
                PrefferredLanguage = reply.PrefferredLanguage
            };
        }
    }
}
    