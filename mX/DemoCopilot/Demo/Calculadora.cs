/// <summary>
/// Formulario principal de la calculadora simple.
/// </summary>
namespace Demo
{
    /// <summary>
    /// Representa la ventana principal de la calculadora.
    /// </summary>
    public partial class Calculadora : Form
    {
        /// <summary>
        /// Almacena el primer número de la operación.
        /// </summary>
        private double resultado = 0;
        /// <summary>
        /// Almacena el operador seleccionado (+, -, *, /, %, ^).
        /// </summary>
        private string operacion = "";
        /// <summary>
        /// Indica si se ha presionado un operador.
        /// </summary>
        private bool operacionPresionada = false;

        /// <summary>
        /// Inicializa una nueva instancia del formulario Form1.
        /// </summary>
        public Calculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al presionar un botón numérico.
        /// </summary>
        /// <param name="sender">Botón presionado.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void button_Click(object sender, EventArgs e)
        {
            // Si el textbox está en cero o se presionó un operador, limpiar el textbox
            if (textBox1.Text == "0" || operacionPresionada)
                textBox1.Clear();
            operacionPresionada = false;
            Button boton = (Button)sender;
            // Agregar el número presionado al textbox
            textBox1.Text += boton.Text;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar un botón de operador (+, -, *, /, %, ^).
        /// </summary>
        /// <param name="sender">Botón de operador presionado.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void operador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            // Guardar el valor actual del textbox como primer número
            double.TryParse(textBox1.Text, out resultado);
            operacionPresionada = true;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón de raíz cuadrada (?).
        /// Calcula la raíz cuadrada del número actual.
        /// </summary>
        /// <param name="sender">Botón raíz cuadrada presionado.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(textBox1.Text, out numero))
            {
                if (numero >= 0)
                    textBox1.Text = Math.Sqrt(numero).ToString();
                else
                {
                    MessageBox.Show("No se puede calcular la raíz de un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "0";
                }
            }
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón igual (=).
        /// Realiza la operación seleccionada y muestra el resultado.
        /// </summary>
        /// <param name="sender">Botón igual presionado.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero;
            double.TryParse(textBox1.Text, out segundoNumero);
            // Realiza la operación seleccionada según el operador almacenado en 'operacion'
            switch (operacion)
            {
                case "+":
                    textBox1.Text = (resultado + segundoNumero).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultado - segundoNumero).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultado * segundoNumero).ToString();
                    break;
                case "/":
                    if (segundoNumero != 0)
                        textBox1.Text = (resultado / segundoNumero).ToString();
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "0";
                    }
                    break;
                case "%":
                    // Calcula el porcentaje del primer número respecto al segundo
                    textBox1.Text = (resultado * segundoNumero / 100).ToString();
                    break;
                case "^":
                    // Calcula la potencia
                    textBox1.Text = Math.Pow(resultado, segundoNumero).ToString();
                    break;
            }
            operacionPresionada = false;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón de limpiar (C).
        /// Reinicia la calculadora.
        /// </summary>
        /// <param name="sender">Botón limpiar presionado.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultado = 0;
            operacion = "";
        }
    }
}
