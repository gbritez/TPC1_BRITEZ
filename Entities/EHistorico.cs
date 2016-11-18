using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class EHistorico
    {
        private int _nOperacion;
        private string _descripcion;
        private int _cantidad;
        private decimal _precio;
        private decimal _total;
        private DateTime _fecha;

        public int nOperacion
        {
            get
            {
                return _nOperacion;
            }
            set
            {
                _nOperacion = value;
            }
        }

        public string descripcion
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

        public int cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }

        public decimal precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public decimal total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

        public DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
    }
}
