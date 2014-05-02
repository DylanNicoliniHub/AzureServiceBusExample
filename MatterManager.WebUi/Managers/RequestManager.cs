using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MatterManager.WebUi.Models;
using Newtonsoft.Json;

namespace MatterManager.WebUi.Managers
{
    public class RequestManager
    {
        public async Task<bool> CreateRequest(Matter matter)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://mattermangerenterpriseapi.azurewebsites.net/");
                client.BaseAddress = new Uri(" http://localhost:41623/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                await client.PostAsJsonAsync("api/clients/TesterClient/matters", matter);
                return true;
            }
        }
    }
}