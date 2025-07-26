# ?? Sistema de Gesti�n de Clientes - DemoWeb

Sistema completo de gesti�n de clientes desarrollado con **ASP.NET Core 8**, **Entity Framework Core** y **SQL Server**. Incluye interfaz web completa y API REST documentada.

## ? Caracter�sticas Principales

### ??? Interfaz Web Completa
- **Navegaci�n intuitiva** desde el men� principal
- **Dashboard principal** con accesos directos
- **CRUD completo** de clientes con interfaz moderna
- **Validaciones en tiempo real**
- **Mensajes de confirmaci�n** y notificaciones
- **Dise�o responsive** con Bootstrap 5
- **Iconos FontAwesome** para mejor UX

### ?? API REST Completa
- **Endpoints RESTful** para todas las operaciones
- **Documentaci�n Swagger** autom�tica
- **Validaciones robustas** con DataAnnotations
- **Manejo de errores** centralizado
- **DTOs dedicados** para transferencia de datos
- **Logging estructurado** para auditor�a

## ??? Estructura del Proyecto

```
DemoWeb/
??? Controllers/
?   ??? ClientesController.cs        # API REST
?   ??? ClientesWebController.cs     # Interfaz Web MVC
?   ??? HomeController.cs           # P�gina principal
??? Views/
?   ??? ClientesWeb/
?   ?   ??? Index.cshtml            # Lista de clientes
?   ?   ??? Create.cshtml           # Crear cliente
?   ?   ??? Edit.cshtml             # Editar cliente
?   ?   ??? Details.cshtml          # Ver detalles
?   ?   ??? Delete.cshtml           # Confirmar eliminaci�n
?   ??? Home/
?   ?   ??? Index.cshtml            # P�gina principal mejorada
?   ??? Shared/
?       ??? _Layout.cshtml          # Layout con navegaci�n
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
?   ??? ClienteService.cs           # L�gica de negocio
??? Program.cs                      # Configuraci�n de servicios
??? appsettings.json                # Configuraci�n y conexi�n BD
??? README.md                       # Documentaci�n completa
```

## ?? Acceso a Clientes desde el Men� Principal

### ?? Navegaci�n Implementada:

1. **Men� Principal Superior:**
   - **Inicio** ? P�gina principal con dashboard
   - **Clientes** ? Acceso directo a gesti�n de clientes
   - **Administraci�n** ? Men� desplegable con:
     - Gesti�n de Clientes
     - API Documentation (Swagger)
   - **Privacidad** ? Informaci�n de privacidad

2. **Dashboard Principal:**
   - **Tarjeta de Gesti�n de Clientes** con accesos r�pidos
   - **Bot�n "Ver Clientes"** ? Lista completa
   - **Bot�n "Nuevo"** ? Crear cliente directo
   - **Estad�sticas visuales** del sistema

3. **Navegaci�n en Clientes:**
   - **Breadcrumbs** autom�ticos
   - **Botones de acci�n** contextuales
   - **Mensajes de estado** (�xito/error/advertencia)

## ?? Rutas Web Disponibles

### ?? Interfaz Web (MVC)
```
GET  /                              # P�gina principal
GET  /ClientesWeb                   # Lista de clientes
GET  /ClientesWeb/Create            # Formulario nuevo cliente
POST /ClientesWeb/Create            # Crear cliente
GET  /ClientesWeb/Edit/{id}         # Formulario editar cliente
POST /ClientesWeb/Edit/{id}         # Actualizar cliente
GET  /ClientesWeb/Details/{id}      # Ver detalles de cliente
GET  /ClientesWeb/Delete/{id}       # Confirmar eliminaci�n
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
    public string Nombre { get; set; }             // Requerido, m�x 50 chars
    public string Apellido { get; set; }           // Requerido, m�x 50 chars
    public string Email { get; set; }              // Requerido, �nico, formato email
    public string? Telefono { get; set; }          // Opcional, m�x 20 chars
    public string? Direccion { get; set; }         // Opcional, m�x 200 chars
    public string NombreCompleto { get; }          // Calculado: Nombre + Apellido
}
```

## ?? Funcionalidades de la Interfaz Web

### ?? Lista de Clientes (Index)
- **Tabla responsive** con todos los datos
- **Enlaces directos** para email y tel�fono
- **Botones de acci�n** (Ver, Editar, Eliminar)
- **Estado vac�o** con mensaje motivacional
- **Contador** de clientes total
- **Confirmaci�n** antes de eliminar

### ? Crear Cliente (Create)
- **Formulario validado** con campos requeridos
- **Validaci�n en tiempo real** con JavaScript
- **Indicadores visuales** de campos obligatorios
- **Navegaci�n clara** con botones de acci�n
- **Auto-foco** en primer campo

### ?? Editar Cliente (Edit)
- **Formulario pre-poblado** con datos actuales
- **Detecci�n de cambios** visual
- **Confirmaci�n** antes de guardar cambios
- **Navegaci�n** a detalles y lista
- **Validaci�n completa** del modelo

### ??? Ver Detalles (Details)
- **Vista de solo lectura** organizada
- **Acciones r�pidas** (Email, Tel�fono)
- **Enlaces directos** funcionales
- **Informaci�n del sistema** adicional
- **Navegaci�n** completa entre vistas

### ??? Eliminar Cliente (Delete)
- **Confirmaci�n m�ltiple** de seguridad
- **Vista detallada** del cliente a eliminar
- **Advertencias claras** sobre irreversibilidad
- **Informaci�n de auditor�a**
- **Navegaci�n de escape** f�cil

## ?? Configuraci�n y Instalaci�n

### ?? Requisitos Previos
- **.NET 8 SDK**
- **SQL Server** (LocalDB incluido)
- **Visual Studio 2022** o **VS Code**

### ?? Instalaci�n

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

3. **Ejecutar aplicaci�n:**
```bash
dotnet run
```

4. **Acceder al sistema:**
   - **Interfaz Web:** `https://localhost:7xxx`
   - **API Swagger:** `https://localhost:7xxx/swagger`

### ?? Configuraci�n de Base de Datos

**Cadena de conexi�n** en `appsettings.json`:
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
- **Formato de email** v�lido
- **Longitud m�xima** en todos los campos
- **Email �nico** en base de datos
- **Validaci�n del lado del cliente** (JavaScript)
- **Validaci�n del lado del servidor** (DataAnnotations)

### ?? Caracter�sticas de Seguridad
- **Anti-forgery tokens** en formularios
- **Validaci�n de modelo** en todos los endpoints
- **Manejo de errores** sin exposici�n de informaci�n sensible
- **Logging de auditor�a** para todas las operaciones
- **Sanitizaci�n** autom�tica de entradas

## ?? Experiencia de Usuario

### ?? Dise�o Visual
- **Bootstrap 5** para dise�o responsive
- **FontAwesome 6** para iconograf�a consistente
- **Esquema de colores** profesional
- **Transiciones suaves** y efectos hover
- **Alertas contextuales** con colores sem�nticos

### ?? Notificaciones
- **Mensajes de �xito** en operaciones completadas
- **Alertas de error** con informaci�n espec�fica
- **Advertencias** para operaciones riesgosas
- **Confirmaciones** para acciones destructivas

### ?? Responsive Design
- **M�vil first** approach
- **Tablas responsive** con scroll horizontal
- **Men� colapsable** en dispositivos peque�os
- **Botones adaptativos** seg�n el tama�o de pantalla

## ?? Tecnolog�as Utilizadas

- **ASP.NET Core 8** - Framework web
- **Entity Framework Core 9** - ORM
- **SQL Server** - Base de datos
- **Bootstrap 5** - Framework CSS
- **FontAwesome 6** - Iconos
- **jQuery** - JavaScript enhancement
- **Swagger/OpenAPI** - Documentaci�n API
- **DataAnnotations** - Validaciones
- **Dependency Injection** - Patr�n de dise�o
- **Repository/Service Pattern** - Arquitectura de capas

## ?? Navegaci�n Completa Implementada

### ?? Desde P�gina Principal:
- ? **Bot�n principal** "Acceder a Clientes"
- ? **Tarjeta dedicada** con acciones r�pidas
- ? **Enlaces directos** a crear nuevo cliente
- ? **Estad�sticas visuales** del sistema

### ?? Desde Men� Superior:
- ? **Enlace directo** "Clientes" siempre visible
- ? **Men� desplegable** "Administraci�n"
- ? **Acceso a API** documentation
- ? **Navegaci�n consistente** en todas las p�ginas

### ?? Flujo de Navegaci�n:
```
Inicio ? Clientes ? [Lista] ? [Crear/Ver/Editar/Eliminar] ? Volver
   ?       ?           ?               ?
Dashboard Menu    Gesti�n        Operaciones
```

�El sistema est� completamente operativo con acceso total a la gesti�n de clientes desde el men� principal!