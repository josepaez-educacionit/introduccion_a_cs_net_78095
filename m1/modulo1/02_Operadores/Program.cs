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

			// Operadores relacionales:
			// Los Operadores relacionales se utilizan para comparar dos valores y devolver un valor booleano (verdadero o falso).
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

			// Operadores lógicos:
			// Los Operadores lógicas se utilizan para combinar o invertir condiciones booleanas.
			//      !	: Negación lógica
			//      &&	: Y lógico
			//      ||	: O lógico

			bool esCondicionVerdadera = false;
			bool esCondicionFalsa = false;

			Console.WriteLine($"\n=== OPERACIONES LÓGICAS ===");

			// !	: Negación lógica
			bool resultadoNegacion = !esCondicionVerdadera;
			Console.WriteLine($"Negación lógica (!): !{esCondicionVerdadera} = {resultadoNegacion}");

			// &&	: Y lógico | AND lógico
			//		Evaluará a verdadero solo si ambas condiciones son verdaderas.
			//		Si una de las condiciones es falsa, el resultado será falso.
			bool resultadoAnd = esCondicionVerdadera && esCondicionFalsa;
			Console.WriteLine($"Resultado AND: {resultadoAnd}");

			// ||	: O lógico | OR lógico
			//      Si alguna de las condiciones es verdadera, el resultado es verdadero.
			bool resultadoOr = esCondicionVerdadera || esCondicionFalsa;
			Console.WriteLine($"Resultado OR: {resultadoOr}");


			// Operadores de asignación:
			//      =	: Asignación simple
			//      +=	: Asignación con suma
			//      -=	: Asignación con resta
			//      *=	: Asignación con multiplicación
			//      /=	: Asignación con división
			//      %=	: Asignación con módulo

			Console.WriteLine($"\n=== OPERADORES DE ASIGNACION ===");

			int numeroC = 5;
			
			numeroC += 3;   
			Console.WriteLine($"Valor de numeroC después de += 3: {numeroC}");

			numeroC -= 2;
			Console.WriteLine($"Valor de numeroC después de -= 2: {numeroC}");

			numeroC *= 2;
			Console.WriteLine($"Valor de numeroC después de *= 2: {numeroC}");

			numeroC /= 4;
			Console.WriteLine($"Valor de numeroC después de /= 4: {numeroC}");

			numeroC %= 3;
			Console.WriteLine($"Valor de numeroC después de %= 3: {numeroC}");

			// Operadores de incremento y decremento:
			// Los Operadores de incremento y decremento se utilizan para aumentar o disminuir el valor de una variable en 1.  
			//      ++	: Incremento
			//      --	: Decremento

			Console.WriteLine($"\n=== OPERADORES DE INCREMENTO Y DECREMENTO ===");
			int numeroD = 5;
			Console.WriteLine($"Valor de numeroD antes del incremento: {numeroD}");
			numeroD++;
			Console.WriteLine($"Valor de numeroD después del incremento: {numeroD}");
			numeroD--;
			Console.WriteLine($"Valor de numeroD después del decremento: {numeroD}");

			// Operador condicional ternario:
			//      El operador condicional ternario es una forma abreviada de escribir una estructura if-else.
			//      Sintaxis:   
			//      condición ? expresión1 : expresión2

			int edad = 17;
			string mensaje = (edad >= 18) ? "Es mayor de edad" : "Es menor de edad";
			Console.WriteLine($"\n=== OPERADOR CONDICIONAL TERNARIO ===");
			Console.WriteLine($"Edad: {edad}");
			Console.WriteLine($"Mensaje: {mensaje}");
		}


	}
}