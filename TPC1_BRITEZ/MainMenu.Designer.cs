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
            this.btnProductos = new MetroFramework.Controls.MetroButton();
            this.btnProveedores = new MetroFramework.Controls.MetroButton();
            this.btnClientes = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(39, 107);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(128, 120);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(162, 107);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(128, 120);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(286, 107);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(128, 120);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(39, 233);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(128, 120);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "CAJA";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(162, 233);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(128, 120);
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "SALIR";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 429);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
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
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}

