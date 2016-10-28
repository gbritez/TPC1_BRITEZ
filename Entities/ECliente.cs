﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ECliente
    {
        private int _id;
        private string _nombre;
        private long _cuil;
        private long _dni;
        private string _domicilio;
        private long _telefono;

        #region Propiedades
        public int Id
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

        public long Cuil
        {
            get
            {
                return _cuil;
            }
            set
            {
                _cuil = value;
            }
        }

        public long Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
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
        #endregion
    }
}
