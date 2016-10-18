using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;


namespace Services
{
    public class LoginService
    {
        public bool Login(EUsuario User)
        {
            var cnxstring = System.Configuration.ConfigurationManager.ConnectionStrings["Base"].ToString();
            var query = "SELECT * From USUARIOS";

            try
            {
                using (var connection = new SqlConnection(cnxstring))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if(User.user == reader.GetValue(0).ToString() && User.password == reader.GetValue(1).ToString() )
                            {
                                return true;
                            }
                        }
                        connection.Close();
                        command.Dispose();
                    }
                }
                 
            }
            catch (Exception ex)
            {
                throw ex;               
            }

            return false;
        }
    }
}
