using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AirBosnia_UI.Util
{
   public class WebApiHelper
    {
        public HttpClient client { get; set; }
        public string route { get; set; }


        public WebApiHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }

        public HttpResponseMessage GetResponse(string parametar = "")
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parametar = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parametar = "", string parametar2 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar + "/" + parametar2).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, string parametar = "", string parametar2 = "", string parametar3 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar+"/"+parametar2 + "/" + parametar3).Result;
        }

        public HttpResponseMessage PostResponse(Object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }

        public HttpResponseMessage PutResponseMoj(string action, int id, object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + action + "/" + id, existingObject).Result;
        }

        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }


    }
}
