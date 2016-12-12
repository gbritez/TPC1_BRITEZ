using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Entities;
using Business;

namespace TPC1_BRITEZ
{
    public partial class Proveedores : ABM
    {
        private ProveedorBusiness business = new ProveedorBusiness();
        private EProveedor proveedor = new EProveedor();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Map()
        {
            proveedor.Nombre = txtNombre.Text;
            proveedor.Cuit = Convert.ToInt64(txtCuit.Text);
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Domicilio = txtDomicilio.Text;
        }
        private void Validar()
        {
            try
            {
                validacion.ValidateNumbers(txtCuit.Text, txtCuit.AccessibleName);
                validacion.ValidateNumbers(txtTelefono.Text, txtTelefono.AccessibleName);
                validacion.ValidateText(txtNombre.Text, txtNombre.AccessibleName);
                validacion.CheckIfEmpty(txtDomicilio.Text, txtDomicilio.AccessibleName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargarCombo()
        {
            cmbFiltro.Items.Add("NOMBRE");
            cmbFiltro.Items.Add("CUIL");
            cmbFiltro.Items.Add("DNI");
            cmbFiltro.Items.Add("DOMICILIO");
            cmbFiltro.Items.Add("TELEFONO");
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                Validar();
                Map();
                business.Insert(proveedor);
                proveedor = new EProveedor();
                MetroMessageBox.Show(Owner,"Proveedor ingresado con éxito.");
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner,ex.Message,"Error");
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombo();
                metroGrid1.DataSource = business.getAll();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var filter = cmbFiltro.SelectedItem.ToString();
            var busqueda = txtFiltro.Text;
            try
            {
                metroGrid1.DataSource = business.GetByFilter(filter, busqueda);
                metroGrid1.Refresh();
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }
        }
    }
}
