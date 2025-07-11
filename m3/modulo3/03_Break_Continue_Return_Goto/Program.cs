namespace _03_Break_Continue_Return_Goto
{
	internal class Program
	{
		// Break, Continue, Return, Goto
		// Estas son instrucciones que controlan el flujo de ejecución dentro de los bucles y métodos en C#.

		// Break: Se utiliza para salir de un bucle antes de que se complete su iteración normal.

		// Continue: Se utiliza para saltar a la siguiente iteración de un bucle.

		// Return: Se utiliza para salir de un método y devolver un valor.

		// Goto: Se utiliza para saltar a una etiqueta específica en el código, aunque su uso no es recomendado por cuestiones de legibilidad.
		static void Main(string[] args)
		{

			// Ejemplo de uso de Break y Continue

			for (int i = 1; i <= 10; i++)
			{
				if (i == 5)
				{
					break; // Sale del bucle cuando i es igual a 5.
				}
				Console.WriteLine(i);
			}
			Console.WriteLine("Bucle terminado.");
			Console.Clear();

			// Continue: Salta la iteración actual y continúa con la siguiente.
			for (int i = 1; i <= 10; i++)
			{
				if (i % 2 == 0)
				{
					continue; // Salta los números pares.
				}
				Console.WriteLine(i);
			}

			Console.Clear();
			int resultado = Sumar(5, 10); // Llama al método Sumar con los argumentos 5 y 10.
			Console.WriteLine($"La suma es: {resultado}"); // Imprime el resultado de la suma.


			Console.Clear();
			UsarGoto(); // Llama al método que utiliza Goto.
		}

		// Return: Sale del método y devuelve un valor.
		public static int Sumar(int a, int b)
		{
			return a + b; // Devuelve la suma de a y b.
		}

		// Goto: Salta a una etiqueta específica en el código.	
		public static void UsarGoto()
		{
			int i = 0;
		Inicio:
			if (i < 5)
			{
				Console.WriteLine(i);
				i++;
				goto Inicio; // Salta a la etiqueta "Inicio".
			}
		}
	}
}
