using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class ETipos
    {
        private int _id;
        private string _descripcion;

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

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
    }
}
