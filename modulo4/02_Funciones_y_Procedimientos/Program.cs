namespace _02_Funciones_y_Procedimientos
{
	internal class Program
	{
		// Funciones y Procedimientos
		// Las funciones y procedimientos son bloques de código que realizan una tarea específica.
		// Se utilizan para organizar el código, evitar la repetición y mejorar la legibilidad.

		// Funciones: Las funciones son subprogramas que devuelven un valor.
		// Procedimientos: Los procedimientos son subprogramas que no devuelven un valor.

		static void Main(string[] args)
		{

			int suma;
			suma = Sumar(658, 7964);
			ImprimirMensaje($"Suma : {suma}");

			suma = Sumar(98, 12);
			ImprimirMensaje($"Suma : {suma}");

			Console.Clear();
			Console.WriteLine( "Parametros por Valor/Referencia" );
			int num1 = 321; int num2 = 456;
			Console.Write( $"num1: {num1} | num2: {num2}");
			
			suma = SumarPorRef(ref num1, ref num2);
			ImprimirMensaje($"Suma : {suma}");

			Console.Write($"num1: {num1} | num2: {num2}");

		}

		static int Sumar(int num1, int num2)
		{
			int suma = num1 + num2;
			return suma;
		}

		static int SumarPorRef(ref int num1, ref int num2)
		{
			int suma = num1 + num2;
			num1++; num2--;
			return suma;
		}

		static void ImprimirMensaje(string mensaje)
		{
			Console.WriteLine(mensaje);
		}
	}
	
}
