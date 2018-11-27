using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace WebApplication1.Controllers
{
    public class CallController : TwilioController
    {
        [System.Web.Http.HttpPost]
        public ActionResult Index()
        {
            var response = new VoiceResponse();
            response.Say("This is the NSA. Thank you for your private information");

            return TwiML(response);
        }
    }
}
