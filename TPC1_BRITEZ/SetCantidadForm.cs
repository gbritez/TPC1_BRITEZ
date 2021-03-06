﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Entities;

namespace TPC1_BRITEZ
{
    public partial class SetCantidadForm : MetroFramework.Forms.MetroForm
    {
        private EProducto Producto = new EProducto();
        private Validaciones validacion = new Validaciones();
        private void Validar ()
        {
            validacion.ValidateNumbers(txtCantidad.Text, txtCantidad.AccessibleName);
        }
        public SetCantidadForm(ref EProducto producto)
        {
            InitializeComponent();
            Producto = producto;
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
               Producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
               this.Close();
            }
            catch ( Exception ex)
            {

                throw ex;
            }
        }
    }
}
