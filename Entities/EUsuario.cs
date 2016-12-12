using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class EUsuario
    {
        private static string _user;
        private static string _password;
        private static string _tipo;

        public static string user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
        public static string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public static string tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }
    }
}
