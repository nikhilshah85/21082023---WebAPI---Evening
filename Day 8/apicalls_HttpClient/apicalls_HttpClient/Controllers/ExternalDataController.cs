using apicalls_HttpClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace apicalls_HttpClient.Controllers
{
    public class ExternalDataController : Controller
    {


        public IActionResult DisplayPost()
        {
            PostDetails pObj = new PostDetails();
            ViewBag.post = pObj.GetPostDetails();
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
