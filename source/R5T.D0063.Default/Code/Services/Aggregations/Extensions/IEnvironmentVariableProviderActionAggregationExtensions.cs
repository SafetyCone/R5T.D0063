using System;


namespace R5T.D0063.Default
{
    public static class IEnvironmentVariableProviderActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IEnvironmentVariableProviderActionAggregation other)
            where T : IEnvironmentVariableProviderActionAggregation
        {
            (aggregation as IEnvironmentVariableProviderActionAggregationIncrement).FillFrom(other);

            return aggregation;
        }
    }
}
