using System;

using R5T.D0063.Default;


namespace System
{
    public static class IEnvironmentVariableProvidersAggregation01Extensions
    {
        public static T FillFrom<T>(this T value,
            IEnvironmentVariableProvidersAggregation01 other)
            where T : IEnvironmentVariableProvidersAggregation01
        {
            value.EnvironmentVariableProviderAction = other.EnvironmentVariableProviderAction;
            value.EnvironmentVariablesProviderAction = other.EnvironmentVariablesProviderAction;

            return value;
        }
    }
}
