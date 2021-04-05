using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RektaManager.Shared.ComponentModels.Inventories;

namespace RektaManager.Client.Utils
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;

        public JsonSerializerOptions DefaultJsonSerializerOptions => new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        public HttpResponseMessage ServerResponse { get; set; }
        
        public HttpService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ResponseWrapper<object>> Post<T>(string url, T data)
        {
            var jsonData = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, Constants.ContentType);
            ServerResponse = await _client.PostAsync(url, stringContent);
            return new ResponseWrapper<object>(null, ServerResponse.IsSuccessStatusCode, ServerResponse);
        }

        public async Task<ResponseWrapper<object>> PutAsync<T>(string url, T requestPayload)
        {
            var reqPayload = JsonSerializer.Serialize(requestPayload);
            var stringifiedPayload = new StringContent(reqPayload, Encoding.UTF8, Constants.ContentType);

                ServerResponse = await _client.PutAsync(url, stringifiedPayload);

                if (ServerResponse.IsSuccessStatusCode)
                {
                    return new ResponseWrapper<object>(null, ServerResponse.IsSuccessStatusCode, ServerResponse);
                }
                return new ResponseWrapper<object>(null, false, ServerResponse);
        }

        public async Task<ResponseWrapper<object>> DeleteAsync(string url)
        {
            ServerResponse = await _client.DeleteAsync(url);
            if (ServerResponse.IsSuccessStatusCode)
            {
                return new ResponseWrapper<object>(null, ServerResponse.IsSuccessStatusCode, ServerResponse);
            }

            return new ResponseWrapper<object>(null, false, ServerResponse);
        }

        public async Task<ResponseWrapper<T>> GetAsync<T>(string url)
        {
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync(), DefaultJsonSerializerOptions);
                return new ResponseWrapper<T>(result,true,response);
            }
            else
            {
                return new ResponseWrapper<T>(default, false, response);
            }
        }

        public async Task<ResponseWrapper<T>> GetByIdAsync<T>(string url)
        {
            var response = await _client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return new ResponseWrapper<T>(default, false, response);
            }

            var result = JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync(), DefaultJsonSerializerOptions);

            return new ResponseWrapper<T>(result, true, response);
        }
    }
}
