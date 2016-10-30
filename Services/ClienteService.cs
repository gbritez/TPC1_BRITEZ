using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace Services
{
    public class ClienteService
    {
        string CONNECTION = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();

        public List<ECliente> getAll()
        {
            var lista = new List<ECliente>();
            try
            {
                var QUERY = "SELECT * FROM CLIENTE";
                using (SqlConnection cnx = new SqlConnection(CONNECTION))
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand(QUERY, cnx))
                    {

                    }
                }
                    return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insert ()
        {

        }
    }
}
