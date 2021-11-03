using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0063
{
    [ServiceDefinitionMarker]
    public interface IEnvironmentVariablesProvider : IServiceDefinition
    {
        Task<Dictionary<string, string>> GetEnvironmentVariables();
    }
}
