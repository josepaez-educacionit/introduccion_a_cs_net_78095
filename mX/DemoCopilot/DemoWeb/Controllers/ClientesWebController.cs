using Microsoft.AspNetCore.Mvc;
using DemoWeb.Services.Interfaces;
using DemoWeb.Models;

namespace DemoWeb.Controllers
{
    public class ClientesWebController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly ILogger<ClientesWebController> _logger;

        public ClientesWebController(IClienteService clienteService, ILogger<ClientesWebController> logger)
        {
            _clienteService = clienteService;
            _logger = logger;
        }

        // GET: ClientesWeb
        public async Task<IActionResult> Index()
        {
            try
            {
                var clientes = await _clienteService.GetAllAsync();
                return View(clientes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los clientes");
                TempData["Error"] = "Error al cargar los clientes";
                return View(new List<Cliente>());
            }
        }

        // GET: ClientesWeb/Details/5
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var cliente = await _clienteService.GetByIdAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el cliente con ID: {Id}", id);
                return NotFound();
            }
        }

        // GET: ClientesWeb/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientesWeb/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _clienteService.CreateAsync(cliente);
                    TempData["Success"] = "Cliente creado exitosamente";
                    return RedirectToAction(nameof(Index));
                }
                return View(cliente);
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("Email", ex.Message);
                return View(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear cliente");
                TempData["Error"] = "Error al crear el cliente";
                return View(cliente);
            }
        }

        // GET: ClientesWeb/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var cliente = await _clienteService.GetByIdAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el cliente para editar con ID: {Id}", id);
                return NotFound();
            }
        }

        // POST: ClientesWeb/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _clienteService.UpdateAsync(id, cliente);
                    if (result == null)
                    {
                        return NotFound();
                    }
                    TempData["Success"] = "Cliente actualizado exitosamente";
                    return RedirectToAction(nameof(Index));
                }
                return View(cliente);
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("Email", ex.Message);
                return View(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar cliente con ID: {Id}", id);
                TempData["Error"] = "Error al actualizar el cliente";
                return View(cliente);
            }
        }

        // GET: ClientesWeb/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _clienteService.GetByIdAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el cliente para eliminar con ID: {Id}", id);
                return NotFound();
            }
        }

        // POST: ClientesWeb/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var result = await _clienteService.DeleteAsync(id);
                if (!result)
                {
                    return NotFound();
                }
                TempData["Success"] = "Cliente eliminado exitosamente";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar cliente con ID: {Id}", id);
                TempData["Error"] = "Error al eliminar el cliente";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}