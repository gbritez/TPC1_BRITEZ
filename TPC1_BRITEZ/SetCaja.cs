using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Business;

namespace TPC1_BRITEZ
{
    public partial class SetCaja : MetroFramework.Forms.MetroForm
    {
        private CajaBusiness Business = new CajaBusiness();
        private Validaciones validacion = new Validaciones();

        private void Validar()
        {
            validacion.ValidateNumbers(txtImporte.Text, txtImporte.AccessibleName);
        }
        public SetCaja()
        {
            InitializeComponent();
        }

        private void SetCaja_Load(object sender, EventArgs e)
        {
        
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Business.SetSaldo(Convert.ToDecimal(txtImporte.Text));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.Dispose();
            }
        }
    }
}
