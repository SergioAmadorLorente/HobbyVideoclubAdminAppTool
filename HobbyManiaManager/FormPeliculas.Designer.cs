namespace HobbyManiaManager
{
    partial class FormPeliculas
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
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.textBoxTextABuscar = new System.Windows.Forms.TextBox();
            this.btnPeliABuscar = new System.Windows.Forms.Button();
            this.btnRating = new System.Windows.Forms.Button();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.btnInforme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPelicula = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSinopsis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPeliculas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.ItemHeight = 14;
            this.listBoxPeliculas.Location = new System.Drawing.Point(2, 26);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(737, 298);
            this.listBoxPeliculas.TabIndex = 0;
            this.listBoxPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxPeliculas_SelectedIndexChanged);
            // 
            // textBoxTextABuscar
            // 
            this.textBoxTextABuscar.Location = new System.Drawing.Point(6, 39);
            this.textBoxTextABuscar.Name = "textBoxTextABuscar";
            this.textBoxTextABuscar.Size = new System.Drawing.Size(224, 20);
            this.textBoxTextABuscar.TabIndex = 1;
            this.textBoxTextABuscar.TextChanged += new System.EventHandler(this.textBoxTextABuscar_TextChanged);
            // 
            // btnPeliABuscar
            // 
            this.btnPeliABuscar.Location = new System.Drawing.Point(56, 65);
            this.btnPeliABuscar.Name = "btnPeliABuscar";
            this.btnPeliABuscar.Size = new System.Drawing.Size(111, 23);
            this.btnPeliABuscar.TabIndex = 2;
            this.btnPeliABuscar.Text = "FILTRAR";
            this.btnPeliABuscar.UseVisualStyleBackColor = true;
            this.btnPeliABuscar.Visible = false;
            this.btnPeliABuscar.Click += new System.EventHandler(this.btnPeliABuscar_Click);
            // 
            // btnRating
            // 
            this.btnRating.Location = new System.Drawing.Point(45, 65);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(74, 23);
            this.btnRating.TabIndex = 3;
            this.btnRating.Text = "Filtrar";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(37, 39);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(91, 20);
            this.textBoxRating.TabIndex = 4;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
            // 
            // btnInforme
            // 
            this.btnInforme.Enabled = false;
            this.btnInforme.Location = new System.Drawing.Point(818, 367);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(76, 37);
            this.btnInforme.TabIndex = 5;
            this.btnInforme.Text = "Generar";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTextABuscar);
            this.groupBox1.Controls.Add(this.btnPeliABuscar);
            this.groupBox1.Location = new System.Drawing.Point(61, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRAR POR NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese el nombre de la Película:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxRating);
            this.groupBox2.Controls.Add(this.btnRating);
            this.groupBox2.Location = new System.Drawing.Point(392, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 107);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTRAR POR VALORACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese valoración miníma ej: 8,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Informe sobre la Película:";
            // 
            // pictureBoxPelicula
            // 
            this.pictureBoxPelicula.InitialImage = null;
            this.pictureBoxPelicula.Location = new System.Drawing.Point(745, 26);
            this.pictureBoxPelicula.Name = "pictureBoxPelicula";
            this.pictureBoxPelicula.Size = new System.Drawing.Size(220, 192);
            this.pictureBoxPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPelicula.TabIndex = 9;
            this.pictureBoxPelicula.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(-1, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lista de Películas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imagen de la Película seleccionada";
            // 
            // textBoxSinopsis
            // 
            this.textBoxSinopsis.Location = new System.Drawing.Point(745, 224);
            this.textBoxSinopsis.Multiline = true;
            this.textBoxSinopsis.Name = "textBoxSinopsis";
            this.textBoxSinopsis.ReadOnly = true;
            this.textBoxSinopsis.Size = new System.Drawing.Size(220, 100);
            this.textBoxSinopsis.TabIndex = 12;
            this.textBoxSinopsis.Visible = false;
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 448);
            this.Controls.Add(this.textBoxSinopsis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxPelicula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.listBoxPeliculas);
            this.Name = "FormPeliculas";
            this.Text = "FormPeliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.TextBox textBoxTextABuscar;
        private System.Windows.Forms.Button btnPeliABuscar;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPelicula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSinopsis;
    }
}