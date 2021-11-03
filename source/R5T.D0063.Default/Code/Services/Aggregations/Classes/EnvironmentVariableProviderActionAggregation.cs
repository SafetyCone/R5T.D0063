using System;

using R5T.T0063;


namespace R5T.D0063.Default
{
    public class EnvironmentVariableProviderActionAggregation : IEnvironmentVariableProviderActionAggregation
    {
        public IServiceAction<IEnvironmentVariableProvider> EnvironmentVariableProviderAction { get; set; }
        public IServiceAction<IEnvironmentVariablesProvider> EnvironmentVariablesProviderAction { get; set; }
    }
}
