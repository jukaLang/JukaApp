using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Webhooks;
namespace JukaApp.Webhook
{
    class UFWS
    {
        public void SendWebhook(String feedback, String webhookURL)
        {
            var webhook = new Discord.Webhooks.Webhook()
            {
                Message = feedback,
                WebhookUrl = webhookURL
            };
            webhook.SendInstance();
        }
    }
}
