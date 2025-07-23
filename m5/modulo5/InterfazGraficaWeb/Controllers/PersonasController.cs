using InterfazGraficaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InterfazGraficaWeb.Controllers
{
    // Controlador para gestionar el CRUD de Persona
    public class PersonasController : Controller
    {
        // Lista estática para simular almacenamiento en memoria
        private static List<Persona> personas = new List<Persona>();
        // Variable para generar IDs únicos
        private static int nextId = 1;

        // GET: Personas
        public IActionResult Index()
        {
            // Devuelve la lista de personas
            return View(personas);
        }

        // GET: Personas/Details/5
        public IActionResult Details(int id)
        {
            var persona = personas.FirstOrDefault(p => p.PersonaId == id);
            if (persona == null)
                return NotFound();
            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                persona.PersonaId = nextId++;
                personas.Add(persona);
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public IActionResult Edit(int id)
        {
            var persona = personas.FirstOrDefault(p => p.PersonaId == id);
            if (persona == null)
                return NotFound();
            return View(persona);
        }

        // POST: Personas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Persona persona)
        {
            if (id != persona.PersonaId)
                return NotFound();
            if (ModelState.IsValid)
            {
                var personaExistente = personas.FirstOrDefault(p => p.PersonaId == id);
                if (personaExistente == null)
                    return NotFound();
                // Actualizar propiedades
                personaExistente.Nombre = persona.Nombre;
                personaExistente.Apellido = persona.Apellido;
                personaExistente.FechaNacimiento = persona.FechaNacimiento;
                personaExistente.NumeroDocumento = persona.NumeroDocumento;
                personaExistente.Domicilio = persona.Domicilio;
                personaExistente.Telefono = persona.Telefono;
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public IActionResult Delete(int id)
        {
            var persona = personas.FirstOrDefault(p => p.PersonaId == id);
            if (persona == null)
                return NotFound();
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var persona = personas.FirstOrDefault(p => p.PersonaId == id);
            if (persona != null)
                personas.Remove(persona);
            return RedirectToAction(nameof(Index));
        }
    }
}
