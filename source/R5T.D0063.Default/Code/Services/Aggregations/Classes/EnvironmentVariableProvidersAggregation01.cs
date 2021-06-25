using System;

using R5T.Dacia;


namespace R5T.D0063.Default
{
    public class EnvironmentVariableProvidersAggregation01 : IEnvironmentVariableProvidersAggregation01
    {
        public IServiceAction<IEnvironmentVariableProvider> EnvironmentVariableProviderAction { get; set; }
        public IServiceAction<IEnvironmentVariablesProvider> EnvironmentVariablesProviderAction { get; set; }
    }
}
