using Newtonsoft.Json;
using NUnit.Framework;
using PruebaIngresoNewShore.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PruebaIngresoNewShore.Controllers
{
    public class HomeController : Controller
    {
        //public async Task<ActionResult> Index()
        public  ActionResult Index()
        {
           
            //var httpClient = new HttpClient();
            //var json = await httpClient.GetStringAsync("http://testapi.vivaair.com/otatest/");

            //var flightsList = JsonConvert.DeserializeObject<List<Flights>>(json);    
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


         public String RestCaller(String org, String dest,String dat) {
            IRestResponse response = null;
            //RESTSHARP
            RestSharp.RestClient client = new RestSharp.RestClient("http://testapi.vivaair.com/otatest/");
            RestSharp.RestRequest request = new RestSharp.RestRequest
            {
                Resource = "api/values",
                Method = RestSharp.Method.POST
            };

            request.AddParameter("Origin", org);
            request.AddParameter("Destination", dest);
            request.AddParameter("From", dat);
            response = client.Execute(request);
            var content = response.Content;
            content = content.TrimStart('\"');
            content = content.TrimEnd('\"');
            content = content.Replace("\\", "");

            return content;
        }


        [HttpPost]
        [Route("Home")]
        [ActionName("SearchResult")]
        public ActionResult SearchResult(String origin, String destination, DateTime DateFly)
        {
            IList<Flights> result = JsonConvert.DeserializeObject<IList<Flights>>(RestCaller(origin, destination, DateFly.ToString("yyyy/MM/dd")));
            return View(result.ToList());
        }
    }
}