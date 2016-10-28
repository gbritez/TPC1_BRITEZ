using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;

namespace TPC1_BRITEZ
{
    public partial class Proveedores : ABM
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var proveedor = new EProveedor();
            var business = new ProveedorBusiness();
            try
            {
                proveedor.Nombre = txtNombre.Text;
                proveedor.Cuit = Convert.ToInt64(txtCuit.Text);
                proveedor.Telefono = Convert.ToInt64(txtTelefono.Text);
                proveedor.Domicilio = txtDomicilio.Text;
                business.Insert(proveedor);
                MessageBox.Show("Proveedor ingresado con éxito.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
