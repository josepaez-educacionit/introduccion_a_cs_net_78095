using Microsoft.EntityFrameworkCore;
using DemoWeb.Data;
using DemoWeb.Models;
using DemoWeb.Services.Interfaces;

namespace DemoWeb.Services
{
    public class ClienteService : IClienteService
    {
        private readonly DemoDbContext _context;

        public ClienteService(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes
                .OrderBy(c => c.Apellido)
                .ThenBy(c => c.Nombre)
                .ToListAsync();
        }

        public async Task<Cliente?> GetByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<Cliente> CreateAsync(Cliente cliente)
        {
            if (await EmailExistsAsync(cliente.Email))
            {
                throw new InvalidOperationException("Ya existe un cliente con este email.");
            }

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente?> UpdateAsync(int id, Cliente cliente)
        {
            var existingCliente = await _context.Clientes.FindAsync(id);
            if (existingCliente == null)
            {
                return null;
            }

            if (await EmailExistsAsync(cliente.Email, id))
            {
                throw new InvalidOperationException("Ya existe otro cliente con este email.");
            }

            existingCliente.Nombre = cliente.Nombre;
            existingCliente.Apellido = cliente.Apellido;
            existingCliente.Email = cliente.Email;
            existingCliente.Telefono = cliente.Telefono;
            existingCliente.Direccion = cliente.Direccion;

            await _context.SaveChangesAsync();
            return existingCliente;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return false;
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Clientes.AnyAsync(c => c.Id == id);
        }

        public async Task<bool> EmailExistsAsync(string email, int? excludeId = null)
        {
            var query = _context.Clientes.Where(c => c.Email == email);
            
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }

            return await query.AnyAsync();
        }
    }
}