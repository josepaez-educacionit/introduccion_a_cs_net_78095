using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using DemoWeb.Data;
using DemoWeb.Services;
using DemoWeb.Services.Interfaces;

namespace DemoWeb
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// Configure Entity Framework
			builder.Services.AddDbContext<DemoDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			// Register services
			builder.Services.AddScoped<IClienteService, ClienteService>();

			// Add API controllers support
			builder.Services.AddControllers();

			// Add Swagger/OpenAPI support for development
			if (builder.Environment.IsDevelopment())
			{
				builder.Services.AddEndpointsApiExplorer();
				builder.Services.AddSwaggerGen(c =>
				{
					c.SwaggerDoc("v1", new OpenApiInfo
					{
						Title = "Demo API",
						Version = "v1",
						Description = "API para gestión de clientes"
					});
				});
			}

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			else
			{
				app.UseSwagger();
				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo API V1");
				});
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			// Map API controllers
			app.MapControllers();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
