using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.D0063
{
    public interface IEnvironmentVariablesProvider
    {
        Task<Dictionary<string, string>> GetEnvironmentVariables();
    }
}
