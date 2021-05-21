using System;
using System.Threading.Tasks;

using R5T.Magyar;


namespace R5T.D0063
{
    public class EnvironmentVariableProvider : IEnvironmentVariableProvider
    {
        public Task<WasFound<string>> GetEnvironmentVariable(string name)
        {
            var environmentVariable = Environment.GetEnvironmentVariable(name);

            var isFound = EnvironmentHelper.IsEnvironmentVariableFound(environmentVariable);

            var wasFound = WasFound.From(isFound, environmentVariable);

            return Task.FromResult(wasFound);
        }
    }
}
