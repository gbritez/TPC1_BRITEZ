namespace TPC1_BRITEZ
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTipo = new MetroFramework.Controls.MetroTextBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.txtStockMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbProveedor = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            this.metroTabPage1.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(596, 19);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(264, 19);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Location = new System.Drawing.Point(27, 18);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.cmbProveedor);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.txtStockMin);
            this.metroTabPage2.Controls.Add(this.txtStock);
            this.metroTabPage2.Controls.Add(this.txtPrecio);
            this.metroTabPage2.Controls.Add(this.txtMarca);
            this.metroTabPage2.Controls.Add(this.txtTipo);
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Size = new System.Drawing.Size(746, 479);
            this.metroTabPage2.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.btnAceptar, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtTipo, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtMarca, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtPrecio, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtStock, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtStockMin, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel1, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel2, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel3, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel4, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel5, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel6, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.cmbProveedor, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(722, 581);
            // 
            // txtTipo
            // 
            this.txtTipo.AccessibleName = "Tipo";
            // 
            // 
            // 
            this.txtTipo.CustomButton.Image = null;
            this.txtTipo.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtTipo.CustomButton.Name = "";
            this.txtTipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipo.CustomButton.TabIndex = 1;
            this.txtTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipo.CustomButton.UseSelectable = true;
            this.txtTipo.CustomButton.Visible = false;
            this.txtTipo.Lines = new string[0];
            this.txtTipo.Location = new System.Drawing.Point(131, 39);
            this.txtTipo.MaxLength = 32767;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipo.SelectedText = "";
            this.txtTipo.SelectionLength = 0;
            this.txtTipo.SelectionStart = 0;
            this.txtTipo.ShortcutsEnabled = true;
            this.txtTipo.Size = new System.Drawing.Size(111, 23);
            this.txtTipo.TabIndex = 4;
            this.txtTipo.UseSelectable = true;
            this.txtTipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMarca
            // 
            this.txtMarca.AccessibleName = "Marca";
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(131, 108);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(111, 23);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrecio
            // 
            this.txtPrecio.AccessibleName = "Precio";
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(131, 187);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(111, 23);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStock
            // 
            this.txtStock.AccessibleName = "Stock";
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Lines = new string[0];
            this.txtStock.Location = new System.Drawing.Point(131, 272);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(111, 23);
            this.txtStock.TabIndex = 7;
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStockMin
            // 
            this.txtStockMin.AccessibleName = "Stock Mínimo";
            // 
            // 
            // 
            this.txtStockMin.CustomButton.Image = null;
            this.txtStockMin.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtStockMin.CustomButton.Name = "";
            this.txtStockMin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStockMin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStockMin.CustomButton.TabIndex = 1;
            this.txtStockMin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStockMin.CustomButton.UseSelectable = true;
            this.txtStockMin.CustomButton.Visible = false;
            this.txtStockMin.Lines = new string[0];
            this.txtStockMin.Location = new System.Drawing.Point(131, 356);
            this.txtStockMin.MaxLength = 32767;
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.PasswordChar = '\0';
            this.txtStockMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStockMin.SelectedText = "";
            this.txtStockMin.SelectionLength = 0;
            this.txtStockMin.SelectionStart = 0;
            this.txtStockMin.ShortcutsEnabled = true;
            this.txtStockMin.Size = new System.Drawing.Size(111, 23);
            this.txtStockMin.TabIndex = 8;
            this.txtStockMin.UseSelectable = true;
            this.txtStockMin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStockMin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Tipo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Marca:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Precio:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 272);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Stock:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 360);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Stock Mínimo:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(344, 39);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.ItemHeight = 23;
            this.cmbProveedor.Location = new System.Drawing.Point(440, 33);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 29);
            this.cmbProveedor.TabIndex = 17;
            this.cmbProveedor.UseSelectable = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 625);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStockMin;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroTextBox txtTipo;
        private MetroFramework.Controls.MetroComboBox cmbProveedor;
    }
}