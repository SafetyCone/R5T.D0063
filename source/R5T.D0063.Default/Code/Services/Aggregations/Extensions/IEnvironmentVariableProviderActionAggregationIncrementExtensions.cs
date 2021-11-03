using System;


namespace R5T.D0063.Default
{
    public static class IEnvironmentVariableProviderActionAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IEnvironmentVariableProviderActionAggregationIncrement other)
            where T : IEnvironmentVariableProviderActionAggregationIncrement
        {
            aggregation.EnvironmentVariableProviderAction = other.EnvironmentVariableProviderAction;
            aggregation.EnvironmentVariablesProviderAction = other.EnvironmentVariablesProviderAction;

            return aggregation;
        }
    }
}
