// This file is where all code that 
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.TwiML.Voice;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCross.WebUI
{
    public class TwilioConnectionService
    {
        static void Main(string[] args)
        {
            /*
			// num_input and name_input imported from web
			int amnt_of_nums = name_input.Count(f => f == ',');
			List<string> names = new List<string>();
			List<string> phone_nums = new List<string>();
			int j, k = 0;
			string current_string = "";
			for(int i = 0; i < amnt_of_nums; i++)
			{
				while(num_input[j] != ',')
				{
					current_string += num_input[j];
					j += 1;
				}
				phone_nums.Add(current_string);
				current_string = "";
				while(name_input[k] != ',')
				{
					current_string += num_input[k];
					k += 1;
				}
				names.Add(current_string);
				
			}
			*/

            const string accountSid = "AC47dca6777f98063b5a02357d7e609550";
            const string authToken = "ec250cbca2521808ec9dbb8355f52b12";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+13146606488");
            var from = new PhoneNumber("+12055574602");
            var call = CallResource.Create(to, from, url: new Uri("https://handler.twilio.com/twiml/EH092d0a51e18e85a126f9858221955e9e"));
            var response = new VoiceResponse();
            response.Play(digits: "wwww3");
            Console.WriteLine(response.ToString());


            Console.WriteLine(call.Sid);
        }
    }
}
