﻿using System;
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
using Business;
using Entities;

namespace TPC1_BRITEZ
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private LoginBusiness loginBusiness = new LoginBusiness();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
  
            var menu = new MainMenu();
            EUsuario.user = txtUser.Text.Trim();
            EUsuario.password = txtPassword.Text.Trim();
            try
            {
                if(loginBusiness.Login())
                {
                    menu.Show();
                    this.Hide();
                    
                }
            }
            
            catch (Exception ex)
            {
                
                MetroMessageBox.Show(Owner,ex.Message,"Error");
            }
        }
    }
}
