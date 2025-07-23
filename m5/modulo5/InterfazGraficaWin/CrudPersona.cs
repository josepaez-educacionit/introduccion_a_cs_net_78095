namespace InterfazGraficaWin
{
	public partial class CrudPersona : Form
	{
		public CrudPersona()
		{
			InitializeComponent();
		}

		List<Persona> personas = new List<Persona>();

		private void AgregarPersona()
		{
			Persona persona = new Persona();
			persona.Nombre = txtNombre.Text;
			persona.Apellido = txtApellido.Text;
			persona.NumeroDocumento = txtNumeroDocumento.Text;
			persona.FechaNacimiento = txtFechaNacimiento.Value.Date;
			persona.Domicilio = txtDomicilio.Text;
			persona.Telefono = txtTelefono.Text;

			personas.Add(persona);
		}

		private void LimpiarControles()
		{
			txtNombre.Clear();
			txtApellido.Clear();
			txtNumeroDocumento.Clear();
			txtDomicilio.Clear();
			txtTelefono.Clear();
			txtFechaNacimiento.Value = DateTime.Now.Date;
		}

		private void PonerFoco()
		{
			txtNombre.Focus();
		}

		private void ActualizarGrilla()
		{
			dgvPersonas.DataSource = null;
			dgvPersonas.DataSource = personas;
		}

		private bool ValidarDatos()
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("El campo Nombre es obligatorio!");
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtApellido.Text))
			{
				MessageBox.Show("El campo Apellido es obligatorio!");
				return false;
			}

			return true;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				AgregarPersona();
				LimpiarControles();
				PonerFoco();
				ActualizarGrilla();
			}
		}
	}
}
