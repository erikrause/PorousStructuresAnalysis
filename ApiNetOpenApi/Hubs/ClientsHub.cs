using Microsoft.AspNetCore.SignalR;
using OpenApiSqlDomain.Entities;
using OpenApiSqlDomain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiNetOpenApi.Hubs
{
    public class ClientsHub : Hub
    {
        /// <summary>
        /// Используется для сопоставления GUID клиентов подключений с id нейронной сети.
        /// </summary>
        protected ClientsConnectionMapping<int> _connectionsMapping = new ClientsConnectionMapping<int>();

        /// <summary>
        /// При подключении клиент присылает id нейронной сети через queryString/Header. 
        /// </summary>
        /// <returns></returns>
        public override Task OnConnectedAsync()
        {
            throw new NotImplementedException();

            return base.OnConnectedAsync();
        }

        public void NotifySampleUpdate(GeneratedSample sample)
        {
            var connectionId = _connectionsMapping.GetConnections(sample.GenerationNetworkId).FirstOrDefault();
            Clients.Client(connectionId).SendAsync("SampleUpdate", sample);
        }
    }
}
