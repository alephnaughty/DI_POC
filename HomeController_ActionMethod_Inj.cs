/*
Action Method Injection
    Sometimes we may only need dependency service type in a single action method. 
    For this, use [FromServices] attribute with the service type parameter in the method.

    using Microsoft.AspNetCore.Mvc;

    namespace netcore
    {
        public class HomeController : Controller
        {
            public HomeController()
            {
            }

            public IActionResult Index([FromServices] ILog log)
            {
                log.info("Index method executing");

                return View();
            }
        }
    }
*/