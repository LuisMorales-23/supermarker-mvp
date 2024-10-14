using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products(@name,@price,@stock,@id)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsModel.Categories_Id;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Products_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = (int)reader["Products_Price"];
                        productsModel.Stock = (int)reader["Products_Stock"];
                        productsModel.Categories_Id = (int)reader["Categories_Id"];
                        productsList.Add(productsModel);

                    }
                }
            }

            return productsList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                      WHERE Products_Id=@id or Products_Name LIKE @name+ '%'
                                      ORDER By Products_Id DESC";

                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = (int)reader["Products_Price"];
                        productsModel.Stock = (int)reader["Products_Stock"];
                        productsModel.Categories_Id = (int)reader["Categories_Id"];
                        productsList.Add(productsModel);
                    }
                }

            }
            return productsList;
        }
    }
}
