namespace _01_Control_de_Flujo_de_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Control de Flujo de Programa
			// El control de flujo de un programa se refiere a la forma en que se ejecutan las instrucciones en un programa.
			// Existen diferentes tipos de estructuras de control de flujo, como las instrucciones condicionales y las estructuras cíclicas.

			// Porque es importante el control de flujo?
			// El control de flujo es importante porque permite que un programa tome decisiones, repita acciones
			// y ejecute diferentes bloques de código según las condiciones.

			// Instrucción Condicional
			// Las instrucciones condicionales permiten que el programa tome decisiones basadas en condiciones específicas.
			// Estas instrucciones permiten ejecutar diferentes bloques de código según si una condición es verdadera o falsa.

			// if
			// La instrucción if evalúa una condición y ejecuta un bloque de código si la condición es verdadera.
			// Se utiliza para ejecutar código condicionalmente, es decir, si una condición se cumple
			// Sintaxis
			//		if (condición)
			//		{
			//			// Código a ejecutar si la condición es verdadera
			//		}

			// Ejemplo 1: Verificar si un número es positivo
			int numero = -10;
			if (numero > 0)
			{
				Console.WriteLine("El número es positivo.");
			}

			// Ejemplo 2: Verificar si un número es par
			int numero1 = 7;
			if (numero1 % 2 == 0)
			{
				Console.WriteLine("El número es par.");
			}

			//  Ejemplo 3: Verificar si un usuario es mayor de edad
			int edad = 18;
			if (edad >= 18)
			{
				Console.WriteLine("El usuario es mayor de edad.");
			}

			// Ejemplo 4: Verificar si una cadena no está vacía
			string texto = "Hola";
			if (!string.IsNullOrEmpty(texto))
			{
				Console.WriteLine("La cadena no está vacía.");
			}

			// Ejemplo 5: Verificar si un número está dentro de un rango
			int numero2 = 5;
			if (numero2 >= 1 && numero2 <= 10)
			{
				Console.WriteLine("El número está dentro del rango de 1 a 10.");
			}



			// if-else
			// La instrucción if-else permite ejecutar un bloque de código si la condición es verdadera y otro bloque si es falsa.
			// Se utiliza para ejecutar código condicionalmente, es decir, si una condición se cumple
			// Sintaxis
			//		if (condición)
			//		{
			//			// Código a ejecutar si la condición es verdadera
			//		}
			//		else
			//		{
			//			// Código a ejecutar si la condición es falsa
			//		}


			// Ejemplo 1: Verificar si un número es positivo o negativo
			int numero3 = -5;
			if (numero3 > 0)
			{
				Console.WriteLine("El número es positivo.");
			}
			else
			{
				Console.WriteLine("El número es negativo.");
			}

			// Ejemplo 2: Verificar si un número es par o impar
			int numero4 = 7;
			if (numero4 % 2 == 0)
			{
				Console.WriteLine("El número es par.");
			}
			else
			{
				Console.WriteLine("El número es impar.");
			}

			// Ejemplo 3: Verificar si un número está dentro o fuera de un rango
			int numero5 = 15;
			if (numero5 >= 1 && numero5 <= 10)
			{
				Console.WriteLine("El número está dentro del rango de 1 a 10.");
			}
			else
			{
				Console.WriteLine("El número está fuera del rango de 1 a 10.");
			}


			// if-else if-else
			// La instrucción if-else if-else permite evaluar múltiples condiciones secuencialmente.
			// Se utiliza para ejecutar código condicionalmente, es decir, si una de varias condiciones
			// Sintaxis
			//  if (condición1)
			//  {
			//      // Código a ejecutar si la condición1 es verdadera
			//  }
			//  else if (condición2)
			//  {   
			//      // Código a ejecutar si la condición2 es verdadera
			//  }
			//  else
			//  {
			//      // Código a ejecutar si ninguna de las condiciones anteriores es verdadera
			//  }


			// Ejemplo 1: Verificar si un número es positivo, negativo o cero
			int numero6 = -9;
			if (numero6 > 0)
			{
				Console.WriteLine("El número es positivo.");
			}
			else if (numero6 < 0)
			{
				Console.WriteLine("El número es negativo.");
			}
			else
			{
				Console.WriteLine("El número es cero.");
			}


			// Switch
			// La instrucción switch permite evaluar una expresión y ejecutar un bloque de código basado en el valor de esa expresión.
			// Se utiliza para seleccionar entre múltiples opciones basadas en el valor de una variable o expresión
			// Sintaxis
			//  switch (expresión)
			//  {
			//      case valor1:    
			//          // Código a ejecutar si la expresión es igual a valor1
			//          break;
			//      case valor2:
			//          // Código a ejecutar si la expresión es igual a valor2
			//          break;
			//      ...
			//      default:
			//          // Código a ejecutar si la expresión no coincide con ningún caso
			//          break;
			//  }

			// Ejemplo 1: Días de la semana
			int dia = -56;
			switch (dia)
			{
				case 1:
					Console.WriteLine("Lunes");
					break;
				case 2:
					Console.WriteLine("Martes");
					break;
				case 3:
					Console.WriteLine("Miércoles");
					break;
				case 4:
					Console.WriteLine("Jueves");
					break;
				case 5:
					Console.WriteLine("Viernes");
					break;
				case 6:
					Console.WriteLine("Sábado");
					break;
				case 7:
					Console.WriteLine("Domingo");
					break;
				default:
					Console.WriteLine("Día inválido");
					break;
			}
		}
	}
}
