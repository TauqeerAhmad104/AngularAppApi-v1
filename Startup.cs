using AngularAppApi.DBContexts;
using AngularAppApi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAppApi
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
            var connection = @"Server=db;Database=master;User=sa;Password=4I0&4W#I4Wrf;";
            services.AddControllers();
            services.AddDbContext<ProjectContext>(
             options => options.UseSqlServer(connection));

            services.AddMvc();

            //     services.AddSwaggerGen(c =>
            //     {
            //         c.SwaggerDoc("v1", new OpenApiInfo { Title = "AngularAppApi", Version = "v1" });
            //     });
            services.AddDbContext<ProjectContext>(o => o.UseSqlServer(Configuration.GetConnectionString("AngularAppApi")));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IProjectEmployeeRepository, ProjectEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AngularAppApi v1"));
            }
            

            app.UseHttpsRedirection();
             
               app.UseRouting();

                app.UseAuthorization();

                 app.UseEndpoints(endpoints =>
                 {
                     endpoints.MapControllers();
                });

          //  app.UseMvc();
        }
    }
}
