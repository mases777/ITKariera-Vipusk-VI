﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Zadacha01.Common;

namespace Zadacha01.Data
{
    public class ProductData
    {
        public List<Product> GetAll()
        {
            var productList = new List<Product>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM product", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product
                            (
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetInt32(3)
                            );
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }

        public Product Get(int id)
        {
            Product product = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM product WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                            (
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetInt32(3)
                            );
                    }
                }
            }
            return product;
        }

        public void Add(Product product)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO product (Name, Price, Stock) VALUES (@name, @price, @stock)", connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Product product)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("UPDATE product SET Name=@name, Price=@price, Stock=@stock WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM product WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id.ToString());
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
