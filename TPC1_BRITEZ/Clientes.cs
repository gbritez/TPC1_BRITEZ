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
using MetroFramework;
namespace TPC1_BRITEZ
{   
    public partial class Clientes : ABM
    {
        private ClienteBusiness business = new ClienteBusiness();
        private ECliente cliente = new ECliente();
        private void cargarCombo()
        {
            cmbFiltro.Items.Add("NOMBRE");
            cmbFiltro.Items.Add("CUIL");
            cmbFiltro.Items.Add("DNI");
            cmbFiltro.Items.Add("DOMICILIO");
            cmbFiltro.Items.Add("TELEFONO");
            cmbFiltro.SelectedIndex = 0;
        }
        public Clientes()
        {
            InitializeComponent();
        }
        private void Map()
        {
            cliente.CUIL = Convert.ToInt64(txtCUIL.Text);
            cliente.DNI = Convert.ToInt64(txtDNI.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Telefono = Convert.ToInt64(txtTelefono.Text);
            cliente.Domicilio = txtDomicilio.Text;
        }
        private void Validar()
        {
            validacion.ValidateText(txtNombre.Text, txtNombre.AccessibleName);
            validacion.CheckIfEmpty(txtDomicilio.Text, txtDomicilio.AccessibleName);
            validacion.ValidateNumbers(txtDNI.Text, txtDNI.AccessibleName);
            validacion.ValidateNumbers(txtCUIL.Text, txtCUIL.AccessibleName);
            validacion.ValidateNumbers(txtTelefono.Text, txtTelefono.AccessibleName);
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarCombo();
            metroGrid1.DataSource = business.GetAll();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                Map();
                business.Insert(cliente);
                cliente = new ECliente();

                MetroMessageBox.Show(Owner, "Cliente ingresado con éxito.");
            }
            catch (Exception ex)
            {

               MetroMessageBox.Show(Owner, ex.Message);
            }
            
        }
    }
}
