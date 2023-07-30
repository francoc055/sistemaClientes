namespace SistemaClientes
{
    partial class FrmDelivery
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
            dataGridDelivery = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nombreYapellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Localidad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Orden = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            btnExportarExcel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDelivery).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridDelivery, 0, 0);
            tableLayoutPanel1.Location = new Point(37, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(729, 395);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridDelivery
            // 
            dataGridDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDelivery.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridDelivery.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDelivery.Columns.AddRange(new DataGridViewColumn[] { Id, nombreYapellido, Direccion, Localidad, Telefono, Orden, Hora });
            dataGridDelivery.Dock = DockStyle.Fill;
            dataGridDelivery.Location = new Point(3, 3);
            dataGridDelivery.Name = "dataGridDelivery";
            dataGridDelivery.RowHeadersVisible = false;
            dataGridDelivery.RowTemplate.Height = 25;
            dataGridDelivery.Size = new Size(723, 389);
            dataGridDelivery.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // nombreYapellido
            // 
            nombreYapellido.HeaderText = "Nombre";
            nombreYapellido.Name = "nombreYapellido";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Localidad
            // 
            Localidad.HeaderText = "Localidad";
            Localidad.Name = "Localidad";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Orden
            // 
            Orden.HeaderText = "Orden";
            Orden.Name = "Orden";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Location = new Point(318, 12);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(128, 23);
            btnExportarExcel.TabIndex = 1;
            btnExportarExcel.Text = "Exportar a excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // FrmDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportarExcel);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmDelivery";
            Text = "Delivery";
            FormClosing += FrmDelivery_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDelivery).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridDelivery;
        private Button btnExportarExcel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombreYapellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Orden;
        private DataGridViewTextBoxColumn Hora;
    }
}