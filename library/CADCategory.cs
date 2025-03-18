using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace library
{
    public class CADCategory
    {
        private string s;

        public CADCategory() 
        {
            s = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool read(ENCategory en)
        {
            bool e = false;
            SqlConnection sqlConnection = new SqlConnection(s);
            try
            {
                sqlConnection.Open();
                string query = "Select * from Categories where id = @id";
                SqlCommand com = new SqlCommand(query, sqlConnection);
                com.Parameters.AddWithValue("@id", en.Id);

                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read()) 
                {
                    en.Name = dr["name"].ToString();
                    e = true;
                }

                sqlConnection.Close();
            }
            catch (Exception ex) 
            {
                e = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }

            return e;
        }
        public List<ENCategory> ReadAll()
        {
            List<ENCategory> categories = new List<ENCategory>();
            SqlConnection sqlConnection = new SqlConnection(s);

            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Categories";
                SqlCommand com = new SqlCommand(query, sqlConnection);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ENCategory category = new ENCategory();
                    category.Id = Convert.ToInt32(dr["id"]);
                    category.Name = dr["name"].ToString();
                    categories.Add(category);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en readAll(): " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return categories;
        }
    }
}
