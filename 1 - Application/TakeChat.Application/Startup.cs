using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using TakeChat.Infra.Data.Context;

namespace TakeChat.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<TODOAppContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Register the Swagger services           
            services.AddSwaggerDocument(config =>
            {
                config.DocumentName = "TODOApp API";
                config.PostProcess = document =>
                {
                    document.Info.Version = "V1";
                    document.Info.Title = "TODOChat API";
                    document.Info.Description = "API para Aplicação de lista de tarefas";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Jeferson Araújo de Oliveira",
                        Email = "oliveira.jefersonaraujo@gmail.com",
                        Url = "https://github.com/jefersonao"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "UbiStart",
                        Url = "https://www.UbiStart.net/"
                    };
                };
            });

            //Validação das requisições
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                                    options.TokenValidationParameters = new TokenValidationParameters
                                    {
                                        ValidateIssuer = false,
                                        ValidateAudience = false,
                                        ValidateLifetime = true,
                                        ValidateIssuerSigningKey = true,
                                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["CtsAcs:scKey"])),
                                        ClockSkew = TimeSpan.Zero
                                    }
                                 );
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Register the Swagger generator and the Swagger UI middlewares
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
