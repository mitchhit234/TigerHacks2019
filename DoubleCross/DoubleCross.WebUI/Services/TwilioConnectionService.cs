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
using System.Web.Mvc;
using Twilio.AspNet.Mvc;


namespace TwilioConnectionService
{
    public class Program
    {
        public static void Main(List<string> names, List<string> nums)
        {
            int listSize = nums.Count();
            Random rand = new Random();
            int randNum = rand.Next(listSize);

            string num = nums[randNum];
            string name = names[randNum];
            const string twilNum = "+12056240471";
            List<string> word_bank = new List<string>() { "elephant", "guacamole", "soda", "coin", "hammer" };
            List<string> xml_bank = new List<string>() { "https://handler.twilio.com/twiml/EH7933e9ec81efd66931b477ee8c1b7c6c",
            "https://handler.twilio.com/twiml/EH1c38aeaa6210f3332442c09b398ac5cf",
            "https://handler.twilio.com/twiml/EH7a4c002c14c5741423a6dff504468f65",
            "https://handler.twilio.com/twiml/EH1e9f812891e16cd258bc3dfac04162f2",
            "https://handler.twilio.com/twiml/EHd7621e90eea9b0faf1faef3ec8fa2ddf"};

            int randWordIndex = rand.Next(word_bank.Count());
            string word = word_bank[randWordIndex];
            string call_url = xml_bank[randWordIndex];


            const string accountSid = "AC6a821cb13063fc23e74bf10b09e6db00";
            const string authToken = "21d420efd82e5e087c72cb0c24ddf784";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+1" + num);
            var from = new PhoneNumber(twilNum);
            var call = CallResource.Create(to, from, url: new Uri(call_url));

            int randNum2 = rand.Next(listSize);
            while (randNum2 == randNum)
            {
                randNum2 = rand.Next(listSize);
            }

            string num2 = nums[randNum2];
            string name2 = names[randNum2];
            string spy_message = "People at the scene saw you use your " + word + ". Let NOBODY know.";

            var message = MessageResource.Create(
                body: spy_message,
                from: new Twilio.Types.PhoneNumber(twilNum),
                to: new Twilio.Types.PhoneNumber("+1" + num2)
            );

            Console.WriteLine(call.Sid);
            Console.WriteLine(message.Sid);

        }

    }
}