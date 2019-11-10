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
            List<string> word_bank = new List<string>() { "elephant", "guacamole", "legendary", "coin", "mustache", "peanuts" };

            int randWordIndex = rand.Next(word_bank.Count());
            string word = word_bank[randWordIndex];


            const string accountSid = "AC6a821cb13063fc23e74bf10b09e6db00";
            const string authToken = "21d420efd82e5e087c72cb0c24ddf784";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+1" + num);
            var from = new PhoneNumber(twilNum);
            var call = CallResource.Create(to, from, url: new Uri("https://handler.twilio.com/twiml/EH1c38aeaa6210f3332442c09b398ac5cf"));

            int randNum2 = rand.Next(listSize);
            while (randNum2 == randNum)
            {
                randNum2 = rand.Next(listSize);
            }

            string num2 = nums[randNum2];
            string name2 = names[randNum2];

            var message = MessageResource.Create(
                body: word,
                from: new Twilio.Types.PhoneNumber(twilNum),
                to: new Twilio.Types.PhoneNumber("+1" + num2)
            );

            Console.WriteLine(call.Sid);
            Console.WriteLine(message.Sid);

        }

    }
}