using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Services
{
    public class CajaService
    {
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();
        public decimal Get()
        {
            var query = "SELECT * FROM CAJA";
            decimal res =0;
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
            
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void SetSaldo(decimal importe)
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
    }
}
