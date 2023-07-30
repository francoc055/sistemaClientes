using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaClientes
{
    public delegate void DelegadoBtn();
    public partial class FrmClientes : Form
    {
        //List<Cliente> clientes;
        string path;
        FrmDelivery frmDelivery;
        public FrmClientes()
        {
            InitializeComponent();
            path = "clientes.json";
            if (File.Exists(path))
            {
                Sistema.Clientes = GetClientes();
            }

        }

        private List<Cliente> GetClientes()
        {
            Sistema.Clientes = Sistema.DeserializarJson<Cliente>(path);
            return Sistema.Clientes;
        }



        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (HayClientes(Sistema.Clientes))
            {
                CargarDataGridClientes();
            }
        }
        private bool HayClientes(List<Cliente> clientes)
        {
            if (clientes.Count == 0)
            {
                return false;
            }

            return true;
        }

        private void CargarDataGridClientes()
        {
            dataGridClientes.Rows.Clear();
            foreach (Cliente item in Sistema.Clientes)
            {
                DataGridViewRow filaCliente = new DataGridViewRow();
                filaCliente.CreateCells(dataGridClientes);
                filaCliente.Cells[0].Value = item.Id;
                filaCliente.Cells[1].Value = item.NombreYapellido;
                filaCliente.Cells[2].Value = item.Direccion;
                filaCliente.Cells[3].Value = item.Localidad;
                filaCliente.Cells[4].Value = item.Telefono;
                filaCliente.Cells[5].Value = item.LocalidadValor;

                dataGridClientes.Rows.Add(filaCliente);
            }

            dataGridClientes.ClearSelection();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            Cliente.Flag = false;
            CRUDCliente crudCliente = new CRUDCliente();

            DialogResult result = crudCliente.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarDataGridClientes();
            }
        }



        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridClientes.Rows[e.RowIndex];

                if (filaSeleccionada.Cells["Id"].Value != null)
                {
                    int valorId = (int)filaSeleccionada.Cells["Id"].Value;

                    foreach (Cliente item in Sistema.Clientes)
                    {
                        if (item.Id == valorId)
                        {
                            CRUDCliente crudCliente = new CRUDCliente(item, frmDelivery);
                            DialogResult result = crudCliente.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                //dataGridClientes.Rows.Clear();
                                CargarDataGridClientes();
                                Sistema.SerializarJson<Cliente>(Sistema.Clientes, path);

                            }

                            dataGridClientes.ClearSelection();
                            break;
                        }
                    }
                }
            }
        }

        private void txtFiltrarPorLocalidad_TextChanged(object sender, EventArgs e)
        {

            string filtro = txtFiltrarPorLocalidad.Text.Trim().ToLower();
            bool flag = true;

            dataGridClientes.Rows.Clear();
            foreach (Cliente item in Sistema.Clientes)
            {
                string cadena = item.Localidad.ToLower();
                if (cadena.Length >= filtro.Length)
                {
                    for (int i = 0; i < filtro.Length; i++)
                    {
                        if (filtro[i] != cadena[i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true && filtro.Length > 0)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridClientes);
                        fila.Cells[0].Value = item.Id;
                        fila.Cells[1].Value = item.NombreYapellido;
                        fila.Cells[2].Value = item.Direccion;
                        fila.Cells[3].Value = item.Localidad;
                        fila.Cells[4].Value = item.Telefono;

                        dataGridClientes.Rows.Add(fila);
                        fila.Selected = true;


                    }
                    flag = true;

                }
            }
            if (string.IsNullOrEmpty(filtro))
            {
                CargarDataGridClientes();
            }

        }

        private async void btnAbrirDelivery_Click(object sender, EventArgs e)
        {
            //await Task.Run(() => AbrirFormAsync());
            await Task.Run(() =>
            {
                DeshabilitarBtnDelivery();
                frmDelivery = new FrmDelivery();
                frmDelivery.ShowDialog();
                if(frmDelivery.DialogResult == DialogResult.OK)
                {
                    HabilitarBtnDelivery();
                }
            });
        }

        private void DeshabilitarBtnDelivery()
        {
            if (InvokeRequired)
            {
                DelegadoBtn delegado = DeshabilitarBtnDelivery;
                Invoke(delegado);
            }
            else
            {
                btnAbrirDelivery.Enabled = false;
            }
        }

        private void HabilitarBtnDelivery()
        {
            if (InvokeRequired)
            {
                DelegadoBtn delegado = HabilitarBtnDelivery;
                Invoke(delegado);
            }
            else
            {
                btnAbrirDelivery.Enabled = true;
            }
        }


    }
}
