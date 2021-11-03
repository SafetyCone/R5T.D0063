using System;

using R5T.T0063;


namespace R5T.D0063.Default
{
    public interface IEnvironmentVariableProviderActionAggregationIncrement
    {
        IServiceAction<IEnvironmentVariableProvider> EnvironmentVariableProviderAction { get; set; }
        IServiceAction<IEnvironmentVariablesProvider> EnvironmentVariablesProviderAction { get; set; }
    }
}
