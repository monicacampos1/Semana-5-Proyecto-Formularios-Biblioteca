
namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class Ayuda_del_Sistema
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
            this.textContenedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textContenedor
            // 
            this.textContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textContenedor.Location = new System.Drawing.Point(118, 103);
            this.textContenedor.Multiline = true;
            this.textContenedor.Name = "textContenedor";
            this.textContenedor.ReadOnly = true;
            this.textContenedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textContenedor.Size = new System.Drawing.Size(566, 326);
            this.textContenedor.TabIndex = 23;
            // 
            // Ayuda_del_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.textContenedor);
            this.Name = "Ayuda_del_Sistema";
            this.Text = "Ventana de Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_del_Sistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textContenedor;
    }
}