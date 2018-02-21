﻿namespace Sitecore.Foundation.DependencyInjection.Infrastructure
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;

    public class MvcControllerServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("Sitecore.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("Sitecore.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("Sitecore.Foundation.*");
        }
    }
}