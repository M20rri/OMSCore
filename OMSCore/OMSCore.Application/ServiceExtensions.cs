using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OMSCore.Application.Behaviours;
using OMSCore.Application.Helpers;
using OMSCore.Application.Interfaces;
using OMSCore.Domain.Entities;
using System.Reflection;

namespace OMSCore.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddScoped<IModelHelper, ModelHelper>();
            //services.AddScoped<IMockData, MockData>();
        }
    }
}