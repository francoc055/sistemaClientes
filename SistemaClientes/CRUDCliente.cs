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

        public CRUDCliente()
        {
            InitializeComponent();
        }
        public CRUDCliente(Cliente cliente) : this()
        {
            _cliente = cliente;
            CompletarCliente();
            btnCrearCliente.Enabled = false;

        }

        private void CRUDCliente_Load(object sender, EventArgs e)
        {
            if (_cliente is null)
            {
                btnActualizar.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text is null || txtDireccion.Text is null || txtLocalidad.Text is null)
            {
                return;
            }


            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string localidad = txtLocalidad.Text;
            double telefono = Convert.ToDouble(numericTel.Value);


            Cliente clienteNuevo = new Cliente(nombre, direccion, localidad, telefono);
            Sistema.Clientes.Add(clienteNuevo);
            Sistema.SerializarJson<Cliente>(Sistema.Clientes, "clientes.json");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            _cliente.NombreYapellido = txtNombre.Text;
            _cliente.Direccion = txtDireccion.Text;
            _cliente.Localidad = txtLocalidad.Text;
            _cliente.Telefono = (double)numericTel.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CompletarCliente()
        {
            txtNombre.Text = _cliente.NombreYapellido;
            txtDireccion.Text = _cliente.Direccion;
            txtLocalidad.Text = _cliente.Localidad;
            numericTel.Value = (decimal)_cliente.Telefono;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            FrmCartel frmCartel = new FrmCartel();
            DialogResult result = frmCartel.ShowDialog();
            if(result == DialogResult.OK)
            {
                Sistema.Clientes.Remove(_cliente);
                MessageBox.Show("eliminado con exito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(result == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
