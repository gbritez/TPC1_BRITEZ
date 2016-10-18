using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace Services
{
    public class ProductoService

    {
        string cnx = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();

        public List<EProducto> getAll()
        {
            var lista = new List<EProducto>();           
            var query = "SELECT * FROM PRODUCTO";
            try
            {
                using (var connection = new SqlConnection(cnx))                  
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            var Producto = new EProducto();
                            Producto.id = Convert.ToInt16(reader.GetValue(0));
                            Producto.tipo = reader.GetValue(2).ToString();
                            Producto.marca = reader.GetValue(1).ToString();
                            Producto.precio = Convert.ToDecimal(reader.GetValue(3));
                            Producto.stock = Convert.ToInt16(reader.GetValue(4));
                            Producto.stockMinimo = Convert.ToInt16(reader.GetValue(5));
                            Producto.idProveedor = Convert.ToInt16(reader.GetValue(6));
                            lista.Add(Producto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }


        public void Insert ( EProducto producto, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    var query = "INSERT INTO PRODUCTO (TIPO,MARCA,PRECIO,STOCK,STOCKMINIMO,IDPROVEEDOR) VALUES (@pTIPO,@pMARCA,@pPRECIO,@pSTOCK,@pSTOCKMINIMO,@pIDPROVEEDOR)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pTIPO",producto.tipo);
                        cmd.Parameters.AddWithValue("@pMARCA", producto.marca);
                        cmd.Parameters.AddWithValue("@pPRECIO", producto.precio);
                        cmd.Parameters.AddWithValue("@pSTOCK", producto.stock);
                        cmd.Parameters.AddWithValue("@pSTOCKMINIMO", producto.stockMinimo);
                        cmd.Parameters.AddWithValue("@pIDPROVEEDOR", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
