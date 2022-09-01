
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.textContenedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLeer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeer.FlatAppearance.BorderSize = 0;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeer.Location = new System.Drawing.Point(269, 441);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(280, 50);
            this.btnLeer.TabIndex = 22;
            this.btnLeer.Text = "Leer información de ayuda";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click_2);
            // 
            // textContenedor
            // 
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
            this.Controls.Add(this.btnLeer);
            this.Name = "Ayuda_del_Sistema";
            this.Text = "Ventana de Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_del_Sistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox textContenedor;
    }
}