using System;

namespace _02_Enumeraciones
{
    // Ejemplo didáctico sobre el uso de enumeraciones (enum) en C#.
    // Se muestra cómo declarar enumeraciones para representar conjuntos de constantes relacionadas
    // y cómo utilizarlas en estructuras y variables.
    internal class Program
    {
        // Constante matemática PI (no se utiliza en este ejemplo, solo como referencia)
        const double PI = 3.141516;

        // Enumeración que representa los diferentes tipos de cuentas bancarias.
        public enum TipoCuenta
        {
            CajaAhorro,        // Cuenta de caja de ahorro
            CuentaCorriente,   // Cuenta corriente
            CuentaSueldo       // Cuenta sueldo
        }

        // Enumeración que representa los posibles estados de un pedido.
        public enum EstadoPedido
        {
            Pendiente,     // Pedido pendiente de envío
            Enviado,       // Pedido enviado
            Entregado,     // Pedido entregado
            Cancelado,     // Pedido cancelado
            Devuelto       // Pedido devuelto
        }

        // Enumeración que representa los días de la semana.
        public enum DiasSemana
        {
            Lunes,
            Martes,
            Miércoles,
            Jueves,
            Viernes,
            Sábado,
            Domingo
        }

        // Enumeración que representa los tipos de documento de identidad.
        public enum TipoDocumento
        {
            DNI,        // Documento Nacional de Identidad
            Pasaporte,  // Pasaporte
            Cedula      // Cédula de identidad
        }

        // Estructura que representa una persona, utilizando una enumeración para el tipo de documento.
        struct Persona
        {
            public string Nombre;           // Nombre de la persona
            public string Apellido;         // Apellido de la persona
            public TipoDocumento TipoDocumento; // Tipo de documento (usando la enumeración)
            public int NumeroDocumento;     // Número de documento
        }

        // Método principal del programa. Demuestra la declaración y uso de enumeraciones y su integración en estructuras.
        static void Main(string[] args)
        {
            // Ejemplo: Uso de la estructura Persona con enumeración TipoDocumento
            Persona unaPersona = new Persona();
            unaPersona.TipoDocumento = TipoDocumento.DNI;
            Console.WriteLine("Datos de Tipo de Documento");

            // Ejemplo: Declaración y asignación de variables de tipo enum TipoCuenta
            TipoCuenta cuenta1, cuenta2, cuenta3;
            cuenta1 = TipoCuenta.CuentaCorriente;
            cuenta2 = TipoCuenta.CuentaSueldo;
            cuenta3 = TipoCuenta.CajaAhorro;

            // Mostrar los valores de las variables de tipo enum
            Console.WriteLine($"La cuenta1 es de tipo: {cuenta1}");
            Console.WriteLine($"La cuenta2 es de tipo: {cuenta2}");
            Console.WriteLine($"La cuenta3 es de tipo: {cuenta3}");

            // Ejemplo: Uso de la enumeración EstadoPedido
            EstadoPedido estado = EstadoPedido.Enviado;
            Console.WriteLine($"El estado del pedido es: {estado}");
        }
    }
}
