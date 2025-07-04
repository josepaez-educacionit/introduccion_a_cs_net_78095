namespace _01_Instrucciones_de_Bucles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Las estructuras cíclicas o iterativas o de bucle permiten ejecutar un bloque de código repetidamente mientras se cumpla una condición.
			// Existen tres tipos de estructuras cíclicas en C#:
			// 1. while: ejecuta un bloque de código mientras una condición sea verdadera.
			// 2. do...while: ejecuta un bloque de código al menos una vez
			//    y luego repite la ejecución mientras una condición sea verdadera.
			// 3. for: ejecuta un bloque de código un número específico de veces.


			// Instrucción while.
			// La instrucción while se utiliza para ejecutar un bloque de código mientras una condición sea verdadera.
			// Es útil cuando no se conoce de antemano cuántas veces se debe ejecutar
			// Sintaxis:
			// while (condición)
			// {
			//     // Código a ejecutar.
			// }

			// Ejemplo 1: Ejemplo de suma de números
			// En este caso, se utiliza el bucle while para seguir solicitando números hasta que la suma acumulada sea igual o mayor a 100.

			/*
					int suma = 0;
					int numero;

					while (suma < 100)
					{
						Console.Write("Ingresa un número: ");
						numero = int.Parse( Console.ReadLine() );
						suma += numero;
					}
					Console.WriteLine($"La suma total es: {suma}");
			*/


			// Ejemplo 2: Ejemplo de impresión de números pares del 1 al 10.
			/*
					int num = 1;
					while (num <= 10)
					{
						Console.WriteLine($"La variable num es igual a {num}");
						if (num % 2 == 0)
						{
							Console.WriteLine(num);
						}
						num++;
					}
			*/

			// Instrucción do...while.
			// La instrucción do...while es similar a la instrucción while, pero garantiza que el bloque de código se ejecute al menos una vez antes de verificar la condición.
			// Es útil cuando se necesita ejecutar el código al menos una vez, independientemente de la
			// Sintaxis:
			// do
			// {
			//     // Código a ejecutar.
			// } while (condición);


			// Ejemplo 1: validación de entrada de usuario: solicitar al usuario que responda "s" o "n" para continuar o terminar un proceso.
			/*
					string respuesta;
					do
					{
						Console.Write("¿Quieres continuar? (s/n): ");
						respuesta = Console.ReadLine();
					}
					while (respuesta.ToLower() != "s" && respuesta.ToLower() != "n");

					if (respuesta.ToLower() == "s")
					{
						Console.WriteLine("Continuando...");
					}
					else
					{
						Console.WriteLine("Terminando...");
					}
			*/

			// Ejemplo 2: Menú con opciones: mostrar un menú de opciones al usuario. El bucle se repetirá hasta que el usuario elija la opción de salir (3).
			/*
						int opcion;
						do
						{
							Console.WriteLine("Menú:");
							Console.WriteLine("1. Opción 1");
							Console.WriteLine("2. Opción 2");
							Console.WriteLine("3. Salir");
							Console.Write("Elige una opción: ");
							opcion = int.Parse(Console.ReadLine());

							switch (opcion)
							{
								case 1:
									Console.WriteLine("Seleccionaste la opción 1.");
									break;
								case 2:
									Console.WriteLine("Seleccionaste la opción 2.");
									break;
								case 3:
									Console.WriteLine("Saliendo del menú...");
									break;
								default:
									Console.WriteLine("Opción inválida.");
									break;
							}
						} while (opcion != 3);
						Console.WriteLine("Fin del programa.");
			*/


			// Instrucción for.
			// La instrucción for se utiliza para ejecutar un bloque de código un número específico de veces.
			// Es útil cuando se conoce de antemano cuántas veces se debe ejecutar el
			// Sintaxis:
			// for (inicialización; condición; incremento)
			// {
			//     // Código a ejecutar.
			// }


			// Ejemplo 1: Imprimir los números del 1 al 10.
			/*
				for (int i = 1; i <= 10; i++)
				{
					Console.WriteLine(i);
				}
			*/

			// Ejemplo 2: Un ejemplo más avanzado que suma los números del 1 al 100:
			/*
						int sum = 0;
						for (int i = 1; i <= 100; i++)
						{
							sum += i;
						}
						Console.WriteLine("La suma de los números del 1 al 100 es: " + sum);
			*/


			// Ejemplo 2: Tabla de Multiplicación
			Console.WriteLine("Ingrese un número para imprimir su tabla de multiplicar: ");
			int numero = int.Parse( Console.ReadLine() ) ;
			for (int i = 1; i <= 10; i++) 
			{
				Console.WriteLine($"{numero} x {i} = {numero * i}");
			}
		}
	}
}
