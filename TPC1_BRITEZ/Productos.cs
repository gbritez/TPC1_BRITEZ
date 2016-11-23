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
using MetroFramework;
using MetroFramework.Forms;

namespace TPC1_BRITEZ
{
    public partial class Productos : ABM
    {
        private ProductoBusiness business = new ProductoBusiness();
        private ProveedorBusiness provBusiness = new ProveedorBusiness();
        private void LoadGrid ()
        {
            var lista = business.GetAll();
            dataGridView1.DataSource = lista;
            dataGridView1.Columns[0].HeaderText = "Marca";
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "ID Producto";
            dataGridView1.Columns[3].HeaderText = "Precio";
            dataGridView1.Columns[4].HeaderText = "Precio Unitario";
            dataGridView1.Columns[5].HeaderText = "Stock";
            dataGridView1.Columns[6].HeaderText = "Stock Mínimo";
            dataGridView1.Columns[7].Visible = false;
        }
        private void cargarCombo()
        {
            cmbFiltro.Items.Add("MARCA");
            cmbFiltro.Items.Add("TIPO");
            cmbFiltro.Items.Add("PRECIO");
            cmbFiltro.Items.Add("STOCK");
            cmbFiltro.Items.Add("PRECIO UNITARIO");
            cmbFiltro.Items.Add("STOCK MINIMO");
            cmbFiltro.SelectedIndex = 0;
        }
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombo();
                cmbProveedor.DataSource = provBusiness.getAll();
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "ID";
                LoadGrid();
                
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var producto = new EProducto();
            producto.tipo = txtTipo.Text;
            producto.marca = txtMarca.Text;
            producto.precio = Convert.ToDecimal(txtPrecio.Text);
            producto.precioUnitario = Convert.ToDecimal(txtPrecio.Text);
            producto.stock = Convert.ToInt32(txtStock.Text);
            producto.stockMinimo = Convert.ToInt32(txtStockMin.Text);
            producto.idProveedor = (int)cmbProveedor.SelectedValue;
            try
            {
                business.Insert(producto);
                dataGridView1.DataSource = business.GetAll();
                
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var filter = cmbFiltro.SelectedText;
            var busqueda = txtFiltro.Text;
            try
            {
                
            }
            catch ( Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }
        }
    }
}
