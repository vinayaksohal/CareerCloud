﻿using CareerCloud.BusinessLogicLayer;
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
    public class SystemLanguageCodeService:Protos.SystemLanguageCode.SystemLanguageCodeBase
    {
        private SystemLanguageCodeLogic _logic;

        public SystemLanguageCodeService()
        {
            _logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>());
        }

        public override Task<SystemLanguageCodeReply> GetSystemLanguageCode(IdRequest7 request, ServerCallContext context)
        {
            SystemLanguageCodePoco poco = _logic.Get(request.Id);
            return Task.FromResult<SystemLanguageCodeReply>(FromPoco(poco));
        }

        public override Task<SystemLanguageCodes> GetSystemLanguageCodes(Empty request, ServerCallContext context)
        {
            SystemLanguageCodes edus = new SystemLanguageCodes();
            List<SystemLanguageCodePoco> pocos = _logic.GetAll();
            foreach(SystemLanguageCodePoco poco in pocos)
            {
                edus.SystemLanguageCodeReplies.Add(FromPoco(poco));
            }

            return Task.FromResult<SystemLanguageCodes>(edus);
        }

        public override Task<Empty> AddGetSystemLanguageCodes(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach(SystemLanguageCodeReply reply in request.SystemLanguageCodeReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Add(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> UpdateGetSystemLanguageCodes(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (SystemLanguageCodeReply reply in request.SystemLanguageCodeReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Update(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }

        public override Task<Empty> DeleteGetSystemLanguageCodes(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (SystemLanguageCodeReply reply in request.SystemLanguageCodeReplies)
            {
                pocos.Add(ToPoco(reply));
            }
            _logic.Delete(pocos.ToArray());
            return Task.FromResult<Empty>(null);
        }
        private SystemLanguageCodeReply FromPoco(SystemLanguageCodePoco poco)
        {
            return new SystemLanguageCodeReply()
            {
                LanguageID = poco.LanguageID,
                Name = poco.Name,
                NativeName = poco.NativeName
            };
        }

        private SystemLanguageCodePoco ToPoco(SystemLanguageCodeReply reply)
        {
            return new SystemLanguageCodePoco()
            {
                LanguageID = reply.LanguageID,
                Name = reply.Name,
                NativeName = reply.NativeName
            };
        }
    }
}
