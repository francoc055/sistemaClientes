using DocumentFormat.OpenXml.Spreadsheet;
using Entidades;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaClientes
{
    public delegate void DelegadoCargarDataGrid(Cliente cliente);
    public partial class FrmDelivery : Form
    {
        public FrmDelivery()
        {
            InitializeComponent();
        }

        public void RecibirCliente(Cliente cliente)
        {
            CargarDataGridAsync(cliente);
            //CargarDataGrid(cliente);
        }

        private void CargarDataGrid(Cliente cliente)
        {
            try
            {
                DataGridViewRow fila = new DataGridViewRow();
                
                fila.CreateCells(dataGridDelivery);
                fila.Cells[0].Value = cliente.Id;
                fila.Cells[1].Value = cliente.NombreYapellido;
                fila.Cells[2].Value = cliente.Direccion;
                fila.Cells[3].Value = cliente.Localidad;
                fila.Cells[4].Value = cliente.Telefono;
                fila.Cells[5].Value = "";
                fila.Cells[6].Value = "";

                dataGridDelivery.Rows.Add(fila);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }

        public void CargarDataGridAsync(Cliente cliente)
        { 
            if(InvokeRequired)
            {
                DelegadoCargarDataGrid delegado = CargarDataGridAsync;
                Object[] parametros = { cliente };
                Invoke(delegado, parametros);
            }
            else
            {
                try
                {
                    DataGridViewRow fila = new DataGridViewRow();

                    fila.CreateCells(dataGridDelivery);
                    fila.Cells[0].Value = cliente.Id;
                    fila.Cells[1].Value = cliente.NombreYapellido;
                    fila.Cells[2].Value = cliente.Direccion;
                    fila.Cells[3].Value = cliente.Localidad;
                    fila.Cells[4].Value = cliente.Telefono;
                    fila.Cells[5].Value = "";
                    fila.Cells[6].Value = "";

                    dataGridDelivery.Rows.Add(fila);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "delivery.xlsx");

            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();

            style.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.YellowGreen, System.Drawing.Color.White);
            style.Font.FontSize = 15;
            style.Font.Bold = true;
            style.Font.FontName = "Times New Roman";
            style.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            int ic = 1;
            foreach (DataGridViewColumn column in dataGridDelivery.Columns)
            {
                sl.SetCellValue(1, ic, column.HeaderText.ToString());
                sl.SetCellStyle(1, ic, style);
                sl.SetColumnWidth(ic + 1, 15);
                ic++;
            }


            int ir = 2;
            foreach (DataGridViewRow row in dataGridDelivery.Rows)
            {
                //int valor = (int)row.Cells[0].Value;
                if (row.Cells[0].Value is not null)
                {
                    sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                    sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                    sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                    sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                    sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                    sl.SetCellValue(ir, 6, row.Cells[5].Value.ToString());
                    sl.SetCellValue(ir, 7, row.Cells[6].Value.ToString());
                    ir++;
                }

            }

            sl.SaveAs(filePath);
            MessageBox.Show("Exportacion correcta");
        }

        private void FrmDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridDelivery.Rows.Clear();
            this.DialogResult = DialogResult.OK;
        }
    }
}
