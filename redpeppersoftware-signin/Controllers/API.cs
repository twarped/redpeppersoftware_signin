using Microsoft.AspNetCore.Mvc;

namespace redpeppersoftware_signin{

    class ControllerAPI : Controller {
        [HttpPost]
        [HttpGet]
        [Consumes("plain/text")]
        [Route("/amazing")]

        public string Amazing(Stuff stuff) {
            string returnstuff = $"On a scale from 0 to {stuff.awesomeness}, your total awesomeness is {stuff.awesomeness}!!!";
            return  returnstuff;
        }
    }
}