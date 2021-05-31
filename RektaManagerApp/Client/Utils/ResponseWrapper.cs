using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RektaManagerApp.Client.Utils
{
    public class ResponseWrapper<T>
    {
        public bool Success { get; set; }

        public T Response { get; set; }

        public HttpResponseMessage HttpResponseMessage { get; set; }


        public ResponseWrapper(T response, bool success, HttpResponseMessage message)
        {
            HttpResponseMessage = message;
            Success = success;
            Response = response;
        }
    }
}
