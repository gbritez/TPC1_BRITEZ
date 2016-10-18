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

namespace TPC1_BRITEZ
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var LoginBusiness = new LoginBusiness();
            var Usuario = new EUsuario();
            var menu = new MainMenu();
            Usuario.user = txtUser.Text.Trim();
            Usuario.password = txtPassword.Text.Trim();
            try
            {
                if(LoginBusiness.Login(Usuario))
                {
                    menu.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
