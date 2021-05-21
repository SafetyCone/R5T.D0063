using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Magyar;


namespace R5T.D0063
{
    /// <summary>
    /// Gets environment variables from the current process (<see cref="EnvironmentVariableTarget.Process"/>).
    /// </summary>
    public class EnvironmentVariablesProvider : IEnvironmentVariablesProvider
    {
        public Task<Dictionary<string, string>> GetEnvironmentVariables()
        {
            // I'm not sure why the a non-generic dictionary is returned, these should all be string names and string values.
            var environmentVariables = Environment.GetEnvironmentVariables();

            var output = environmentVariables.ToDictionary(
                key => key.ToString(),
                value => value.ToString());

            return Task.FromResult(output);
        }
    }
}
