using DAL_Epreuve_hd.Services;
using DAL_Epreuve_hd.Mappers;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve_hd.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DAL_Epreuve_hd.Entities;

namespace DAL_Epreuve_hd.Services
{
    public class ProductService : BaseService, IProductRepository<Product>
    {
        public ProductService(IConfiguration configuration) : base(configuration, "Epreuve-hd-DB")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Product_Delete";
                    command.Parameters.AddWithValue("id_product", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0) throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} ne correspond à aucune valeur");
                }
            }
        }

        public IEnumerable<Product> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Product_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduct();
                        }
                    }
                }
            }
        }

        public Product Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Product_GetById";
                    command.Parameters.AddWithValue("Id_Product", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduct();
                        throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} ne correspond à aucune valeur");
                    }
                }
            }
        }

        public int Insert(Product entity)
        {
            
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_Product_Insert";
                        command.Parameters.AddWithValue("name", entity.Name);
                        command.Parameters.AddWithValue("description", entity.Description);
                        command.Parameters.AddWithValue("price", entity.Price);
                        command.Parameters.AddWithValue("ecologicalcriteriaecoScore", entity.EcologicalCriteriaEcoScore);
                        command.Parameters.AddWithValue("categoryname", entity.CategoryName);
                      
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        return (int)command.ExecuteScalar();
                    }
                }            
        }

        public void Update(Product entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Product_Update";
                    command.Parameters.AddWithValue("id_product", entity.Id_Product);
                    command.Parameters.AddWithValue("name", entity.Name);
                    command.Parameters.AddWithValue("description", entity.Description);
                    command.Parameters.AddWithValue("price", entity.Price);
                    command.Parameters.AddWithValue("ecologicalcriteriaecoScore", entity.EcologicalCriteriaEcoScore);
                    command.Parameters.AddWithValue("categoryname", entity.CategoryName);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0) throw new ArgumentOutOfRangeException(nameof(entity.Id_Product), $"L'identifiant {entity.Id_Product} ne correspond à aucune valeur");
                }
            }
        }

        public IEnumerable<Product> GetByCategory(string category)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Product_GetByCategory";
                    command.Parameters.AddWithValue("categoryname", category);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {                      
                         while (reader.Read())
                         {
                                yield return reader.ToProduct();
                          }
                        
                    }
                }
            }
        }

    }
}

