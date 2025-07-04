namespace _01_Control_de_Flujo_de_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =============================
            // CONTROL DE FLUJO DE PROGRAMA
            // =============================
            // El control de flujo determina el orden en que se ejecutan las instrucciones de un programa.
            // Permite tomar decisiones, repetir acciones y seleccionar entre diferentes caminos de ejecución.
            // Las principales estructuras de control de flujo son: condicionales (if, switch) y cíclicas (while, for, etc.).

            // ¿Por qué es importante el control de flujo?
            // Permite que el programa:
            // - Tome decisiones según condiciones.
            // - Repita acciones múltiples veces.
            // - Ejecute diferentes bloques de código según el contexto.

            // =============================
            // ESTRUCTURAS CONDICIONALES
            // =============================

            // --- Instrucción if ---
            // Permite ejecutar un bloque de código solo si se cumple una condición booleana.
            // Sintaxis:
            //      if (condición)
            //      {
            //          // Código a ejecutar si la condición es verdadera
            //      }

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

            // Ejemplo 3: Verificar si un usuario es mayor de edad
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

            // Ejemplo 5: Verificar si un número está dentro de un rango específico
            int numero2 = 5;
            if (numero2 >= 1 && numero2 <= 10)
            {
                Console.WriteLine("El número está dentro del rango de 1 a 10.");
            }

            // --- Instrucción if-else ---
            // Permite ejecutar un bloque de código si la condición es verdadera y otro si es falsa.
            // Sintaxis:
            //      if (condición)
            //      {
            //          // Código si la condición es verdadera
            //      }
            //      else
            //      {
            //          // Código si la condición es falsa
            //      }

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

            // --- Instrucción if-else if-else ---
            // Permite evaluar múltiples condiciones de forma secuencial.
            // Sintaxis:
            //      if (condición1)
            //      {
            //          // Código si condición1 es verdadera
            //      }
            //      else if (condición2)
            //      {
            //          // Código si condición2 es verdadera
            //      }
            //      else
            //      {
            //          // Código si ninguna condición anterior es verdadera
            //      }

            // Ejemplo: Verificar si un número es positivo, negativo o cero
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

            // --- Instrucción switch ---
            // Permite seleccionar entre múltiples opciones según el valor de una expresión.
            // Es útil cuando se tienen muchos casos posibles para una misma variable.
            // Sintaxis:
            //      switch (expresión)
            //      {
            //          case valor1:
            //              // Código si expresión == valor1
            //              break;
            //          case valor2:
            //              // Código si expresión == valor2
            //              break;
            //          ...
            //          default:
            //              // Código si no coincide ningún caso
            //              break;
            //      }

            // Ejemplo: Mostrar el día de la semana según un número
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

            // =============================
            // ESTRUCTURAS CÍCLICAS (BUCLES)
            // =============================
            // Permiten repetir un bloque de código mientras se cumpla una condición.

            // --- Bucle while ---
            // Ejecuta un bloque de código mientras la condición sea verdadera.
            // Sintaxis:
            //      while (condición)
            //      {
            //          // Código a ejecutar mientras la condición sea verdadera
            //      }

            // Ejemplo 1: Imprimir los números del 1 al 5
            int contador = 1;
            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Ejemplo 2: Calcular la suma de los primeros 10 números naturales
            int sumaNumerosNaturales = 0;
            int numeroActual = 1;
            while (numeroActual <= 10)
            {
                sumaNumerosNaturales += numeroActual;
                numeroActual++;
            }

			#region Break y Continue
			// Los operadores break y continue se utilizan para controlar el flujo de ejecución dentro de los bucles.
			// Operador Break: se utiliza para salir de un bucle antes de que se complete su iteración normal.
			// Operador Continue: se utiliza para saltar a la siguiente iteración de un bucle.
			#endregion

			// Ejemplo: Uso de break en un bucle while
			// 'break' termina el bucle inmediatamente.
			int numeroConBreak = 1;
            while (true)
            {
                Console.WriteLine(numeroConBreak);
                numeroConBreak++;
                if (numeroConBreak > 5)
                {
                    break;
                }
            }

            // Ejemplo: Uso de continue en un bucle while
            // 'continue' salta a la siguiente iteración del bucle.
            int numeroConContinue = 1;
            while (numeroConContinue <= 5)
            {
                if (numeroConContinue == 3)
                {
                    numeroConContinue++;
                    continue; // Salta la impresión cuando el número es 3
                }
                Console.WriteLine(numeroConContinue);
                numeroConContinue++;
            }
        }
    }
}
