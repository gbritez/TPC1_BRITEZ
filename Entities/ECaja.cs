using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ECaja
    {
        private decimal _sueldo;

        public decimal sueldo
        {
            get
            {
                return _sueldo;
            }
            set
            {
                _sueldo = value;
            }
        }
    }
}
