using DemoWeb.Models;
using DemoWeb.DTOs;

namespace DemoWeb.Extensions
{
    public static class ClienteMappingExtensions
    {
        public static Cliente ToEntity(this ClienteCreateDto dto)
        {
            return new Cliente
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Direccion = dto.Direccion
            };
        }

        public static Cliente ToEntity(this ClienteUpdateDto dto)
        {
            return new Cliente
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Direccion = dto.Direccion
            };
        }

        public static void UpdateEntity(this ClienteUpdateDto dto, Cliente entity)
        {
            entity.Nombre = dto.Nombre;
            entity.Apellido = dto.Apellido;
            entity.Email = dto.Email;
            entity.Telefono = dto.Telefono;
            entity.Direccion = dto.Direccion;
        }

        public static ClienteResponseDto ToResponseDto(this Cliente entity)
        {
            return new ClienteResponseDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Email = entity.Email,
                Telefono = entity.Telefono,
                Direccion = entity.Direccion,
                NombreCompleto = entity.NombreCompleto
            };
        }

        public static IEnumerable<ClienteResponseDto> ToResponseDto(this IEnumerable<Cliente> entities)
        {
            return entities.Select(e => e.ToResponseDto());
        }
    }
}