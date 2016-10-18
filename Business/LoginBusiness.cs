using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Business
{
    public class LoginBusiness
    {
        public bool validarCampos(string usuario, string password)
        {
            return false;
        }

        public bool Login (EUsuario User)
        {
            var LogService = new LoginService();
            try
            {
                if (LogService.Login(User))
                {
                    return true;    
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
