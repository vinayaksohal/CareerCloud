﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyDescriptionLogic:BaseLogic<CompanyDescriptionPoco>
    {
        public CompanyDescriptionLogic(IDataRepository<CompanyDescriptionPoco> repository) : base(repository)
        {

        }
        public override void Add(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (CompanyDescriptionPoco poco in pocos)
            {

                if (string.IsNullOrEmpty(poco.CompanyDescription) || poco.CompanyDescription.Length <= 2 )
                {
                    exceptions.Add(new ValidationException(107, "CompanyDescription must be greater then 2 characters"));
                }

                if (string.IsNullOrEmpty(poco.CompanyName) || poco.CompanyName.Length <= 2 )
                {
                    exceptions.Add(new ValidationException(106, "CompanyName must be greater then 2 characters"));
                }

                
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
