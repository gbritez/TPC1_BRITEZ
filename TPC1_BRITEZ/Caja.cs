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
        public Caja()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new EProducto();
                producto.id = int.Parse(txtId.Text);
                producto.marca = txtMarca.Text;
                producto.tipo = txtTipo.Text;
                producto.stock = int.Parse(txtCantidad.Text);
                producto.precio = Convert.ToDecimal(txtPrecio.Text);
                producto.precioUnitario = Convert.ToDecimal(txtPrecio.Text);
                producto.idProveedor = (int)cmbProveedor.SelectedValue;
                business.Transaccion(producto, true, Convert.ToDecimal(lblSaldo.Text));

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
                dataGridView1.DataSource = business.GetHistorico("COMPRA_HISTORICO");
                dataGridView2.DataSource = business.GetHistorico("VENTA_HISTORICO");
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

                productoVenta.id = int.Parse(txtIdProductoVenta.Text);
                productoVenta.stock = int.Parse(txtCantidadVenta.Text);
                business.Transaccion(productoVenta, false, Convert.ToDecimal(lblSaldo.Text));

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

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                productoVenta = prodBusiness.GetByID(Convert.ToInt16(txtIdProductoVenta.Text));
                txtDescripcion.Text = productoVenta.marca + " " + productoVenta.tipo;
                txtPrecioVenta.Text = productoVenta.precioUnitario.ToString();
                txtDisponible.Text = productoVenta.stock.ToString();
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(Owner, ex.Message);
            }

        }
    }
}
