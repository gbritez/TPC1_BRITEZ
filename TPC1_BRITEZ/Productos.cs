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
using MetroFramework.Controls;

namespace TPC1_BRITEZ
{
    public partial class Productos : ABM
    {
        private ProductoBusiness business = new ProductoBusiness();
        private ProveedorBusiness provBusiness = new ProveedorBusiness();
        private EProducto producto = new EProducto();
        protected void Validar()
        {
            validacion.ValidateText(txtTipo.Text, txtTipo.AccessibleName);
            validacion.ValidateText(txtMarca.Text, txtMarca.AccessibleName);
            validacion.ValidateNumbers(txtPrecio.Text, txtPrecio.AccessibleName);
            validacion.ValidateNumbers(txtStock.Text,txtStock.AccessibleName);
            validacion.ValidateNumbers(txtStockMin.Text, txtStock.AccessibleName);
        }
        private void Map()
        {
            producto.tipo = txtTipo.Text;
            producto.marca = txtMarca.Text;
            producto.precio = Convert.ToDecimal(txtPrecio.Text);
            producto.precioUnitario = Convert.ToDecimal(txtPrecio.Text);
            producto.stock = Convert.ToInt32(txtStock.Text);
            producto.stockMinimo = Convert.ToInt32(txtStockMin.Text);
            producto.idProveedor = (int)cmbProveedor.SelectedValue;
        }
        private void LoadGrid()
        {
            var lista = business.GetAll();
            metroGrid1.DataSource = lista;
            metroGrid1.Columns[0].HeaderText = "Marca";
            metroGrid1.Columns[1].HeaderText = "Tipo";
            metroGrid1.Columns[2].HeaderText = "ID Producto";
            metroGrid1.Columns[3].HeaderText = "Precio";
            metroGrid1.Columns[4].HeaderText = "Precio Unitario";
            metroGrid1.Columns[5].HeaderText = "Stock";
            metroGrid1.Columns[6].HeaderText = "Stock Mínimo";
            metroGrid1.Columns[7].Visible = false;
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

            try
            {
                Validar();
                Map();
                business.Insert(producto);
                metroGrid1.DataSource = business.GetAll();
                producto = new EProducto();

            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
                producto = new EProducto();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var filter = cmbFiltro.SelectedText;
            var busqueda = txtFiltro.Text;
            try
            {

            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }
        }
    }
}
