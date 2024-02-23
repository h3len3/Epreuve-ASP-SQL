using DAL_Epreuve_hd.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve_hd.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL_Epreuve_hd.Services
{
    public class CategoryService : BaseService, ICategoryRepository<string>
    {
        public CategoryService(IConfiguration configuration) : base(configuration, "Epreuve-hd-DB")
        {
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Category_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader["categoryname"].ToString();
                        }
                    }
                }
            }
        }

        public string Get(string id)
        {
            throw new NotImplementedException();
        }

        public string Insert(string entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string entity)
        {
            throw new NotImplementedException();
        }
    }
}
