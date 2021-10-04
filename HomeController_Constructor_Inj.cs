/*
Constructor Injection
    Once we register a service, the IoC container automatically performs constructor injection 
    if a service type is included as a parameter in a constructor.

    For example, we can use ILog service type in any MVC controller. Consider the following example.

    An IoC container will automatically pass an instance of MyConsoleLogger to the constructor of HomeController. 
    We don't need to do anything else. An IoC container will create and dispose an instance of ILog based on 
    the registered lifetime.


    using Microsoft.AspNetCore.Mvc;

    namespace netcore
    {
        public class HomeController : Controller
        {
            ILog _log;

            public HomeController(ILog log)
            {
                _log = log;
            }
            public IActionResult Index()
            {
                _log.info("Executing /home/index");

                return View();
            }
        }
    }
*/
