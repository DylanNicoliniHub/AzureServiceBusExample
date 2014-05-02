using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatterManager.ConsoleClient
{
    internal class Program
    {
        private static  void Main(string[] args)
        {
            var matters = new List<MatterDto>();
            var clientName = ConfigurationManager.AppSettings["ClientName"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://mattermangerenterpriseapi.azurewebsites.net/");
                //client.BaseAddress = new Uri(" http://localhost:41623/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                for (int i = 0; i < 1000; i++)
                {
                    var matter = new MatterDto
                    {
                        Name = clientName + "Test " + i,
                        NetworkMatterNumber = clientName + "Test " + i,
                        ResponsibleProfessional = clientName + "Test " + i,
                        Workarea = clientName + "Test " + i
                    };

                     SendData(client, matter);
                }
            }
        }

        public static async void SendData(HttpClient client, MatterDto matter)
        {
            await client.PostAsJsonAsync("api/clients/TesterClient/matters", matter);
        }
    }
}