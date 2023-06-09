﻿using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Travel.Application.Common.Behaviours;

namespace Travel.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), 
                typeof(PerformanceBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), 
                typeof(ValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), 
                typeof(UnhandledExceptionBehavior<,>));
            return services;

        }
    }
}