using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApi.Repositories.Interfaces;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Página de excepciones detalladas en entorno de desarrollo
            }
            else
            {
                // Configuración para entornos de producción
                app.UseExceptionHandler("/Error"); // Middleware para manejo de excepciones
                app.UseHsts(); // Agrega encabezados HTTP Strict Transport Security (HSTS) para protección contra ataques
                
            }

            app.UseHttpsRedirection(); // Redirección HTTP a HTTPS
            app.UseRouting(); // Configura el enrutamiento

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Mapea las acciones de los controladores
            });
        }
    }
}
