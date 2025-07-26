using Microsoft.AspNetCore.Mvc;
using DemoWeb.Services.Interfaces;
using DemoWeb.DTOs;
using DemoWeb.Extensions;

namespace DemoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(IClienteService clienteService, ILogger<ClientesController> logger)
        {
            _clienteService = clienteService;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene todos los clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteResponseDto>>> GetClientes()
        {
            try
            {
                _logger.LogInformation("Obteniendo todos los clientes");
                var clientes = await _clienteService.GetAllAsync();
                return Ok(clientes.ToResponseDto());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los clientes");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Obtiene un cliente por ID
        /// </summary>
        /// <param name="id">ID del cliente</param>
        /// <returns>Cliente encontrado</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteResponseDto>> GetCliente(int id)
        {
            try
            {
                _logger.LogInformation("Obteniendo cliente con ID: {Id}", id);
                var cliente = await _clienteService.GetByIdAsync(id);
                
                if (cliente == null)
                {
                    _logger.LogWarning("Cliente con ID {Id} no encontrado", id);
                    return NotFound($"Cliente con ID {id} no encontrado");
                }

                return Ok(cliente.ToResponseDto());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el cliente con ID: {Id}", id);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Crea un nuevo cliente
        /// </summary>
        /// <param name="clienteDto">Datos del cliente a crear</param>
        /// <returns>Cliente creado</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<ClienteResponseDto>> CreateCliente([FromBody] ClienteCreateDto clienteDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogWarning("Datos inválidos para crear cliente: {Errors}", 
                        string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
                    return BadRequest(ModelState);
                }

                _logger.LogInformation("Creando nuevo cliente: {Email}", clienteDto.Email);
                var cliente = clienteDto.ToEntity();
                var clienteCreado = await _clienteService.CreateAsync(cliente);

                _logger.LogInformation("Cliente creado exitosamente con ID: {Id}", clienteCreado.Id);
                return CreatedAtAction(nameof(GetCliente), 
                    new { id = clienteCreado.Id }, 
                    clienteCreado.ToResponseDto());
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogWarning("Conflicto al crear cliente: {Message}", ex.Message);
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear cliente");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Actualiza un cliente existente
        /// </summary>
        /// <param name="id">ID del cliente a actualizar</param>
        /// <param name="clienteDto">Datos actualizados del cliente</param>
        /// <returns>Cliente actualizado</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<ClienteResponseDto>> UpdateCliente(int id, [FromBody] ClienteUpdateDto clienteDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogWarning("Datos inválidos para actualizar cliente ID {Id}: {Errors}", 
                        id, string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
                    return BadRequest(ModelState);
                }

                _logger.LogInformation("Actualizando cliente con ID: {Id}", id);
                var cliente = clienteDto.ToEntity();
                var clienteActualizado = await _clienteService.UpdateAsync(id, cliente);

                if (clienteActualizado == null)
                {
                    _logger.LogWarning("Cliente con ID {Id} no encontrado para actualizar", id);
                    return NotFound($"Cliente con ID {id} no encontrado");
                }

                _logger.LogInformation("Cliente con ID {Id} actualizado exitosamente", id);
                return Ok(clienteActualizado.ToResponseDto());
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogWarning("Conflicto al actualizar cliente ID {Id}: {Message}", id, ex.Message);
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar cliente con ID: {Id}", id);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="id">ID del cliente a eliminar</param>
        /// <returns>Resultado de la operación</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            try
            {
                _logger.LogInformation("Eliminando cliente con ID: {Id}", id);
                var resultado = await _clienteService.DeleteAsync(id);

                if (!resultado)
                {
                    _logger.LogWarning("Cliente con ID {Id} no encontrado para eliminar", id);
                    return NotFound($"Cliente con ID {id} no encontrado");
                }

                _logger.LogInformation("Cliente con ID {Id} eliminado exitosamente", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar cliente con ID: {Id}", id);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Verifica si existe un cliente con el ID especificado
        /// </summary>
        /// <param name="id">ID del cliente</param>
        /// <returns>True si existe, False si no existe</returns>
        [HttpHead("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ClienteExists(int id)
        {
            try
            {
                var exists = await _clienteService.ExistsAsync(id);
                return exists ? Ok() : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al verificar existencia del cliente con ID: {Id}", id);
                return StatusCode(500);
            }
        }
    }
}