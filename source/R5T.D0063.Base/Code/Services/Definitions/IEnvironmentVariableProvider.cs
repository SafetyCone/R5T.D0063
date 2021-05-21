using System;
using System.Threading.Tasks;

using R5T.Magyar;


namespace R5T.D0063
{
    public interface IEnvironmentVariableProvider
    {
        Task<WasFound<string>> GetEnvironmentVariable(string name);
    }
}
