using MCT.Core.Business.Azure.Storage.EventHub;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerRole1
{
    [AzureEventHubGuid("A8B75187-DC10-44FD-90A0-3EF2E62E7645")]
    public class Class1 : EventHubsConsumer
    {
        public Class1()
            : base(true)
        {


        }

        protected override async Task OnIncomingMessage(object message)
        {
            try
            {
                Debug.WriteLine(message.ToString());
            }
            catch (Exception)
            {

                // throw;
            }
        }

        
    }
}
