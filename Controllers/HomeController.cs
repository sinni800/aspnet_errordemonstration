using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;
using Microsoft.AspNet.Http.Core;
using Microsoft.Net.Http.Headers;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
              [HttpPost]
		public ActionResult Index(Microsoft.AspNet.Http.IFormFile file) 
		{
			return new FileStreamResult(file.OpenReadStream(), "application/octet-stream"); 
		}
		
		public ActionResult Index() {
			return View();
		}
    }
}