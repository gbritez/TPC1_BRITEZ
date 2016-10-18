namespace TPC1_BRITEZ
{
    partial class Proveedores
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
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            this.metroTabPage1.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Text = "Búsqueda Avanzada";
            this.metroTabPage2.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.metroTabPage2.Controls.SetChildIndex(this.btnAceptar, 0);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 625);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}