/*
Get Services Manually
    It is not required to include dependency services in the constructor. 
    We can access dependent services configured with built-in IoC container 
    manually using RequestServices property of HttpContext as shown below.

    using Microsoft.AspNetCore.Mvc;

    namespace netcore
    {
        public class HomeController : Controller
        {
            public HomeController()
            {
            }
            public IActionResult Index()
            {
                var services = this.HttpContext.RequestServices;
                var log = (ILog)services.GetService(typeof(ILog));
                    
                log.info("Index method executing");
            
                return View();
            }
        }
    }
    It is recommended to use constructor injection instead of getting it using RequestServices.
*/

