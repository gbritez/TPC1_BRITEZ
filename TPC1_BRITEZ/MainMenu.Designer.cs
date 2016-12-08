namespace TPC1_BRITEZ
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnProductos = new MetroFramework.Controls.MetroButton();
            this.btnProveedores = new MetroFramework.Controls.MetroButton();
            this.btnClientes = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.btnCaja = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Location = new System.Drawing.Point(82, 102);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(128, 120);
            this.btnProductos.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.btnProductos, "Productos");
            this.btnProductos.UseSelectable = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.BackgroundImage")));
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Location = new System.Drawing.Point(232, 102);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(128, 120);
            this.btnProveedores.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.btnProveedores, "Proveedores");
            this.btnProveedores.UseSelectable = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Location = new System.Drawing.Point(13, 262);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(128, 120);
            this.btnClientes.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.btnClientes, "Clientes");
            this.btnClientes.UseSelectable = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton5.BackgroundImage")));
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton5.Location = new System.Drawing.Point(310, 262);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(128, 120);
            this.metroButton5.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.metroButton5, "Salir");
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaja.BackgroundImage")));
            this.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.Location = new System.Drawing.Point(163, 262);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(128, 120);
            this.btnCaja.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.btnCaja, "Caja");
            this.btnCaja.UseSelectable = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 429);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProductos);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnProductos;
        private MetroFramework.Controls.MetroButton btnProveedores;
        private MetroFramework.Controls.MetroButton btnClientes;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton btnCaja;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

