using Entidades;
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
    public partial class CRUDCliente : Form
    {
        Cliente _cliente;
        FrmDelivery _frmDelivery;

        public CRUDCliente()
        {
            InitializeComponent();
        }
        public CRUDCliente(Cliente cliente, FrmDelivery frmDelivery) : this()
        {
            _cliente = cliente;
            _frmDelivery = frmDelivery;
            CompletarCliente();
            btnCrearCliente.Enabled = false;


        }

        private void CRUDCliente_Load(object sender, EventArgs e)
        {
            cmbLocalidad.DataSource = Enum.GetValues(typeof(Loc));
            cmbLocalidad.SelectedIndex = -1;
            if (_cliente is null)
            {
                btnActualizar.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
            else
            {
                RecorrerComboBox();
            }


        }

        private void RecorrerComboBox()
        {
            foreach (object item in cmbLocalidad.Items)
            {
                if (_cliente.Localidad.ToLower() == item.ToString().ToLower())
                {
                    cmbLocalidad.SelectedItem = item;
                }
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text is null || txtDireccion.Text is null)
            {
                return;
            }


            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string localidad = cmbLocalidad.SelectedItem.ToString();
            double telefono = Convert.ToDouble(numericTel.Value);
            int valorLocalidad = CalcularLocalidadValor(localidad);

            Cliente clienteNuevo = new Cliente(nombre, direccion, localidad, telefono, valorLocalidad);
            Sistema.Clientes.Add(clienteNuevo);
            Sistema.SerializarJson<Cliente>(Sistema.Clientes, "clientes.json");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private int CalcularLocalidadValor(string loc)
        {
            int mayor = 0;
            foreach (var item in Sistema.Clientes)
            {
                if (item.Localidad == loc)
                {
                    if (mayor < item.LocalidadValor)
                    {
                        mayor = item.LocalidadValor;
                    }
                }
            }

            if (mayor != 0)
            {
                mayor++;
                return mayor;
            }

            return Cliente.RevisarValorLocalidad(loc);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            _cliente.NombreYapellido = txtNombre.Text;
            _cliente.Direccion = txtDireccion.Text;
            _cliente.Localidad = cmbLocalidad.SelectedItem.ToString();
            _cliente.Telefono = (double)numericTel.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CompletarCliente()
        {
            txtNombre.Text = _cliente.NombreYapellido;
            txtDireccion.Text = _cliente.Direccion;
            //txtLocalidad.Text = _cliente.Localidad;
            numericTel.Value = (decimal)_cliente.Telefono;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            FrmCartel frmCartel = new FrmCartel();
            DialogResult result = frmCartel.ShowDialog();
            if (result == DialogResult.OK)
            {
                Sistema.Clientes.Remove(_cliente);
                MessageBox.Show("eliminado con exito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void btnAgDelivery_Click(object sender, EventArgs e)
        {
            if (_frmDelivery is not null)
            {
                _frmDelivery.RecibirCliente(_cliente);
                this.Close();
            }
            else
            {
                MessageBox.Show("primero debe abrir el formulario de delivery");
            }
        }
    }
}
