using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;

namespace OutOfLife.Api.Config.Swagger
{
    public static class SwaggerOutOfLifeConfig
    {
        public static IServiceCollection ConfigSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(
                c => c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info() {
                    Title = "API OutOfLife Project",
                    Version = "v1"
                })
            );
        }

        public static IApplicationBuilder ConfigUISwagger(this IApplicationBuilder Application)
        {
            return Application.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "doc";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API OutOfLife V1");
            });
        }
    }
}
