using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ApiService02
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
            services.AddMvcCore().AddAuthorization();//AddJsonFormatters()
            services.AddAuthentication(Configuration["Identity:Scheme"])
                .AddJwtBearer(Configuration["Identity:Scheme"], options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.Authority = $"http://{Configuration["Identity:IP"]}:{Configuration["Identity:Port"]}";
                    options.Audience = "productservice";
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidAudiences = new[]
                        {
                            $"http://{Configuration["Identity:IP"]}:{Configuration["Identity:Port"]}/resources",
                            "productservice"
                        }
                    };
                });
            //.AddIdentityServerAuthentication(options =>
            //{
            //    options.RequireHttpsMetadata = false;
            //    options.Authority = $"http://{Configuration["Identity:IP"]}:{Configuration["Identity:Port"]}";
            //    options.ApiName = Configuration["Service:Name"];
            //});

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
