namespace HobbyManiaManager
{
    partial class MainForm
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
            this.labelMoviesCounter = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2025 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoviesCounter
            // 
            this.labelMoviesCounter.AutoSize = true;
            this.labelMoviesCounter.Location = new System.Drawing.Point(13, 431);
            this.labelMoviesCounter.Name = "labelMoviesCounter";
            this.labelMoviesCounter.Size = new System.Drawing.Size(35, 13);
            this.labelMoviesCounter.TabIndex = 0;
            this.labelMoviesCounter.Text = "label1";
            // 
            // btnClientes
            // 
            this.btnClientes.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClientes.Location = new System.Drawing.Point(51, 19);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(153, 96);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(142, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "HobbyVideoClub AdminApp Tool";
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPeliculas.Location = new System.Drawing.Point(252, 19);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(153, 96);
            this.btnPeliculas.TabIndex = 3;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAlquilar.Location = new System.Drawing.Point(158, 121);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(150, 96);
            this.btnAlquilar.TabIndex = 4;
            this.btnAlquilar.Text = "Aluilar/Devolver Película";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnPeliculas);
            this.groupBox1.Controls.Add(this.btnAlquilar);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido Rafa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HobbyManiaManager.Properties.Resources.Videoclub;
            this.pictureBox1.Location = new System.Drawing.Point(465, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2025
            // 
            this.label2025.AutoSize = true;
            this.label2025.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2025.Location = new System.Drawing.Point(560, 377);
            this.label2025.Name = "label2025";
            this.label2025.Size = new System.Drawing.Size(177, 17);
            this.label2025.TabIndex = 7;
            this.label2025.Text = "R 2025 All Rights reserved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recuerda consultar la sección \"Ayuda\" si es la primera vez que usas la aplicación" +
    " (Ctrl+H)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label2025);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMoviesCounter);
            this.Name = "MainForm";
            this.Text = "Hobby Mania Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoviesCounter;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2025;
        private System.Windows.Forms.Label label2;
    }
}

