using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core.Tokens;

namespace Project_app.Data_management
{
    public class DB_Connector
    {
        public DB_Connector() { }
        public JArray getRequest(string requestPath, string token)
        {
            var client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            var request = new RestRequest(requestPath, Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                return JArray.Parse(response.Content);
            }
            else if (numericStatusCode == 403)
            {
                throw new Exception("Odmowa dostępu.");
            }
            return null;
        }
    }
}
