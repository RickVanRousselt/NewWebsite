using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using Twilio.TwiML;

namespace WebApplication1.Controllers
{
    public class CallController
    {
        [System.Web.Http.HttpPost]
        public TwiML Index()
        {
            var response = new VoiceResponse();
            response.Say("Thank you for calling! Have a great day.");

            return response;
        }
    }
}
