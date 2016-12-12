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
                            cliente.ID = Convert.ToInt16(reader.GetValue(0));
                            cliente.Nombre = reader.GetValue(1).ToString();
                            cliente.CUIL = Convert.ToInt64(reader.GetValue(2));
                            cliente.DNI = Convert.ToInt64(reader.GetValue(3));
                            cliente.Domicilio = reader.GetValue(4).ToString();
                            cliente.Telefono = reader.GetValue(5).ToString();
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

        public void Insert(ECliente cliente)
        {
            var QUERY = "INSERT INTO CLIENTE(NOMBRE,CUIL,DNI,DOMICILIO,TELEFONO) VALUES (@pNOMBRE,@pCUIL,@pDNI,@pDOMICILIO,@pTELEFONO)";
            try
            {
                using (SqlConnection cnx = new SqlConnection(CONNECTION))
                {
                    cnx.Open();
                    using(SqlCommand cmd = new SqlCommand(QUERY, cnx))
                    {
                        cmd.Parameters.AddWithValue("@pNOMBRE", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@pCUIL", cliente.CUIL);
                        cmd.Parameters.AddWithValue("@pDNI", cliente.DNI);
                        cmd.Parameters.AddWithValue("@pDOMICILIO", cliente.Domicilio);
                        cmd.Parameters.AddWithValue("@pTELEFONO", cliente.Telefono);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ECliente> GetByFilter(string filter, string busqueda)
        {

            var Lista = new List<ECliente>();
            var query = "SELECT * FROM CLIENTE WHERE " + filter + " LIKE '%" + busqueda + "%'";
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var cliente = new ECliente();
                            cliente.ID = Convert.ToInt16(reader.GetValue(0));
                            cliente.Nombre = reader.GetValue(1).ToString();
                            cliente.CUIL = Convert.ToInt64(reader.GetValue(2));
                            cliente.DNI = Convert.ToInt64(reader.GetValue(3));
                            cliente.Domicilio = reader.GetValue(4).ToString();
                            cliente.Telefono = reader.GetValue(5).ToString();
                            Lista.Add(cliente);
                        }
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
