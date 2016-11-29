namespace TPC1_BRITEZ
{
    partial class SetCaja
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
            this.btnEnviar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtImporte = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(108, 222);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Aceptar";
            this.btnEnviar.UseSelectable = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Saldo: ";
            // 
            // txtImporte
            // 
            // 
            // 
            // 
            this.txtImporte.CustomButton.Image = null;
            this.txtImporte.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtImporte.CustomButton.Name = "";
            this.txtImporte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImporte.CustomButton.TabIndex = 1;
            this.txtImporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImporte.CustomButton.UseSelectable = true;
            this.txtImporte.CustomButton.Visible = false;
            this.txtImporte.Lines = new string[0];
            this.txtImporte.Location = new System.Drawing.Point(128, 137);
            this.txtImporte.MaxLength = 32767;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PasswordChar = '\0';
            this.txtImporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImporte.SelectedText = "";
            this.txtImporte.SelectionLength = 0;
            this.txtImporte.SelectionStart = 0;
            this.txtImporte.ShortcutsEnabled = true;
            this.txtImporte.Size = new System.Drawing.Size(135, 23);
            this.txtImporte.TabIndex = 2;
            this.txtImporte.UseSelectable = true;
            this.txtImporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SetCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnEnviar);
            this.Name = "SetCaja";
            this.Text = "Fijar Importe Inicial";
            this.Load += new System.EventHandler(this.SetCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEnviar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtImporte;
    }
}