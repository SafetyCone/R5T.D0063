using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0063.Default
{
    public static class IServiceActionExtensions
    {
        public static IEnvironmentVariableProviderActionAggregation AddEnvironmentVariableProviderActions(this IServiceAction _)
        {
            var environmentVariableProviderAction = _.AddEnvironmentVariableProviderAction();
            var environmentVariablesProviderAction = _.AddEnvironmentVariablesProviderAction();

            var output = new EnvironmentVariableProviderActionAggregation
            {
                EnvironmentVariableProviderAction = environmentVariableProviderAction,
                EnvironmentVariablesProviderAction = environmentVariablesProviderAction,
            };

            return output;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentVariableProvider"/> implementation of <see cref="IEnvironmentVariableProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentVariableProvider> AddEnvironmentVariableProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IEnvironmentVariableProvider>(services => services.AddEnvironmentVariableProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentVariablesProvider"/> implementation of <see cref="IEnvironmentVariablesProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentVariablesProvider> AddEnvironmentVariablesProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IEnvironmentVariablesProvider>(services => services.AddEnvironmentVariablesProvider());
            return serviceAction;
        }
    }
}
