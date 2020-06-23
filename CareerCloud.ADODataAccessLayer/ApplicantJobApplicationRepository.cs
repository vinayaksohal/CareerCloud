﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantJobApplicationRepository : IDataRepository<ApplicantJobApplicationPoco>



    {
        public void Add(params ApplicantJobApplicationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            foreach (ApplicantJobApplicationPoco poco in items)
            {
                cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Job_Applications]
                       ([Id]
                       ,[Applicant]
                       ,[Job]
                       ,[Application_Date])
                 VALUES
                       (@Id
                       ,@Applicant
                       ,@Job
                       ,@Application_Date)";

                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                cmd.Parameters.AddWithValue("@Job", poco.Job);
                cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);

                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantJobApplicationPoco> GetAll(params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT * FROM Applicant_Job_Applications";
            conn.Open();

            int x = 0;
            SqlDataReader rdr = cmd.ExecuteReader();
            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[1000];
            while (rdr.Read())
            {
                ApplicantJobApplicationPoco poco = new ApplicantJobApplicationPoco();
                poco.Id = rdr.GetGuid(0);
                poco.Applicant = rdr.GetGuid(1);
                poco.Job = rdr.GetGuid(2);
                poco.ApplicationDate =rdr.GetDateTime(3);
                pocos[x] = poco;
                x++;
            }
            conn.Close();
            return pocos;
        }

        public IList<ApplicantJobApplicationPoco> GetList(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationPoco GetSingle(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantJobApplicationPoco> pocos = GetAll().AsQueryable();
            try
            {
                return pocos.Where(where).FirstOrDefault();

            }
            catch (NullReferenceException e)
            {
            /*Exception thrown as there is null reference for after performing remove operation on Id. So no Poco exists for that Id */
                
                Console.WriteLine(e);
                return null;
            }
        }

        public void Remove(params ApplicantJobApplicationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (ApplicantJobApplicationPoco poco in items)
            {
                cmd.CommandText = @"DELETE FROM [dbo].[Applicant_Job_Applications]
                WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", poco.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Update(params ApplicantJobApplicationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(BaseAdo.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            foreach (ApplicantJobApplicationPoco poco in items)
            {
                cmd.CommandText = @"UPDATE [dbo].[Applicant_Job_Applications]
                   SET [Id] = @Id
                      ,[Applicant] = @Applicant
                      ,[Job] = @Job
                      ,[Application_Date] = @Application_Date
                 WHERE Id=@Id";

                cmd.Parameters.AddWithValue("@Id", poco.Id);
                cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                cmd.Parameters.AddWithValue("@Job", poco.Job);
                cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
                
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
