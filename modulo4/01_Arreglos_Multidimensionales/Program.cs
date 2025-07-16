namespace _01_Arreglos_Multidimensionales
{
	internal class Program
	{

		// Arreglos Multidimensionales
		// Un arreglo multidimensional es una colección de datos organizados en filas y columnas.
		// Se pueden considerar como una tabla o matriz.
		// Un arreglo multidimensional se declara especificando el número de dimensiones y el tamaño de cada dimensión.

		static void Main(string[] args)
		{
			// Declaración de un arreglo multidimensional
			int[,] matriz = new int[3, 3];

			// Escritura y lectura de un dato
			matriz[0, 0] = 1;
			matriz[1, 0] = 2;
			matriz[2, 0] = 3;

			// Lectura de valores de la matriz
			int dato1 = matriz[0, 0];
			int dato2 = matriz[1, 0];
			int dato3 = matriz[2, 0];

			// Declaración e inicialización
			// Se puede declarar e inicializar un arreglo multidimensional en una sola línea
			int[,] matriz2 = new int[3, 3]
			{
				{ 1, 2, 3 },
				{ 4, 546, 6 },
				{ 7, 8, 9 }
			};
			
			// Impresión del arreglo completo 
			Console.WriteLine("Contenido de la matriz:");
			for (int i = 0; i < matriz2.GetLength(0); i++)
			{
				for (int j = 0; j < matriz2.GetLength(1); j++)
				{
					Console.Write(matriz2[i, j] + " ");
				}
				Console.WriteLine();
			}


			// Encontrar el mayor valor en un arreglo
			// Se recorre el arreglo para encontrar el mayor valor
			int mayor = matriz2[0, 0];
			for (int i = 0; i < matriz2.GetLength(0); i++)
			{
				for (int j = 0; j < matriz2.GetLength(1); j++)
				{
					if (matriz2[i, j] > mayor)
					{
						mayor = matriz2[i, j];
					}
				}
			}
			Console.WriteLine("El mayor valor es: " + mayor);
		}
	}
}
