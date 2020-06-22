﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    class ApplicantEducationRepository : IDataRepository<ApplicantEducationPoco>

    {
        public void Add(params ApplicantEducationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (ApplicantEducationPoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Educations]
                       ([Id]
                       ,[Applicant]
                       ,[Major]
                       ,[Certificate_Diploma]
                       ,[Start_Date]
                       ,[Completion_Date]
                       ,[Completion_Percent])
                 VALUES
                       (@Id
                       ,@Applicant
                       ,@Major
                       ,@Certificate_Diploma
                       ,@Start_Date
                       ,@Completion_Date
                       ,@Completion_Percent)";
                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                cmd.Parameters.AddWithValue("@Major", poco.Major);
                cmd.Parameters.AddWithValue("@Certificate_Diploma", poco.CertificateDiploma);
                cmd.Parameters.AddWithValue("@Start_Date", poco.StartDate);
                cmd.Parameters.AddWithValue("@Completion_Date", poco.CompletionDate);
                cmd.Parameters.AddWithValue("@Completion_Percent", poco.CompletionPercent);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantEducationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (ApplicantEducationPoco poco in items)
            {
                cmd.CommandText = @"DELETE FROM [dbo].[Applicant_Educations]
                WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", poco.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (ApplicantEducationPoco poco in items)
            {
                cmd.CommandText = @"UPDATE [dbo].[Applicant_Educations]
                   SET [Id] = @Id
                      ,[Applicant] = @Applicant
                      ,[Major] = @Major
                      ,[Certificate_Diploma] = @Certificate_Diploma
                      ,[Start_Date] = @Start_Date
                      ,[Completion_Date] = @Completion_Date
                      ,[Completion_Percent] = @Completion_Percent
                 WHERE Id = @Id";

                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                cmd.Parameters.AddWithValue("@Major", poco.Major);
                cmd.Parameters.AddWithValue("@Certificate_Diploma", poco.CertificateDiploma);
                cmd.Parameters.AddWithValue("@Start_Date", poco.StartDate);
                cmd.Parameters.AddWithValue("@Completion_Date", poco.CompletionDate);
                cmd.Parameters.AddWithValue("@Completion_Percent", poco.CompletionPercent);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}