using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MatterManager.Api.Models;
using MatterManager.Interfaces;
using MatterManager.Interfaces.ApplicationServices;
using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;

namespace MatterManager.Api.Controllers
{
    public class MattersController : ApiController
    {
        private IMatterApplicationService matterApplicationService;

        [HttpPost]
        [Route("api/clients/{clientName}/matters/")]
        public async Task<HttpResponseMessage> CreateMatter(string clientName, [FromBody] MatterDto matter)
        {
            //var response = new HttpResponseMessage();
            //try
            //{
            //    matterApplicationService.Process(clientName, matter);
            //    response.StatusCode = HttpStatusCode.Accepted;
            //}
            //catch (Exception exception)
            //{
            //    response.StatusCode = HttpStatusCode.BadRequest;
            //}


            var serializedMatter = JsonConvert.SerializeObject(matter);
            var message = new BrokeredMessage(serializedMatter) {Label = Guid.NewGuid().ToString().Replace("-", "")};
            const string connectionString = "Endpoint=sb://mattermanagerenterprise.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=h/tirK0EEgwqkpDb0bp2ucLlUSKOFn6OIl3a8idyNWs=";

            var client =
                QueueClient.CreateFromConnectionString(connectionString, "matterqueue");

            await client.SendAsync(message);

            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}