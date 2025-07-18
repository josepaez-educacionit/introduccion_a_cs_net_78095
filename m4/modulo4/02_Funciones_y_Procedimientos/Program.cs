namespace _02_Funciones_y_Procedimientos
{
	internal class Program
	{
			// =============================
			// FUNCIONES Y PROCEDIMIENTOS
			// =============================
			// Las funciones y procedimientos son bloques de código reutilizables que realizan tareas específicas.
			// - FUNCIONES: Devuelven un valor al ser llamadas.
			// - PROCEDIMIENTOS: No devuelven valor (en C#, son métodos void).
			// Ventajas: Organización, reutilización, mantenimiento y legibilidad del código.

		static void Main(string[] args)
		{
			// Ejemplo de uso de una función que suma dos números y devuelve el resultado
			int suma;
			suma = Sumar(658, 7964); // Llama a la función Sumar con dos argumentos (por valor)
			ImprimirMensaje($"Suma : {suma}"); // Llama a un procedimiento para mostrar el resultado

			suma = Sumar(98, 12); // Otro ejemplo de llamada a la función Sumar
			ImprimirMensaje($"Suma : {suma}");

			// Limpia la consola y muestra el título de la siguiente sección
			Console.Clear();
			Console.WriteLine("Parametros por Valor/Referencia");

			// Declaración de variables para demostrar parámetros por referencia
			int num1 = 321; int num2 = 456;
			Console.Write($"num1: {num1} | num2: {num2}"); // Muestra valores iniciales
			
			// Llama a una función que recibe parámetros por referencia (ref)
			// Esto permite modificar los valores originales de num1 y num2
			suma = SumarPorRef(ref num1, ref num2);
			ImprimirMensaje($"Suma : {suma}");

			// Muestra los valores de num1 y num2 después de la llamada por referencia
			Console.Write($"num1: {num1} | num2: {num2}");
		}

			// =============================
			// FUNCIÓN SUMAR
			// =============================
			// Recibe dos parámetros por valor, los suma y devuelve el resultado.
			// Los parámetros por valor NO modifican las variables originales.
		static int Sumar(int num1, int num2)
		{
			int suma = num1 + num2; // Suma los dos números
			return suma; // Devuelve el resultado
		}

			// =============================
			// FUNCIÓN SUMARPORREF
			// =============================
			// Recibe dos parámetros por referencia (ref), los suma y modifica sus valores.
			// Los cambios en num1 y num2 afectan a las variables originales.
		static int SumarPorRef(ref int num1, ref int num2)
		{
			int suma = num1 + num2; // Suma los valores actuales
			num1++; // Incrementa num1 (afecta a la variable original)
			num2--; // Decrementa num2 (afecta a la variable original)
			return suma; // Devuelve la suma
		}

			// =============================
			// PROCEDIMIENTO IMPRIMIRMENSAJE
			// =============================
			// Procedimiento (método void): muestra un mensaje en consola.
			// No devuelve ningún valor.
		static void ImprimirMensaje(string mensaje)
		{
			Console.WriteLine(mensaje); // Imprime el mensaje recibido
		}
	}
}
