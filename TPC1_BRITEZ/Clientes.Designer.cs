namespace TPC1_BRITEZ
{
    partial class Clientes
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtCUIL = new MetroFramework.Controls.MetroTextBox();
            this.txtDNI = new MetroFramework.Controls.MetroTextBox();
            this.txtDomicilio = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.SelectedIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Size = new System.Drawing.Size(746, 479);
            this.metroTabPage1.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // btnBuscar
            // 
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
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.txtTelefono);
            this.metroTabPage2.Controls.Add(this.txtDomicilio);
            this.metroTabPage2.Controls.Add(this.txtDNI);
            this.metroTabPage2.Controls.Add(this.txtCUIL);
            this.metroTabPage2.Controls.Add(this.txtNombre);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Size = new System.Drawing.Size(746, 479);
            this.metroTabPage2.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.btnAceptar, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel1, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel2, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel3, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel4, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.metroLabel5, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtNombre, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtCUIL, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtDNI, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtDomicilio, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.txtTelefono, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nombre:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "CUIL:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "DNI:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(47, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Domicilio:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 250);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleName = "Nombre";
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(205, 44);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(216, 23);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCUIL
            // 
            this.txtCUIL.AccessibleName = "CUIL";
            // 
            // 
            // 
            this.txtCUIL.CustomButton.Image = null;
            this.txtCUIL.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtCUIL.CustomButton.Name = "";
            this.txtCUIL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCUIL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCUIL.CustomButton.TabIndex = 1;
            this.txtCUIL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCUIL.CustomButton.UseSelectable = true;
            this.txtCUIL.CustomButton.Visible = false;
            this.txtCUIL.Lines = new string[0];
            this.txtCUIL.Location = new System.Drawing.Point(205, 95);
            this.txtCUIL.MaxLength = 32767;
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.PasswordChar = '\0';
            this.txtCUIL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCUIL.SelectedText = "";
            this.txtCUIL.SelectionLength = 0;
            this.txtCUIL.SelectionStart = 0;
            this.txtCUIL.ShortcutsEnabled = true;
            this.txtCUIL.Size = new System.Drawing.Size(216, 23);
            this.txtCUIL.TabIndex = 10;
            this.txtCUIL.UseSelectable = true;
            this.txtCUIL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCUIL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDNI
            // 
            this.txtDNI.AccessibleName = "DNI";
            // 
            // 
            // 
            this.txtDNI.CustomButton.Image = null;
            this.txtDNI.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtDNI.CustomButton.Name = "";
            this.txtDNI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDNI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDNI.CustomButton.TabIndex = 1;
            this.txtDNI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDNI.CustomButton.UseSelectable = true;
            this.txtDNI.CustomButton.Visible = false;
            this.txtDNI.Lines = new string[0];
            this.txtDNI.Location = new System.Drawing.Point(205, 147);
            this.txtDNI.MaxLength = 32767;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PasswordChar = '\0';
            this.txtDNI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDNI.SelectedText = "";
            this.txtDNI.SelectionLength = 0;
            this.txtDNI.SelectionStart = 0;
            this.txtDNI.ShortcutsEnabled = true;
            this.txtDNI.Size = new System.Drawing.Size(216, 23);
            this.txtDNI.TabIndex = 11;
            this.txtDNI.UseSelectable = true;
            this.txtDNI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDNI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AccessibleName = "Domicilio";
            // 
            // 
            // 
            this.txtDomicilio.CustomButton.Image = null;
            this.txtDomicilio.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtDomicilio.CustomButton.Name = "";
            this.txtDomicilio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDomicilio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDomicilio.CustomButton.TabIndex = 1;
            this.txtDomicilio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDomicilio.CustomButton.UseSelectable = true;
            this.txtDomicilio.CustomButton.Visible = false;
            this.txtDomicilio.Lines = new string[0];
            this.txtDomicilio.Location = new System.Drawing.Point(205, 198);
            this.txtDomicilio.MaxLength = 32767;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.SelectionLength = 0;
            this.txtDomicilio.SelectionStart = 0;
            this.txtDomicilio.ShortcutsEnabled = true;
            this.txtDomicilio.Size = new System.Drawing.Size(216, 23);
            this.txtDomicilio.TabIndex = 12;
            this.txtDomicilio.UseSelectable = true;
            this.txtDomicilio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDomicilio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AccessibleName = "Teléfono";
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(205, 250);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(216, 23);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 625);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroTextBox txtDomicilio;
        private MetroFramework.Controls.MetroTextBox txtDNI;
        private MetroFramework.Controls.MetroTextBox txtCUIL;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}