
namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginsin = new System.Windows.Forms.Button();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmysql = new System.Windows.Forms.Button();
            this.btnaccess = new System.Windows.Forms.Button();
            this.btnsql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // loginsin
            // 
            this.loginsin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.loginsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginsin.Location = new System.Drawing.Point(32, 426);
            this.loginsin.Name = "loginsin";
            this.loginsin.Size = new System.Drawing.Size(135, 46);
            this.loginsin.TabIndex = 17;
            this.loginsin.Text = "Login sin base ";
            this.loginsin.UseVisualStyleBackColor = false;
            this.loginsin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(230, 330);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(229, 20);
            this.txtcontra.TabIndex = 16;
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(230, 215);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(229, 20);
            this.txtusu.TabIndex = 15;
            this.txtusu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingresar contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingresar usuario ";
            // 
            // btnmysql
            // 
            this.btnmysql.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnmysql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmysql.Location = new System.Drawing.Point(546, 426);
            this.btnmysql.Name = "btnmysql";
            this.btnmysql.Size = new System.Drawing.Size(135, 46);
            this.btnmysql.TabIndex = 19;
            this.btnmysql.Text = "MySQL";
            this.btnmysql.UseVisualStyleBackColor = false;
            this.btnmysql.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaccess
            // 
            this.btnaccess.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnaccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccess.Location = new System.Drawing.Point(374, 426);
            this.btnaccess.Name = "btnaccess";
            this.btnaccess.Size = new System.Drawing.Size(135, 46);
            this.btnaccess.TabIndex = 20;
            this.btnaccess.Text = "Access";
            this.btnaccess.UseVisualStyleBackColor = false;
            this.btnaccess.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsql
            // 
            this.btnsql.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsql.Location = new System.Drawing.Point(204, 426);
            this.btnsql.Name = "btnsql";
            this.btnsql.Size = new System.Drawing.Size(135, 46);
            this.btnsql.TabIndex = 22;
            this.btnsql.Text = "SQL Server ";
            this.btnsql.UseVisualStyleBackColor = false;
            this.btnsql.Click += new System.EventHandler(this.btnsql_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 504);
            this.Controls.Add(this.btnsql);
            this.Controls.Add(this.btnaccess);
            this.Controls.Add(this.btnmysql);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginsin);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginsin;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmysql;
        private System.Windows.Forms.Button btnaccess;
        private System.Windows.Forms.Button btnsql;
    }
}