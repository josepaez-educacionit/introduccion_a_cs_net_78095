using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo
{
    public partial class frmClientes : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private Cliente clienteSeleccionado = null;

        public frmClientes()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 40 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nombre", HeaderText = "Nombre", Width = 100 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Apellido", HeaderText = "Apellido", Width = 100 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", Width = 120 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefono", HeaderText = "Teléfono", Width = 80 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Direccion", HeaderText = "Dirección", Width = 120 });
            dgvClientes.DataSource = clientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var cliente = new Cliente
                {
                    Id = clientes.Count > 0 ? clientes[clientes.Count - 1].Id + 1 : 1,
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };
                clientes.Add(cliente);
                ActualizarGrilla();
                LimpiarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null && ValidarCampos())
            {
                clienteSeleccionado.Nombre = txtNombre.Text.Trim();
                clienteSeleccionado.Apellido = txtApellido.Text.Trim();
                clienteSeleccionado.Email = txtEmail.Text.Trim();
                clienteSeleccionado.Telefono = txtTelefono.Text.Trim();
                clienteSeleccionado.Direccion = txtDireccion.Text.Trim();
                ActualizarGrilla();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                clientes.Remove(clienteSeleccionado);
                ActualizarGrilla();
                LimpiarCampos();
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null &&
                dgvClientes.CurrentRow.Index >= 0 &&
                dgvClientes.CurrentRow.DataBoundItem is Cliente cliente)
            {
                clienteSeleccionado = cliente;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
            }
        }

        private void ActualizarGrilla()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            clienteSeleccionado = null;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
