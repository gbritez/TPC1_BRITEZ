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
        private long _telefono;
        private string _domicilio;

        #region Propiedades
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

        public long Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return _domicilio;
            }
            set
            {
                _domicilio = value;
            }
        }
        #endregion
    }
}
