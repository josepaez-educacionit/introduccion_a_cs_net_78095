# ?? Sistema de Gestión de Clientes - DemoWeb

Sistema completo de gestión de clientes desarrollado con **ASP.NET Core 8**, **Entity Framework Core** y **SQL Server**. Incluye interfaz web completa y API REST documentada.

## ? Características Principales

### ??? Interfaz Web Completa
- **Navegación intuitiva** desde el menú principal
- **Dashboard principal** con accesos directos
- **CRUD completo** de clientes con interfaz moderna
- **Validaciones en tiempo real**
- **Mensajes de confirmación** y notificaciones
- **Diseño responsive** con Bootstrap 5
- **Iconos FontAwesome** para mejor UX

### ?? API REST Completa
- **Endpoints RESTful** para todas las operaciones
- **Documentación Swagger** automática
- **Validaciones robustas** con DataAnnotations
- **Manejo de errores** centralizado
- **DTOs dedicados** para transferencia de datos
- **Logging estructurado** para auditoría

## ??? Estructura del Proyecto

```
DemoWeb/
??? Controllers/
?   ??? ClientesController.cs        # API REST
?   ??? ClientesWebController.cs     # Interfaz Web MVC
?   ??? HomeController.cs           # Página principal
??? Views/
?   ??? ClientesWeb/
?   ?   ??? Index.cshtml            # Lista de clientes
?   ?   ??? Create.cshtml           # Crear cliente
?   ?   ??? Edit.cshtml             # Editar cliente
?   ?   ??? Details.cshtml          # Ver detalles
?   ?   ??? Delete.cshtml           # Confirmar eliminación
?   ??? Home/
?   ?   ??? Index.cshtml            # Página principal mejorada
?   ??? Shared/
?       ??? _Layout.cshtml          # Layout con navegación
??? Data/
?   ??? DemoDbContext.cs            # Contexto Entity Framework
??? DTOs/
?   ??? ClienteDto.cs               # DTOs para API
??? Extensions/
?   ??? ClienteMappingExtensions.cs # Mapeo entidades/DTOs
??? Models/
?   ??? Cliente.cs                  # Modelo con validaciones
??? Services/
?   ??? Interfaces/
?   ?   ??? IClienteService.cs      # Interfaz del servicio
?   ??? ClienteService.cs           # Lógica de negocio
??? Program.cs                      # Configuración de servicios
??? appsettings.json                # Configuración y conexión BD
??? README.md                       # Documentación completa
```

## ?? Acceso a Clientes desde el Menú Principal

### ?? Navegación Implementada:

1. **Menú Principal Superior:**
   - **Inicio** ? Página principal con dashboard
   - **Clientes** ? Acceso directo a gestión de clientes
   - **Administración** ? Menú desplegable con:
     - Gestión de Clientes
     - API Documentation (Swagger)
   - **Privacidad** ? Información de privacidad

2. **Dashboard Principal:**
   - **Tarjeta de Gestión de Clientes** con accesos rápidos
   - **Botón "Ver Clientes"** ? Lista completa
   - **Botón "Nuevo"** ? Crear cliente directo
   - **Estadísticas visuales** del sistema

3. **Navegación en Clientes:**
   - **Breadcrumbs** automáticos
   - **Botones de acción** contextuales
   - **Mensajes de estado** (éxito/error/advertencia)

## ?? Rutas Web Disponibles

### ?? Interfaz Web (MVC)
```
GET  /                              # Página principal
GET  /ClientesWeb                   # Lista de clientes
GET  /ClientesWeb/Create            # Formulario nuevo cliente
POST /ClientesWeb/Create            # Crear cliente
GET  /ClientesWeb/Edit/{id}         # Formulario editar cliente
POST /ClientesWeb/Edit/{id}         # Actualizar cliente
GET  /ClientesWeb/Details/{id}      # Ver detalles de cliente
GET  /ClientesWeb/Delete/{id}       # Confirmar eliminación
POST /ClientesWeb/Delete/{id}       # Eliminar cliente
```

### ?? API REST
```
GET    /api/clientes                # Obtener todos los clientes
GET    /api/clientes/{id}           # Obtener cliente por ID
POST   /api/clientes                # Crear nuevo cliente
PUT    /api/clientes/{id}           # Actualizar cliente
DELETE /api/clientes/{id}           # Eliminar cliente
HEAD   /api/clientes/{id}           # Verificar existencia
```

## ??? Modelo de Cliente

```csharp
public class Cliente
{
    public int Id { get; set; }                    // PK, auto-generado
    public string Nombre { get; set; }             // Requerido, máx 50 chars
    public string Apellido { get; set; }           // Requerido, máx 50 chars
    public string Email { get; set; }              // Requerido, único, formato email
    public string? Telefono { get; set; }          // Opcional, máx 20 chars
    public string? Direccion { get; set; }         // Opcional, máx 200 chars
    public string NombreCompleto { get; }          // Calculado: Nombre + Apellido
}
```

## ?? Funcionalidades de la Interfaz Web

### ?? Lista de Clientes (Index)
- **Tabla responsive** con todos los datos
- **Enlaces directos** para email y teléfono
- **Botones de acción** (Ver, Editar, Eliminar)
- **Estado vacío** con mensaje motivacional
- **Contador** de clientes total
- **Confirmación** antes de eliminar

### ? Crear Cliente (Create)
- **Formulario validado** con campos requeridos
- **Validación en tiempo real** con JavaScript
- **Indicadores visuales** de campos obligatorios
- **Navegación clara** con botones de acción
- **Auto-foco** en primer campo

### ?? Editar Cliente (Edit)
- **Formulario pre-poblado** con datos actuales
- **Detección de cambios** visual
- **Confirmación** antes de guardar cambios
- **Navegación** a detalles y lista
- **Validación completa** del modelo

### ??? Ver Detalles (Details)
- **Vista de solo lectura** organizada
- **Acciones rápidas** (Email, Teléfono)
- **Enlaces directos** funcionales
- **Información del sistema** adicional
- **Navegación** completa entre vistas

### ??? Eliminar Cliente (Delete)
- **Confirmación múltiple** de seguridad
- **Vista detallada** del cliente a eliminar
- **Advertencias claras** sobre irreversibilidad
- **Información de auditoría**
- **Navegación de escape** fácil

## ?? Configuración y Instalación

### ?? Requisitos Previos
- **.NET 8 SDK**
- **SQL Server** (LocalDB incluido)
- **Visual Studio 2022** o **VS Code**

### ?? Instalación

1. **Clonar/Abrir el proyecto:**
```bash
cd DemoWeb
dotnet restore
```

2. **Configurar base de datos:**
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

3. **Ejecutar aplicación:**
```bash
dotnet run
```

4. **Acceder al sistema:**
   - **Interfaz Web:** `https://localhost:7xxx`
   - **API Swagger:** `https://localhost:7xxx/swagger`

### ?? Configuración de Base de Datos

**Cadena de conexión** en `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Demo20250725;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}
```

## ??? Validaciones y Seguridad

### ? Validaciones Implementadas
- **Campos obligatorios:** Nombre, Apellido, Email
- **Formato de email** válido
- **Longitud máxima** en todos los campos
- **Email único** en base de datos
- **Validación del lado del cliente** (JavaScript)
- **Validación del lado del servidor** (DataAnnotations)

### ?? Características de Seguridad
- **Anti-forgery tokens** en formularios
- **Validación de modelo** en todos los endpoints
- **Manejo de errores** sin exposición de información sensible
- **Logging de auditoría** para todas las operaciones
- **Sanitización** automática de entradas

## ?? Experiencia de Usuario

### ?? Diseño Visual
- **Bootstrap 5** para diseño responsive
- **FontAwesome 6** para iconografía consistente
- **Esquema de colores** profesional
- **Transiciones suaves** y efectos hover
- **Alertas contextuales** con colores semánticos

### ?? Notificaciones
- **Mensajes de éxito** en operaciones completadas
- **Alertas de error** con información específica
- **Advertencias** para operaciones riesgosas
- **Confirmaciones** para acciones destructivas

### ?? Responsive Design
- **Móvil first** approach
- **Tablas responsive** con scroll horizontal
- **Menú colapsable** en dispositivos pequeños
- **Botones adaptativos** según el tamaño de pantalla

## ?? Tecnologías Utilizadas

- **ASP.NET Core 8** - Framework web
- **Entity Framework Core 9** - ORM
- **SQL Server** - Base de datos
- **Bootstrap 5** - Framework CSS
- **FontAwesome 6** - Iconos
- **jQuery** - JavaScript enhancement
- **Swagger/OpenAPI** - Documentación API
- **DataAnnotations** - Validaciones
- **Dependency Injection** - Patrón de diseño
- **Repository/Service Pattern** - Arquitectura de capas

## ?? Navegación Completa Implementada

### ?? Desde Página Principal:
- ? **Botón principal** "Acceder a Clientes"
- ? **Tarjeta dedicada** con acciones rápidas
- ? **Enlaces directos** a crear nuevo cliente
- ? **Estadísticas visuales** del sistema

### ?? Desde Menú Superior:
- ? **Enlace directo** "Clientes" siempre visible
- ? **Menú desplegable** "Administración"
- ? **Acceso a API** documentation
- ? **Navegación consistente** en todas las páginas

### ?? Flujo de Navegación:
```
Inicio ? Clientes ? [Lista] ? [Crear/Ver/Editar/Eliminar] ? Volver
   ?       ?           ?               ?
Dashboard Menu    Gestión        Operaciones
```

¡El sistema está completamente operativo con acceso total a la gestión de clientes desde el menú principal!