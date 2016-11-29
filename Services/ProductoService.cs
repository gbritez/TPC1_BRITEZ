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

        private bool ValidateStock(int id, int cantidad)
        {
            var QUERY = "SELECT * FROM PRODUCTO WHERE ID = " + id.ToString();
            try
            {
                using (var connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(QUERY, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToInt16(reader.GetValue(0)) == id)
                            {
                                var stockMin = Convert.ToInt16(reader.GetValue(5));
                                var stock = Convert.ToInt16(reader.GetValue(4));
                                if (stock - cantidad < stockMin)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return true;
        }
        public bool CheckIfExists(int id)
        {
            var QUERY = "GETPRODUCTOS";
            try
            {
                using (var connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(QUERY, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToInt16(reader.GetValue(0)) == id)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public List<EProducto> GetAll()
        {
            var lista = new List<EProducto>();
            var query = "GETPRODUCTOS";
            try
            {
                using (var connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var Producto = new EProducto();
                            Producto.id = Convert.ToInt16(reader.GetValue(0));
                            Producto.tipo = reader.GetValue(2).ToString();
                            Producto.marca = reader.GetValue(1).ToString();
                            Producto.precio = Convert.ToDecimal(reader.GetValue(3));
                            Producto.precioUnitario = Convert.ToDecimal(reader.GetValue(7));
                            Producto.stock = Convert.ToInt16(reader.GetValue(4));
                            Producto.stockMinimo = Convert.ToInt16(reader.GetValue(5));
                            //Producto.idProveedor = Convert.ToInt16(reader.GetValue(6));
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
        public EProducto GetByID(int id)
        {
            var query = "SELECT * FROM PRODUCTO WHERE ID = " +id.ToString();
            try
            {
                var Producto = new EProducto();
                using (var connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                          
                            Producto.id = Convert.ToInt16(reader.GetValue(0));
                            Producto.tipo = reader.GetValue(2).ToString();
                            Producto.marca = reader.GetValue(1).ToString();
                            Producto.precio = Convert.ToDecimal(reader.GetValue(3));
                            Producto.precioUnitario = Convert.ToDecimal(reader.GetValue(7));
                            Producto.stock = Convert.ToInt16(reader.GetValue(4));
                            Producto.stockMinimo = Convert.ToInt16(reader.GetValue(5));
                            //Producto.idProveedor = Convert.ToInt16(reader.GetValue(6));
                            return Producto;
                        }
                    }
                }
                throw new Exception("El producto no existe.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public void Insert(EProducto producto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    var query = "INSERT INTO PRODUCTO (TIPO,MARCA,PRECIO,STOCK,STOCKMINIMO,IDPROVEEDOR,PRECIO_UNITARIO) VALUES (@pTIPO,@pMARCA,@pPRECIO,@pSTOCK,@pSTOCKMINIMO,@pIDPROVEEDOR,@pPRECIO_UNITARIO)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pTIPO", producto.tipo);
                        cmd.Parameters.AddWithValue("@pMARCA", producto.marca);
                        cmd.Parameters.AddWithValue("@pPRECIO", producto.precio);
                        cmd.Parameters.AddWithValue("@pSTOCK", producto.Cantidad);
                        cmd.Parameters.AddWithValue("@pSTOCKMINIMO", producto.stockMinimo);
                        cmd.Parameters.AddWithValue("@pIDPROVEEDOR", producto.idProveedor);
                        cmd.Parameters.AddWithValue("@pPRECIO_UNITARIO", producto.precio);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Update(IList<EProducto> Producto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    var QUERY = "UPDATE PRODUCTO(TIPO,MARCA,PRECIO,STOCK,STOCKMINIMO,IDPROVEEDOR) VALUES (@pTIPO,@pMARCA,@pPRECIO,@pSTOCK,@pSTOCKMINIMO,@pIDPROVEEDOR)";
                    using (SqlCommand cmd = new SqlCommand(QUERY, connection))
                    {
                        foreach (EProducto producto in Producto) { 
                        cmd.Parameters.AddWithValue("@pTIPO", producto.tipo);
                        cmd.Parameters.AddWithValue("@pMARCA", producto.marca);
                        cmd.Parameters.AddWithValue("@pPRECIO", producto.precio);
                        cmd.Parameters.AddWithValue("@pSTOCK", producto.stock);
                        cmd.Parameters.AddWithValue("@pSTOCKMINIMO", producto.stockMinimo);
                        cmd.Parameters.AddWithValue("@pIDPROVEEDOR", producto.idProveedor);
                        cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateStock(int id, int cantidad, bool ban)
        {          
            var QUERY = "UPDATE PRODUCTO SET STOCK " + (ban ? "+" : "-") + "= " + cantidad.ToString() + " FROM PRODUCTO WHERE ID = " + id.ToString();
            try
            {
                if (!ban)
                {
                    if (!ValidateStock(id, cantidad))
                    {
                        throw new Exception("La cantidad a vender supera el stock disponible.");
                    }
                }
                using (var connection = new SqlConnection(cnx))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(QUERY, connection))
                    {
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
