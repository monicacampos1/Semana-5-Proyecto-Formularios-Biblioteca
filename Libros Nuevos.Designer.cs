
namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class Libros_Nuevos
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
            this.Ejemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejemplo
            // 
            this.Ejemplo.Location = new System.Drawing.Point(398, 64);
            this.Ejemplo.Name = "Ejemplo";
            this.Ejemplo.Size = new System.Drawing.Size(75, 23);
            this.Ejemplo.TabIndex = 0;
            this.Ejemplo.Text = "Ejemplo";
            this.Ejemplo.UseVisualStyleBackColor = true;
            // 
            // Libros_Nuevos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ejemplo);
            this.Name = "Libros_Nuevos";
            this.Text = "Libros_Nuevos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejemplo;
    }
}