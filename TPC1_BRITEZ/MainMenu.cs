using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC1_BRITEZ
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var ProductosForm = new Productos();
            ProductosForm.ShowDialog();
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            var ProveedoresForm = new Proveedores();
            ProveedoresForm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var ClientesForm = new Clientes();
            ClientesForm.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            var CajaForm = new Caja();
            CajaForm.ShowDialog();
        }
    }
}
