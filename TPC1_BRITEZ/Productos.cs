using Entities;
using Business;
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
    public partial class Productos : ABM
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            var business = new ProductoBusiness();
            var provBusiness = new ProveedorBusiness();
            try
            {
                cmbProveedor.DataSource = provBusiness.getAll();
                cmbProveedor.DisplayMember = "Nombre";
                var lista = business.getAll();
                dataGridView1.DataSource = lista;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


    }
}
