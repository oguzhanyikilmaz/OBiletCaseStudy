using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.Business.Abstractions
{
    public interface IRedisService
    {
        Task SetValueAsync(string key, string value, TimeSpan expire);
        Task<string> GetValueAsync(string key);
        Task DeleteKeyAsync(string key);
    }
}
