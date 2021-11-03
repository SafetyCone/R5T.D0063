using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0063
{
    [ServiceImplementationMarker]
    public class EnvironmentVariableProvider : IEnvironmentVariableProvider, IServiceImplementation
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
