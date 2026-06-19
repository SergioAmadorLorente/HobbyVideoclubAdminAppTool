namespace HobbyManiaManager
{
    partial class FormAlquilarDevolver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNotas = new System.Windows.Forms.TextBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnDevolverPeli = new System.Windows.Forms.Button();
            this.btnListaRental = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.labelNombrePelicula = new System.Windows.Forms.Label();
            this.labelidpelicula = new System.Windows.Forms.Label();
            this.textBoxidpelicula = new System.Windows.Forms.TextBox();
            this.textBoxnombrepelicula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxidcliente = new System.Windows.Forms.TextBox();
            this.textBoxnombrecliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labellatieneel = new System.Windows.Forms.Label();
            this.pictureBoxCliente = new System.Windows.Forms.PictureBox();
            this.pictureBoxPeli = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alquilar/Devolver Película";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Notas:";
            // 
            // textBoxNotas
            // 
            this.textBoxNotas.Location = new System.Drawing.Point(674, 65);
            this.textBoxNotas.Multiline = true;
            this.textBoxNotas.Name = "textBoxNotas";
            this.textBoxNotas.Size = new System.Drawing.Size(168, 102);
            this.textBoxNotas.TabIndex = 7;
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(345, 446);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(94, 47);
            this.btnAlquilar.TabIndex = 8;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnDevolverPeli
            // 
            this.btnDevolverPeli.Location = new System.Drawing.Point(649, 446);
            this.btnDevolverPeli.Name = "btnDevolverPeli";
            this.btnDevolverPeli.Size = new System.Drawing.Size(98, 47);
            this.btnDevolverPeli.TabIndex = 9;
            this.btnDevolverPeli.Text = "Devolver";
            this.btnDevolverPeli.UseVisualStyleBackColor = true;
            this.btnDevolverPeli.Click += new System.EventHandler(this.btnDevolverPeli_Click);
            // 
            // btnListaRental
            // 
            this.btnListaRental.Location = new System.Drawing.Point(746, 3);
            this.btnListaRental.Name = "btnListaRental";
            this.btnListaRental.Size = new System.Drawing.Size(75, 48);
            this.btnListaRental.TabIndex = 13;
            this.btnListaRental.Text = "Reporte Alquileres Activos";
            this.btnListaRental.UseVisualStyleBackColor = true;
            this.btnListaRental.Click += new System.EventHandler(this.btnListaRental_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HobbyManiaManager.Properties.Resources.nook;
            this.pictureBox2.Location = new System.Drawing.Point(565, 457);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HobbyManiaManager.Properties.Resources.ok;
            this.pictureBox1.Location = new System.Drawing.Point(445, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 14;
            this.listBoxClientes.Location = new System.Drawing.Point(223, 65);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(437, 102);
            this.listBoxClientes.TabIndex = 14;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.ItemHeight = 14;
            this.listBoxPeliculas.Location = new System.Drawing.Point(223, 189);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(619, 144);
            this.listBoxPeliculas.TabIndex = 15;
            this.listBoxPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxPeliculas_SelectedIndexChanged);
            // 
            // labelNombrePelicula
            // 
            this.labelNombrePelicula.AutoSize = true;
            this.labelNombrePelicula.Location = new System.Drawing.Point(6, 48);
            this.labelNombrePelicula.Name = "labelNombrePelicula";
            this.labelNombrePelicula.Size = new System.Drawing.Size(89, 13);
            this.labelNombrePelicula.TabIndex = 16;
            this.labelNombrePelicula.Text = "Nombre Película:";
            // 
            // labelidpelicula
            // 
            this.labelidpelicula.AutoSize = true;
            this.labelidpelicula.Location = new System.Drawing.Point(27, 19);
            this.labelidpelicula.Name = "labelidpelicula";
            this.labelidpelicula.Size = new System.Drawing.Size(63, 13);
            this.labelidpelicula.TabIndex = 17;
            this.labelidpelicula.Text = "ID Película:";
            // 
            // textBoxidpelicula
            // 
            this.textBoxidpelicula.Enabled = false;
            this.textBoxidpelicula.Location = new System.Drawing.Point(99, 19);
            this.textBoxidpelicula.Name = "textBoxidpelicula";
            this.textBoxidpelicula.Size = new System.Drawing.Size(145, 20);
            this.textBoxidpelicula.TabIndex = 18;
            // 
            // textBoxnombrepelicula
            // 
            this.textBoxnombrepelicula.Enabled = false;
            this.textBoxnombrepelicula.Location = new System.Drawing.Point(99, 45);
            this.textBoxnombrepelicula.Name = "textBoxnombrepelicula";
            this.textBoxnombrepelicula.Size = new System.Drawing.Size(145, 20);
            this.textBoxnombrepelicula.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lista de Películas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista de Clientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombre del Cliente:";
            // 
            // textBoxidcliente
            // 
            this.textBoxidcliente.Enabled = false;
            this.textBoxidcliente.Location = new System.Drawing.Point(359, 15);
            this.textBoxidcliente.Name = "textBoxidcliente";
            this.textBoxidcliente.Size = new System.Drawing.Size(128, 20);
            this.textBoxidcliente.TabIndex = 24;
            // 
            // textBoxnombrecliente
            // 
            this.textBoxnombrecliente.Enabled = false;
            this.textBoxnombrecliente.Location = new System.Drawing.Point(359, 46);
            this.textBoxnombrecliente.Name = "textBoxnombrecliente";
            this.textBoxnombrecliente.Size = new System.Drawing.Size(128, 20);
            this.textBoxnombrecliente.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxidpelicula);
            this.groupBox1.Controls.Add(this.textBoxnombrecliente);
            this.groupBox1.Controls.Add(this.labelNombrePelicula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxidcliente);
            this.groupBox1.Controls.Add(this.labelidpelicula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxnombrepelicula);
            this.groupBox1.Location = new System.Drawing.Point(266, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Película y Cliente seleccionados";
            // 
            // labellatieneel
            // 
            this.labellatieneel.AutoSize = true;
            this.labellatieneel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labellatieneel.Location = new System.Drawing.Point(345, 427);
            this.labellatieneel.Name = "labellatieneel";
            this.labellatieneel.Size = new System.Drawing.Size(116, 13);
            this.labellatieneel.TabIndex = 27;
            this.labellatieneel.Text = "labelQuienPoseeLaPeli";
            this.labellatieneel.Visible = false;
            // 
            // pictureBoxCliente
            // 
            this.pictureBoxCliente.Location = new System.Drawing.Point(33, 48);
            this.pictureBoxCliente.Name = "pictureBoxCliente";
            this.pictureBoxCliente.Size = new System.Drawing.Size(144, 171);
            this.pictureBoxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCliente.TabIndex = 28;
            this.pictureBoxCliente.TabStop = false;
            // 
            // pictureBoxPeli
            // 
            this.pictureBoxPeli.Location = new System.Drawing.Point(22, 263);
            this.pictureBoxPeli.Name = "pictureBoxPeli";
            this.pictureBoxPeli.Size = new System.Drawing.Size(184, 185);
            this.pictureBoxPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeli.TabIndex = 29;
            this.pictureBoxPeli.TabStop = false;
            // 
            // FormAlquilarDevolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 500);
            this.Controls.Add(this.pictureBoxPeli);
            this.Controls.Add(this.pictureBoxCliente);
            this.Controls.Add(this.labellatieneel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPeliculas);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.btnListaRental);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDevolverPeli);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.textBoxNotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormAlquilarDevolver";
            this.Text = "FormAlquilarDevolver";
            this.Load += new System.EventHandler(this.FormAlquilarDevolver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNotas;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnDevolverPeli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnListaRental;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.Label labelNombrePelicula;
        private System.Windows.Forms.Label labelidpelicula;
        private System.Windows.Forms.TextBox textBoxidpelicula;
        private System.Windows.Forms.TextBox textBoxnombrepelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxidcliente;
        private System.Windows.Forms.TextBox textBoxnombrecliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labellatieneel;
        private System.Windows.Forms.PictureBox pictureBoxCliente;
        private System.Windows.Forms.PictureBox pictureBoxPeli;
    }
}