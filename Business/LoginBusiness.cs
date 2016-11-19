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
                else
                {
                    throw new Exception("Usuario o Contraseña inválido/s");
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public List<EProducto> Buscar(string filtro, string busqueda)
        {
            var lista = new List<EProducto>();
            try
            {

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
