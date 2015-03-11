using Microsoft.AspNet.Mvc;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(User());
        }

        public User User()
        {
            User user = new User()
            {
                Name = "My name",
                Address = "My address"
            };

            return user;
        }
        
        [HttpPost]
		public Task<ActionResult> Add(IFormFile file) 
		{
			return new FileStreamResult(file.OpenReadStream(), "application/octet-stream"); 
		}
		
		public Task<ActionResult> Add() {
			return View();
		}
    }
}
