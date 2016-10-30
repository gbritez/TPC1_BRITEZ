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

namespace TPC1_BRITEZ
{   
    public partial class Clientes : ABM
    {
        private ClienteBusiness business = new ClienteBusiness();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
