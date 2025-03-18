using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Reflection.Emit;

namespace library
{
    public class CADProduct
    {
        private string s;

        //Inicializa la cadena de conexión de la BD.
        public CADProduct()
        {
            string s = "data source=(LocalDBD)/MSSQLLocalDB;Integrated" +
                "Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf";
        }

        //Crea un nuevo producto en la BD con
        //los datos del producto representado por el parámetro en.
        public bool Create(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);

            try
            {
                c.Open();
                string query = "INSERT INTO Product (code, name, amount, price, category, creationDate) " +
                               "VALUES (@code, @name, @amount, @price, @category, @creationDate)";
                SqlCommand com = new SqlCommand(query, c);
                com.Parameters.AddWithValue("@code", en.Code);
                com.Parameters.AddWithValue("@name", en.Name);
                com.Parameters.AddWithValue("@amount", en.Amount);
                com.Parameters.AddWithValue("@price", en.Price);
                com.Parameters.AddWithValue("@category", en.Category);
                com.Parameters.AddWithValue("@creationDate", en.CreationDate);
                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        //Actualiza los datos de un producto en
        //la BD con los datos del producto representado por el parámetro en.
        public bool Update(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);

            try
            {
                c.Open();
                string query = "UPDATE Product SET name = @name, amount = @amount, price = @price, category = @category, " +
                               "creationDate = @creationDate WHERE code = @code";
                SqlCommand com = new SqlCommand(query, c);
                com.Parameters.AddWithValue("@code", en.Code);
                com.Parameters.AddWithValue("@name", en.Name);
                com.Parameters.AddWithValue("@amount", en.Amount);
                com.Parameters.AddWithValue("@price", en.Price);
                com.Parameters.AddWithValue("@category", en.Category);
                com.Parameters.AddWithValue("@creationDate", en.CreationDate);
                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        //Borra el producto representado en en de la BD.
        public bool Delete(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);

            try
            {
                c.Open();
                string query = "DELETE FROM Product WHERE code = @code";
                SqlCommand com = new SqlCommand(query, c);

                com.Parameters.AddWithValue("@code", en.Code);
                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        //Devuelve solo el producto indicado leído de la BD. 
        public bool Read(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);

            try
            {
                c.Open();
                string query = "SELECT * FROM Product WHERE code = @code";
                SqlCommand com = new SqlCommand(query, c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    en.Name = dr["name"].ToString();
                    en.Amount = Convert.ToInt32(dr["amount"]);
                    en.Price = Convert.ToSingle(dr["price"]);
                    en.Category = Convert.ToInt32(dr["category"]);
                    en.CreationDate = Convert.ToDateTime(dr["creationDate"]);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        //Devuelve solo el primer producto de la BD
        public bool ReadFirst(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT TOP 1 * FROM Product ORDER BY code", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Code = dr["code"].ToString();
                    en.Name = dr["name"].ToString();
                    en.Amount = Convert.ToInt32(dr["amount"]);
                    en.Price = Convert.ToSingle(dr["price"]);
                    en.Category = Convert.ToInt32(dr["category"]);
                    en.CreationDate = Convert.ToDateTime(dr["creationDate"]);
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        //Devuelve solo el producto siguiente al indicado.
        public bool ReadNext(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Product WHERE code > @code ORDER BY code", c);
                com.Parameters.AddWithValue("@code", en.Code);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Code = dr["code"].ToString();
                    en.Name = dr["name"].ToString();
                    en.Amount = Convert.ToInt32(dr["amount"]);
                    en.Price = Convert.ToSingle(dr["price"]);
                    en.Category = Convert.ToInt32(dr["category"]);
                    en.CreationDate = Convert.ToDateTime(dr["creationDate"]);
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        //Devuelve solo el producto anterior al indicado.
        public bool ReadPrev(ENProduct en)
        {
            SqlConnection c = new SqlConnection(s);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Product WHERE code < @code ORDER BY code DESC", c);
                com.Parameters.AddWithValue("@code", en.Code);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Code = dr["code"].ToString();
                    en.Name = dr["name"].ToString();
                    en.Amount = Convert.ToInt32(dr["amount"]);
                    en.Price = Convert.ToSingle(dr["price"]);
                    en.Category = Convert.ToInt32(dr["category"]);
                    en.CreationDate = Convert.ToDateTime(dr["creationDate"]);
                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }

        }
    }
}
