using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Vonage.Messaging;
using Vonage.Request;

namespace BlazorSmsApp.Data
{
	public class SmsService
	{
		public IConfiguration Configuration { get; set; }	
		public SmsService(IConfiguration config) {  Configuration = config; }

        public SendSmsResponse SendSms(SmsModel smsObj)
        {
			var credentials = Credentials.FromApiKeyAndSecret("e5b4b7e9","cW8zWzthpClxf19Z");
			//var VonageClient = new VonageClient(credentials);
			//var creds = Credentials.FromApiKeyAndSecret("e5b4b7e9", "cW8zWzthpClxf19Z");
            var client = new SmsClient(credentials);
            
			var response = new SendSmsRequest()
			{
				To = smsObj.RecipientNumber,
				From = "Nicholus Mahlangu",
				Text = smsObj.TextMessage
			};

			return client.SendAnSms(response);
        }
    }

	
}
