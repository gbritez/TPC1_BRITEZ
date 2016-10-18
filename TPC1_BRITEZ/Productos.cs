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
        private ProductoBusiness business = new ProductoBusiness();
        private ProveedorBusiness provBusiness = new ProveedorBusiness();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProveedor.DataSource = provBusiness.getAll();
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "ID"; 
                var lista = business.getAll();
                dataGridView1.DataSource = lista;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var producto = new EProducto();
            producto.tipo = txtTipo.Text;
            producto.marca = txtMarca.Text;
            producto.precio = Convert.ToDecimal(txtPrecio.Text);
            producto.stock = Convert.ToInt32(txtStock.Text);
            producto.stockMinimo = Convert.ToInt32(txtStockMin.Text); 
            try
            {
                business.Insert(producto, (int)cmbProveedor.SelectedValue);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
