using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RektaManager.Client.Utils
{
    public interface IHttpService
    {
        Task<ResponseWrapper<object>> Post<T>(string url, T data);

        Task<ResponseWrapper<T>> GetAsync<T>(string url);
        JsonSerializerOptions DefaultJsonSerializerOptions { get; }
        Task<ResponseWrapper<T>> GetByIdAsync<T>(string url);
    }
}
