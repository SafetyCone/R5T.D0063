using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0063
{
    [ServiceDefinitionMarker]
    public interface IEnvironmentVariableProvider : IServiceDefinition
    {
        Task<WasFound<string>> GetEnvironmentVariable(string name);
    }
}
