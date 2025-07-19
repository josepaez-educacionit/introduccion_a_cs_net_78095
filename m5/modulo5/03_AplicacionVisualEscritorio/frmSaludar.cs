namespace _03_AplicacionVisualEscritorio
{
    // Formulario principal de la aplicaci�n de escritorio.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento para limpiar el campo de nombre y el mensaje de saludo
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Focus();
            lblSaludo.Text = "";
        }

        // Evento para mostrar un saludo personalizado en la etiqueta
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string mensaje = $"Hola {nombre}";
            //MessageBox.Show(mensaje);
            lblSaludo.Text = mensaje;
        }

        // Evento de carga del formulario (actualmente sin implementaci�n)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Puede agregar l�gica de inicializaci�n aqu� si es necesario
        }
    }
}
