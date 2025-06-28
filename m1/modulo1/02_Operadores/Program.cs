using System.Reflection;

namespace _02_Operadores
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Operadores
			//      Un operador es un símbolo que le dice al compilador que realice una operación matemática o lógica.

			// Operadores Aritméticos
			//      +	: Suma dos operandos.
			//      -	: Resta dos operandos.
			//      *	: Multiplica dos operandos.
			//      /	: Divide dos operandos.
			//      %	: Devuelve el residuo de una división.

			int numero1 = 10;
			int numero2 = 20;

			int suma = numero1 + numero2;
			int resta = numero1 - numero2;
			int multiplicacion = numero1 * numero2;
			int division = numero1 / numero2;
			int residuo = numero1 % numero2;

			Console.WriteLine($"variables: numero1 = {numero1}, numero2 = {numero2}");
			Console.WriteLine($"Suma: {suma}");
			Console.WriteLine($"Resta: {resta}");
			Console.WriteLine($"Producto: {multiplicacion}");
			Console.WriteLine($"División: {division}");
			Console.WriteLine($"Módulo: {residuo}");


			// Operador de Concatenación
			string saludo = "Hola" + " Mundo";
			Console.WriteLine(saludo);

			// Operaciones relacionales:
			//      ==	: Igual a
			//      !=	: Diferente de
			//      >	: Mayor que
			//      <	: Menor que
			//      >=	: Mayor o igual que
			//      <=	: Menor o igual que

			Console.WriteLine("\n=== OPERADORES RELACIONALES ===");
			Console.WriteLine($"Variables: numero1 = {numero1}, numero2 = {numero2}\n");
			
			Console.WriteLine($"Igual a (==)           : {numero1} == {numero2} = {numero1 == numero2}");
			Console.WriteLine($"Diferente de (!=)      : {numero1} != {numero2} = {numero1 != numero2}");
			Console.WriteLine($"Mayor que (>)          : {numero1} > {numero2}  = {numero1 > numero2}");
			Console.WriteLine($"Menor que (<)          : {numero1} < {numero2}  = {numero1 < numero2}");
			Console.WriteLine($"Mayor o igual que (>=) : {numero1} >= {numero2} = {numero1 >= numero2}");
			Console.WriteLine($"Menor o igual que (<=) : {numero1} <= {numero2} = {numero1 <= numero2}");

			// Operaciones lógicas:
			//      &&	: Y lógico
			//      ||	: O lógico


			// Operaciones de asignación:
			//      =	: Asignación
			//      +=	: Asignación con suma
			//      -=	: Asignación con resta
			//      *=	: Asignación con multiplicación
			//      /=	: Asignación con división
			//      %=	: Asignación con módulo

			// Operaciones de incremento y decremento:
			//      ++	: Incremento
			//      --	: Decremento
		}
	}
}