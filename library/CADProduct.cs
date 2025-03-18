using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library
{
    public class CADProduct
    {
        private string s;

        // Inicializa la cadena de conexión de la BD.
        public CADProduct()
        {
            this.s = "data source=(LocalDB)\\MSSQLLocalDB;Integrated Security=SSPI;" +
                     "AttachDBFilename=|DataDirectory|\\Database.mdf";
        }

        public bool Create(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    string query = "INSERT INTO Product (code, name, amount, price, category, creationDate) " +
                                   "VALUES (@code, @name, @amount, @price, @category, @creationDate)";
                    using (SqlCommand com = new SqlCommand(query, c))
                    {
                        com.Parameters.AddWithValue("@code", en.Code);
                        com.Parameters.AddWithValue("@name", en.Name);
                        com.Parameters.AddWithValue("@amount", en.Amount);
                        com.Parameters.AddWithValue("@price", en.Price);
                        com.Parameters.AddWithValue("@category", en.Category);
                        com.Parameters.AddWithValue("@creationDate", en.CreationDate);
                        com.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Update(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    string query = "UPDATE Product SET name=@name, amount=@amount, price=@price, category=@category, " +
                                   "creationDate=@creationDate WHERE code=@code";
                    using (SqlCommand com = new SqlCommand(query, c))
                    {
                        com.Parameters.AddWithValue("@code", en.Code);
                        com.Parameters.AddWithValue("@name", en.Name);
                        com.Parameters.AddWithValue("@amount", en.Amount);
                        com.Parameters.AddWithValue("@price", en.Price);
                        com.Parameters.AddWithValue("@category", en.Category);
                        com.Parameters.AddWithValue("@creationDate", en.CreationDate);
                        com.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Delete(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    string query = "DELETE FROM Product WHERE code = @code";
                    using (SqlCommand com = new SqlCommand(query, c))
                    {
                        com.Parameters.AddWithValue("@code", en.Code);
                        com.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Read(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    string query = "SELECT * FROM Product WHERE code = @code";
                    using (SqlCommand com = new SqlCommand(query, c))
                    {
                        com.Parameters.AddWithValue("@code", en.Code);
                        using (SqlDataReader dr = com.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                en.Name = dr["name"].ToString();
                                en.Amount = Convert.ToInt32(dr["amount"]);
                                en.Price = Convert.ToSingle(dr["price"]);
                                en.Category = Convert.ToInt32(dr["category"]);
                                en.CreationDate = Convert.ToDateTime(dr["creationDate"]);
                                return true;
                            }
                        }
                    }
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ReadFirst(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    using (SqlCommand com = new SqlCommand("SELECT TOP 1 * FROM Product ORDER BY code", c))
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
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
                    }
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ReadNext(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    using (SqlCommand com = new SqlCommand("SELECT TOP 1 * FROM Product WHERE code > @code ORDER BY code", c))
                    {
                        com.Parameters.AddWithValue("@code", en.Code);
                        using (SqlDataReader dr = com.ExecuteReader())
                        {
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
                        }
                    }
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ReadPrev(ENProduct en)
        {
            using (SqlConnection c = new SqlConnection(s))
            {
                try
                {
                    c.Open();
                    using (SqlCommand com = new SqlCommand("SELECT TOP 1 * FROM Product WHERE code < @code ORDER BY code DESC", c))
                    {
                        com.Parameters.AddWithValue("@code", en.Code);
                        using (SqlDataReader dr = com.ExecuteReader())
                        {
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
                        }
                    }
                    return false;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
