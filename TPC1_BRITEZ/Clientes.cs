﻿using System;
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarCombo();
            metroGrid1.DataSource = business.GetAll();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cliente.CUIL = Convert.ToInt64(txtCUIL.Text);
            cliente.DNI = Convert.ToInt64(txtDNI.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Telefono = Convert.ToInt64(txtTelefono.Text);
            cliente.Domicilio = txtDomicilio.Text;
            business.Insert(cliente);
        }
    }
}
