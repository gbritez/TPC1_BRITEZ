using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace Services
{
    public class CajaService
    {
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();
        public decimal Get()
        {
            var query = "SELECT * FROM CAJA";
            decimal res = 0;
            try
            {
                using (SqlConnection cnx = new SqlConnection(connection))
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnx))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            res = Convert.ToDecimal(reader.GetValue(0));
                        }
                    }
                }
                return res;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fija el importe para la caja.
        /// </summary>
        /// <param name="importe"></param>
        public void SetSaldoInicial(decimal importe)
        {
            var QUERY = "DELETE FROM CAJA INSERT INTO CAJA VALUES( " + importe.ToString() + " )";
            try
            {
                using (SqlConnection cnx = new SqlConnection(connection))
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand(QUERY, cnx))
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

        public void GrabarHistorico(EHistorico historico, string tabla)
        {
            var QUERY = "INSERT INTO "+ tabla + "(NOPERACION,DESCRIPCION,CANTIDAD,PRECIO_UNITARIO,TOTAL,FECHA) VALUES (@pNOPERACION,@pDESCRIPCION,@pCANTIDAD,@pPRECIO_UNITARIO,@pTOTAL,@pFECHA)";

            try
            {
                using (SqlConnection cnx = new SqlConnection(connection))
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand(QUERY, cnx))
                    {
                        cmd.Parameters.AddWithValue("@pNOPERACION", historico.nOperacion);
                        cmd.Parameters.AddWithValue("@pDESCRIPCION", historico.descripcion);
                        cmd.Parameters.AddWithValue("@pCANTIDAD", historico.cantidad);                       
                        cmd.Parameters.AddWithValue("@pFECHA", historico.fecha);
                        cmd.Parameters.AddWithValue("@pPRECIO_UNITARIO", historico.precio);
                        cmd.Parameters.AddWithValue("@pTOTAL", historico.total );
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EHistorico> GetHistorico(string tabla)
        {
            var QUERY = "SELECT * FROM " + tabla;
            var lista = new List<EHistorico>();
            try
            {
                using (SqlConnection cnx = new SqlConnection(connection))
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand(QUERY,cnx))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var row = new EHistorico();
                            row.nOperacion = Convert.ToInt16(reader.GetValue(0));
                            row.descripcion = reader.GetValue(1).ToString();
                            row.cantidad = Convert.ToInt16(reader.GetValue(2));
                            row.precio = Convert.ToDecimal(reader.GetValue(3));
                            row.total = Convert.ToDecimal(reader.GetValue(4)); 
                            row.fecha = Convert.ToDateTime (reader.GetValue(5));
                            lista.Add(row);

                        }
                    }

                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int GetNextVal(string table)
        {
            var res = 0;
            var QUERY = "SELECT MAX(NOPERACION) + 1 FROM " + table;
            try
            {
                using (SqlConnection cnx = new SqlConnection(connection))
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand(QUERY, cnx))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while(reader.Read())
                        {
                            res = (int)reader.GetValue(0);
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
