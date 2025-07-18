namespace _01_Estructuras
{
	// Estructuras: Son tipos de datos que permiten almacenar diferentes tipos de datos.
	// Se definen con la palabra reservada struct.
	// Sintaxis:
	// struct NombreEstructura
	// {
	//     tipoDato1 nombreDato1;
	//     tipoDato2 nombreDato2;
	//     ...
	// }
	internal class Program
	{
		struct Persona
		{
			public string Nombre;
			public string Apellido;
			string TipoDocumento;
			public int NumeroDocumento;
			public DateTime fechaNacimiento;
			public string Sexo;
			public string Telefono;
			public string Domicilio;
		}

		public struct Cliente
		{
			public int Codigo;
			public string Nombre;
			public string Apellido;
			public string CUIT;
			public string Domicilio;
		}

		public struct Vehiculo
		{
			public string Marca;
			public string Modelo;
			public int Año;
			public double Precio;
		}

		static void Main(string[] args)
		{
			// Declaracion
			Persona unaPersona;
			Persona otraPersona;

			// Asignacion de datos
			unaPersona.Nombre = "Juan";
			unaPersona.Apellido = "Perez";
			unaPersona.NumeroDocumento = 50123976;
			unaPersona.Domicilio = "";


			otraPersona.Nombre = "Maria";
			otraPersona.Apellido = "Sanchez";

			// Mostrar datos
			Console.WriteLine($" Nombre {unaPersona.Nombre}");
			Console.WriteLine($" Apellido {unaPersona.Apellido}");
			Console.WriteLine($" Numero Documento {unaPersona.NumeroDocumento}");
			Console.WriteLine($" Domicilio {unaPersona.Domicilio}");

			// Declaracion del Arreglo Tipo "Persona"
			Persona[] personas = new Persona[3];


			// Asignacion de valores
			personas[0].Apellido = "Perez";
			personas[0].Nombre = "Juan";
			personas[0].NumeroDocumento = 50123976;

			personas[1].Apellido = "Sanchez";
			personas[1].Nombre = "Maria";
			personas[1].NumeroDocumento = 12345678;

			personas[2].Apellido = "Rodriguez";
			personas[2].Nombre = "Alberto";
			personas[2].NumeroDocumento = 45123987;


			// Mostrar datos
			Console.WriteLine($" Nombre: {personas[2].Nombre}");
			Console.WriteLine($" Apellido: {personas[2].Apellido}");
			Console.WriteLine($" Numero Documento: {personas[2].NumeroDocumento}");

			Console.WriteLine("-- Datos en el Arreglo Personas--");
			// Mostrar datos en el arreglo de Personas
			for (int i = 0; i < personas.Length; i++)
			{
				Console.WriteLine($" Nombre: {personas[i].Nombre}");
				Console.WriteLine($" Apellido: {personas[i].Apellido}");
				Console.WriteLine($" Numero Documento: {personas[i].NumeroDocumento}");
			}


			Console.WriteLine("-- Datos en el Arreglo Vehiculos --");
			Vehiculo[] vehiculos = new Vehiculo[3];

			vehiculos[0].Marca = "Toyota";
			vehiculos[0].Modelo = "Corolla";
			vehiculos[0].Año = 2020;
			vehiculos[0].Precio = 20000;

			vehiculos[1].Marca = "Ford";
			vehiculos[1].Modelo = "Fiesta";
			vehiculos[1].Año = 2019;
			vehiculos[1].Precio = 15000;

			vehiculos[2].Marca = "Honda";
			vehiculos[2].Modelo = "Civic";
			vehiculos[2].Año = 2021;
			vehiculos[2].Precio = 25000;

			for (int i = 0; i < vehiculos.Length; i++)
			{
				Console.WriteLine($"Marca: {vehiculos[i].Marca}, Modelo: {vehiculos[i].Modelo}, Año: {vehiculos[i].Año}, Precio: {vehiculos[i].Precio}");
			}
		}
	}
}
