namespace _01_Variables_Constantes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Una variable es un espacio en memoria donde se almacena un valor que puede cambiar durante la ejecución.

			/*
			Sintaxis para declarar variables:
			<tipoVariable> <nombreVariable>;
			*/

			// Declaración y asignación de variables
			// -------------------------------------
			// Declaración: se reserva espacio en memoria para una variable.
			int numero; // Variable de tipo entero
			// Asignación: se le da un valor a la variable.
			numero = 10;

			string mensaje = "Hola"; // Declaración y asignación en una sola línea

			// Declaración múltiple y asignación posterior
			int x, y, z;
			x = 5;
			y = 10;
			z = 1;


			#region Tipos de dato cadena de caracteres
			// --- STRING ---
			// Almacenan texto (secuencias de caracteres). Útiles para nombres, descripciones y cualquier dato textual.
			// Ejemplo de uso: solicitar y mostrar el nombre y apellido del usuario.

			string nombre = "";
			string apellido = "";

			Console.WriteLine("Ingrese su nombre:");
			nombre = Console.ReadLine(); // Lee el nombre ingresado por el usuario

			Console.WriteLine("Ingrese su apellido:");
			apellido = Console.ReadLine(); // Lee el apellido ingresado por el usuario

			Console.WriteLine("Hola " + nombre + " " + apellido); // Muestra un saludo con el nombre y apellido

			#endregion

			#region Tipos de dato fecha y hora
			// --- DATETIME ---
			// Permiten trabajar con fechas y horas. Útiles para registrar eventos o mostrar la fecha actual.
			// Ejemplo:

			DateTime fechaActual = DateTime.Now; // Obtiene la fecha y hora actual del sistema
			Console.WriteLine("Fecha y hora actual: " + fechaActual); // Muestra la fecha y hora actual

			#endregion

			#region Tipos de dato booleano
			// --- BOOL ---
			// Almacenan valores lógicos: true (verdadero) o false (falso). Útiles para condiciones y banderas.
			// Ejemplo:

			bool esVerdadero = false;
			Console.WriteLine("El valor de esVerdadero es: " + esVerdadero);
			#endregion

			#region Tipos de dato Character
			// --- CHAR ---
			// Almacenan un solo carácter Unicode. Útiles para iniciales, símbolos o validaciones de un carácter.
			// Ejemplo:

			char letra = 'C';
			Console.WriteLine("El valor de la letra es: " + letra);
			#endregion

			#region Tipos de dato Enteros (con y sin signo)
			// --- ENTEROS ---
			// Almacenan números sin decimales. Incluyen variantes con y sin signo para distintos rangos y necesidades.
			// Ejemplo de uso de varios tipos:

			byte edadMaxima = 255;
			sbyte temperaturaNegativa = -100;
			short poblacionPequena = 32000;
			int cantidadUsuarios = 1000000;
			long distanciaGalaxia = 9000000000;
			ushort cantidadProductos = 60000;
			uint saldoBancario = 4000000000;
			ulong numeroEstrellas = 18000000000000000000;
			byte valorMinimo = 0;
			#endregion

			#region Tipos de dato Decimales
			/*
			--- DECIMALES ---
			Permiten almacenar números con parte fraccionaria.
			- decimal: máxima precisión, ideal para dinero.
			- double: doble precisión, útil en cálculos científicos.
			- float: menor precisión, ahorra memoria.
			*/
			decimal longitud = 100.50m;
			double altura = 1.75;
			float peso = 70.5F;
			#endregion

			#region Tipos de dato Lista
			/*
			--- LISTAS ---
			Permiten agrupar varios valores en una sola variable.
			- List<object>: admite cualquier tipo de dato (heterogénea).
			- List<string>: solo cadenas de texto (homogénea).
			*/
			List<System.Object> listaObjetos = new List<object>(); // Lista heterogénea
			listaObjetos.Add(1);              // Entero
			listaObjetos.Add("Texto");         // Cadena
			listaObjetos.Add(DateTime.Now);   // Fecha y hora
			listaObjetos.Add(true);           // Booleano
			listaObjetos.Add('A');            // Carácter
			listaObjetos.Add(null);           // Valor nulo

			List<string> listaPaises = new List<string>(); // Lista de cadenas
			listaPaises.Add("Argentina");
			listaPaises.Add("Brasil");
			listaPaises.Add("Chile");
			#endregion

			#region Constantes
			/*
			--- CONSTANTES ---
			Valores fijos que no cambian durante la ejecución del programa. Se declaran con 'const' y deben inicializarse al declararse.
			*/
			const double IVA = 0.21;         // Porcentaje de IVA
			const int MAXIMO_INTENTOS = 3;   // Límite de intentos permitidos
			#endregion
		}
	}
}
