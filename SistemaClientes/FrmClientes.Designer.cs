namespace SistemaClientes
{
    partial class FrmClientes
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridClientes = new DataGridView();
            btnCrear = new Button();
            txtFiltrarPorLocalidad = new TextBox();
            label1 = new Label();
            btnAbrirDelivery = new Button();
            Id = new DataGridViewTextBoxColumn();
            nombreYapellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Localidad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            LocalidadValor = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridClientes, 0, 0);
            tableLayoutPanel1.Location = new Point(46, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(702, 308);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridClientes
            // 
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Columns.AddRange(new DataGridViewColumn[] { Id, nombreYapellido, Direccion, Localidad, Telefono, LocalidadValor });
            dataGridClientes.Dock = DockStyle.Fill;
            dataGridClientes.Location = new Point(3, 3);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.RowHeadersVisible = false;
            dataGridClientes.RowTemplate.Height = 25;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.Size = new Size(696, 302);
            dataGridClientes.TabIndex = 0;
            dataGridClientes.CellClick += dataGridClientes_CellClick;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Right;
            btnCrear.Location = new Point(791, 158);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtFiltrarPorLocalidad
            // 
            txtFiltrarPorLocalidad.Location = new Point(194, 36);
            txtFiltrarPorLocalidad.Name = "txtFiltrarPorLocalidad";
            txtFiltrarPorLocalidad.PlaceholderText = "Localidad...";
            txtFiltrarPorLocalidad.Size = new Size(100, 23);
            txtFiltrarPorLocalidad.TabIndex = 2;
            txtFiltrarPorLocalidad.TextChanged += txtFiltrarPorLocalidad_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Filtrar por localidad";
            // 
            // btnAbrirDelivery
            // 
            btnAbrirDelivery.Location = new Point(523, 30);
            btnAbrirDelivery.Name = "btnAbrirDelivery";
            btnAbrirDelivery.Size = new Size(113, 32);
            btnAbrirDelivery.TabIndex = 4;
            btnAbrirDelivery.Text = "Abrir Delivery";
            btnAbrirDelivery.UseVisualStyleBackColor = true;
            btnAbrirDelivery.Click += btnAbrirDelivery_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nombreYapellido
            // 
            nombreYapellido.HeaderText = "Nombre y apellido";
            nombreYapellido.Name = "nombreYapellido";
            nombreYapellido.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Localidad
            // 
            Localidad.HeaderText = "Localidad";
            Localidad.Name = "Localidad";
            Localidad.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // LocalidadValor
            // 
            LocalidadValor.HeaderText = "valor localidad";
            LocalidadValor.Name = "LocalidadValor";
            LocalidadValor.ReadOnly = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(btnAbrirDelivery);
            Controls.Add(label1);
            Controls.Add(txtFiltrarPorLocalidad);
            Controls.Add(btnCrear);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridClientes;
        private Button btnCrear;
        private TextBox txtFiltrarPorLocalidad;
        private Label label1;
        private Button btnAbrirDelivery;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombreYapellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn LocalidadValor;
    }
}