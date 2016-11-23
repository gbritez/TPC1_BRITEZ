using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
namespace Services
{
    public class ProveedorService
    {
        string Conn = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();
        public List<EProveedor> getAll()
        {
            var Lista = new List<EProveedor>();
            var QUERY = "GETPROVEEDORES";
            try
            {
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    using (SqlCommand comm = new SqlCommand(QUERY, connection))
                    {
                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            var prov = new EProveedor();
                            prov.ID = Convert.ToInt32(reader.GetValue(0));
                            prov.Nombre = Convert.ToString(reader.GetValue(1));
                            prov.Cuit = Convert.ToInt64(reader.GetValue(2));
                            Lista.Add(prov);                          
                        }
                        return Lista;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
     
        }
        public void Insert (EProveedor proveedor)
        {
            try
            {
                var query = "INSERT INTO PROVEEDOR (NOMBRE,CUIT,TELEFONO,DOMICILIO) VALUES (@pNOMBRE,@pCUIT,@pTELEFONO,@pDOMICILIO)";
                using (SqlConnection connection = new SqlConnection(Conn))
                {
                    connection.Open();
                    using (SqlCommand comm = new SqlCommand(query, connection))
                    {
                        comm.Parameters.AddWithValue("@pNOMBRE", proveedor.Nombre);
                        comm.Parameters.AddWithValue("@pCUIT", proveedor.Cuit);
                        comm.Parameters.AddWithValue("@pTELEFONO", proveedor.Telefono);
                        comm.Parameters.AddWithValue("@pDOMICILIO", proveedor.Domicilio);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Update(EProveedor proveedor)
        {

        }
       
    }
}
