using System;

namespace InterfazGraficaWeb.Models
{
    // Modelo Persona para la demo CRUD en memoria
    public class Persona
    {
        // Identificador único de la persona
        public int PersonaId { get; set; }
        // Nombre de la persona
        public string Nombre { get; set; }
        // Apellido de la persona
        public string Apellido { get; set; }
        // Fecha de nacimiento
        public DateTime FechaNacimiento { get; set; }
        // Número de documento
        public string NumeroDocumento { get; set; }
        // Domicilio
        public string Domicilio { get; set; }
        // Teléfono
        public string Telefono { get; set; }
    }
}
