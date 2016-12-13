using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using System.Text.RegularExpressions;

namespace TPC1_BRITEZ
{
    public partial class ABM : MetroFramework.Forms.MetroForm
    {
        protected Validaciones validacion = new Validaciones();
        public ABM()
        {
            InitializeComponent();
        }

        public void Log(string text)
        {
            // Defino el path de salida del archivo de texto
            string mydocpath = AppDomain.CurrentDomain.BaseDirectory;

            // Escribe a un archivo de texto
            File.WriteAllText(mydocpath + @"\Log.txt", text);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
