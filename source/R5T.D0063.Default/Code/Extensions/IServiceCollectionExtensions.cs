using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0063
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EnvironmentVariableProvider"/> implementation of <see cref="IEnvironmentVariableProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentVariableProvider(this IServiceCollection services)
        {
            services.AddSingleton<IEnvironmentVariableProvider, EnvironmentVariableProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentVariableProvider"/> implementation of <see cref="IEnvironmentVariableProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentVariableProvider> AddEnvironmentVariableProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IEnvironmentVariableProvider>(() => services.AddEnvironmentVariableProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentVariablesProvider"/> implementation of <see cref="IEnvironmentVariablesProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentVariablesProvider(this IServiceCollection services)
        {
            services.AddSingleton<IEnvironmentVariablesProvider, EnvironmentVariablesProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentVariablesProvider"/> implementation of <see cref="IEnvironmentVariablesProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentVariablesProvider> AddEnvironmentVariablesProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IEnvironmentVariablesProvider>(() => services.AddEnvironmentVariablesProvider());
            return serviceAction;
        }
    }
}
