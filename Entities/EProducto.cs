using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EProducto
    {
        private string _marca;
        private string _tipo;
        private int _id;
        private decimal _precio;
        private decimal _precioUnitario;
        private int _stock;
        private int _stockMinimo;
        private int _idProveedor;
        private int _cantidad;
        #region Propiedades
        public string marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        public string tipo
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

        public int id
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

        public decimal precioUnitario
        {
            get
            {
                return _precioUnitario;
            }
            set
            {
                _precioUnitario = decimal.Multiply(value,Convert.ToDecimal(1.15));
            }
        }

        public int stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }

        public int stockMinimo
        {
            get
            {
                return _stockMinimo;
            }
            set
            {
                _stockMinimo = value;
            }
        }

        public int idProveedor
        {
            get
            {
                return _idProveedor;
            }
            set
            {
                _idProveedor = value;
            }
        }
        public int Cantidad
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
        #endregion
    }
}
