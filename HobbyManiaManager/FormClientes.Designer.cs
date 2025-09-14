namespace HobbyManiaManager
{
    partial class FormClientes
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
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnFicha = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnlista = new System.Windows.Forms.Button();
            this.labelclientes = new System.Windows.Forms.Label();
            this.pictureBoxAvatarCliente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxCustomers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 14;
            this.listBoxCustomers.Location = new System.Drawing.Point(12, 32);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(787, 338);
            this.listBoxCustomers.TabIndex = 0;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            this.listBoxCustomers.DoubleClick += new System.EventHandler(this.listBoxCustomers_DoubleClick);
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(12, 383);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(135, 52);
            this.btnCreateCustomer.TabIndex = 1;
            this.btnCreateCustomer.Text = "Crear Cliente";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnFicha
            // 
            this.btnFicha.Enabled = false;
            this.btnFicha.Location = new System.Drawing.Point(843, 229);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(113, 47);
            this.btnFicha.TabIndex = 2;
            this.btnFicha.Text = "Ficha Cliente detallada";
            this.btnFicha.UseVisualStyleBackColor = true;
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(226, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar cliente";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnlista
            // 
            this.btnlista.Location = new System.Drawing.Point(686, 388);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(113, 47);
            this.btnlista.TabIndex = 4;
            this.btnlista.Text = "Clientes Activos Reporte";
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // labelclientes
            // 
            this.labelclientes.AutoSize = true;
            this.labelclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelclientes.Location = new System.Drawing.Point(1, 9);
            this.labelclientes.Name = "labelclientes";
            this.labelclientes.Size = new System.Drawing.Size(135, 20);
            this.labelclientes.TabIndex = 5;
            this.labelclientes.Text = "Lista de Clientes";
            // 
            // pictureBoxAvatarCliente
            // 
            this.pictureBoxAvatarCliente.Location = new System.Drawing.Point(814, 32);
            this.pictureBoxAvatarCliente.Name = "pictureBoxAvatarCliente";
            this.pictureBoxAvatarCliente.Size = new System.Drawing.Size(176, 171);
            this.pictureBoxAvatarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatarCliente.TabIndex = 6;
            this.pictureBoxAvatarCliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avatar del cliente seleccionado:";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAvatarCliente);
            this.Controls.Add(this.labelclientes);
            this.Controls.Add(this.btnlista);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFicha);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.listBoxCustomers);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnFicha;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Label labelclientes;
        private System.Windows.Forms.PictureBox pictureBoxAvatarCliente;
        private System.Windows.Forms.Label label1;
    }
}