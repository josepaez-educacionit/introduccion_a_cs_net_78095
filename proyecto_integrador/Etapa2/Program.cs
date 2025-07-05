namespace Etapa2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bienvenidos al proyecto integrador Etapa 2");

			string Nombre;
			string Apellido;
			int Edad;
			string Email;

			string Respuesta;

			// Ingreso de datos del alumno
			Console.Write("Ingrese su nombre: ");
			Nombre = Console.ReadLine();
			Console.Write("Ingrese su apellido: ");
			Apellido = Console.ReadLine();
			Console.Write("Ingrese su edad: ");
			Edad = int.Parse(Console.ReadLine());
			Console.Write("Ingrese su email: ");
			Email = Console.ReadLine();

			// Mostrar los datos ingresados
			Console.WriteLine("<<<< Datos del alumno >>>>");
			Console.WriteLine($"Nombre: {Nombre}");
			Console.WriteLine($"Apellido: {Apellido}");
			Console.WriteLine($"Edad: {Edad}");
			Console.WriteLine($"Email: {Email}");

			Console.WriteLine("¿Los datos son correctos? - 'S' para confirmar 'N' para cancelar");
			Respuesta = Console.ReadLine();
		}
	}
}
