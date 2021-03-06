using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Softplan.DesafioTecnico.Infra.Data.Context;
using Softplan.DesafioTecnico.IoC.Extensions;
using Softplan.DesafioTecnico.SecondApi.Models;
using System;

namespace Softplan.DesafioTecnico.SecondApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddScoped<DataContext, DataContext>();
            services.AddCompoundInterestExtensions();
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Juros Compostos",
                        Version = "v1",
                        Description = "API que calcula os Juros Compostos com base na Taxa de Juros de outra API.",
                        Contact = new OpenApiContact
                        {
                            Name = "Gustavo Figueira",
                            Url = new Uri("https://github.com/gustavofigueira")
                        }
                    });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Juros Compostos");
            });

            // Habilita o Cors para evitar refuse connection entre as duas APIs locais
            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
