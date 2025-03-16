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

namespace library
{
    public class CADProduct
    {
        
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
                SqlCommand com = new SqlCommand();
            }
        }

        //Actualiza los datos de un producto en
        //la BD con los datos del producto representado por el parámetro en.
        public bool Update(ENProduct en)
        {

        }

        //Borra el producto representado en en de la BD.
        public bool Delete(ENProduct en)
        {

        }

        //Devuelve solo el producto indicado leído de la BD. 
        public bool Read(ENProduct en)
        {

        }

        //Devuelve solo el primer producto de la BD
        public bool ReadFirst(ENProduct en)
        {

        }

        //Devuelve solo el producto siguiente al indicado.
        public bool ReadNext(ENProduct en)
        {

        }

        //Devuelve solo el producto anterior al indicado.
        public bool ReadPrev(ENProduct en)
        {

        }
    }
}
