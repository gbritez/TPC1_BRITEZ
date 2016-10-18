using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EProveedor
    {
        private int _id;
        private string _nombre;
        private long _cuit;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Nombre
        {

            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public long Cuit
        {

            get
            {
                return _cuit;
            }
            set
            {
                _cuit = value;
            }
        }

    }
}
