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

namespace TPC1_BRITEZ
{
    public partial class CarroGrid : MetroFramework.Forms.MetroForm
    {
        private List<EProducto> productoList = new List<EProducto>();
        private void RefreshGrid()
        {
            metroGrid1.DataSource = new List<EProducto>();
            metroGrid1.Update();
            metroGrid1.Refresh();
        }
        public CarroGrid(ref List<EProducto> producto)
        {
            productoList = producto;
            InitializeComponent();
        }

        private void CarroGrid_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = productoList;
        }

        private void eliminarTodoBtn_Click(object sender, EventArgs e)
        {
            try
            {

                productoList.Clear();
                RefreshGrid();
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
