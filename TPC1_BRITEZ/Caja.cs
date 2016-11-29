using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entities;
using MetroFramework.Forms;
using MetroFramework;

namespace TPC1_BRITEZ
{
    public partial class Caja : MetroFramework.Forms.MetroForm
    {
        private CajaBusiness business = new CajaBusiness();
        private ProveedorBusiness provBusiness = new ProveedorBusiness();
        private ProductoBusiness prodBusiness = new ProductoBusiness();
        private SetCaja setCaja = new SetCaja();
        private EProducto productoVenta = new EProducto();
        private List<EProducto> ventaList = new List<EProducto>();
       

        public Caja()
        {
            InitializeComponent();
        }
        private void FormatGridHistorico(DataGridView grid)
        {
            grid.Columns[0].HeaderText = "N° de operación";
            grid.Columns[1].HeaderText = "Descripción";
            grid.Columns[2].HeaderText = "Cantidad";
            grid.Columns[3].HeaderText = "Precio";
            grid.Columns[4].HeaderText = "Total";
            grid.Columns[5].HeaderText = "Fecha";

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var productoList = new List<EProducto>();
                var producto = new EProducto();
                producto.id = int.Parse(txtId.Text);
                producto.marca = txtMarca.Text;
                producto.tipo = txtTipo.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.precio = Convert.ToDecimal(txtPrecio.Text);
                producto.precioUnitario = Convert.ToDecimal(txtPrecio.Text);
                producto.idProveedor = (int)cmbProveedor.SelectedValue;
                productoList.Add(producto);
                business.Transaccion(productoList, true, Convert.ToDecimal(lblSaldo.Text));

            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProveedor.DataSource = provBusiness.getAll();
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "ID";
                lblSaldo.Text = business.GetSaldo().ToString();
                metroGrid2.DataSource = business.GetHistorico("COMPRA_HISTORICO");
                metroGrid3.DataSource = business.GetHistorico("VENTA_HISTORICO");
                FormatGridHistorico(metroGrid2);
                FormatGridHistorico(metroGrid3);
                VentasGrid.DataSource = prodBusiness.GetAll();
           
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }

        }

        private void btnAceptarVenta_Click(object sender, EventArgs e)
        {
            try
            {

                business.Transaccion(ventaList, false, Convert.ToDecimal(lblSaldo.Text));
                ventaList.Clear();
                VentasGrid.DataSource = prodBusiness.GetAll();

            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abro un form para fijar el importe inicial de la caja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaja_Click(object sender, EventArgs e)
        {
            setCaja.ShowDialog();
        }

        private void btnLimpiarCompra_Click(object sender, EventArgs e)
        {

        }

        private void carroBtn_Click(object sender, EventArgs e)
        {
            try { 
            productoVenta = (EProducto)VentasGrid.CurrentRow.DataBoundItem;
            var form = new SetCantidadForm(ref productoVenta);
            form.ShowDialog();
            if(productoVenta.Cantidad != 0)
            {
                ventaList.Add(productoVenta);
            }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(Owner, ex.Message, "Error");
            }

        }

        private void verCarroBtn_Click(object sender, EventArgs e)
        {
            var form = new CarroGrid(ref ventaList);
            form.ShowDialog();
        }
    }
}
