namespace SistemaClientes
{
    partial class CRUDCliente
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
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            numericTel = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCrearCliente = new Button();
            btnActualizar = new Button();
            btnEliminarCliente = new Button();
            cmbLocalidad = new ComboBox();
            btnAgDelivery = new Button();
            ((System.ComponentModel.ISupportInitialize)numericTel).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(141, 109);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(120, 23);
            txtDireccion.TabIndex = 1;
            // 
            // numericTel
            // 
            numericTel.Location = new Point(141, 204);
            numericTel.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericTel.Minimum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericTel.Name = "numericTel";
            numericTel.Size = new Size(120, 23);
            numericTel.TabIndex = 3;
            numericTel.Value = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre y apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 112);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 161);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 206);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefono";
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.BackColor = Color.RoyalBlue;
            btnCrearCliente.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnCrearCliente.FlatStyle = FlatStyle.Flat;
            btnCrearCliente.ForeColor = Color.White;
            btnCrearCliente.Location = new Point(53, 251);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(75, 23);
            btnCrearCliente.TabIndex = 8;
            btnCrearCliente.Text = "Crear";
            btnCrearCliente.UseVisualStyleBackColor = false;
            btnCrearCliente.Click += btnCrearCliente_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.RoyalBlue;
            btnActualizar.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(156, 251);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.RoyalBlue;
            btnEliminarCliente.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.ForeColor = Color.White;
            btnEliminarCliente.Location = new Point(259, 251);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(75, 23);
            btnEliminarCliente.TabIndex = 10;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(140, 158);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(121, 23);
            cmbLocalidad.TabIndex = 11;
            // 
            // btnAgDelivery
            // 
            btnAgDelivery.Location = new Point(140, 12);
            btnAgDelivery.Name = "btnAgDelivery";
            btnAgDelivery.Size = new Size(121, 23);
            btnAgDelivery.TabIndex = 12;
            btnAgDelivery.Text = "Agregar al delivery";
            btnAgDelivery.UseVisualStyleBackColor = true;
            btnAgDelivery.Click += btnAgDelivery_Click;
            // 
            // CRUDCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(390, 298);
            Controls.Add(btnAgDelivery);
            Controls.Add(cmbLocalidad);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrearCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericTel);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Name = "CRUDCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDCliente";
            Load += CRUDCliente_Load;
            ((System.ComponentModel.ISupportInitialize)numericTel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDireccion;
        private NumericUpDown numericTel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrearCliente;
        private Button btnActualizar;
        private Button btnEliminarCliente;
        private ComboBox cmbLocalidad;
        private Button btnAgDelivery;
    }
}