using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EUsuario
    {
        private string _user;
        private string _password;

        public string user
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
        public string password
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
    }
}
