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

        public List<ECliente> GetAll()
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
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var cliente = new ECliente();
                            cliente.Id = Convert.ToInt16(reader.GetValue(0));
                            cliente.Nombre = reader.GetValue(1).ToString();
                            cliente.Cuil = Convert.ToInt64(reader.GetValue(2));
                            cliente.Dni = Convert.ToInt64(reader.GetValue(3));
                            cliente.Domicilio = reader.GetValue(4).ToString();
                            cliente.Telefono = Convert.ToInt64(reader.GetValue(5));
                            lista.Add(cliente);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insert()
        {

        }
    }
}
