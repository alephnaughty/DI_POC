using System;

/*
The built-in container is represented by IServiceProvider implementation that supports constructor injection by default. 
The types (classes) managed by built-in IoC container are called services.

There are basically two types of services in ASP.NET Core:

Framework Services: 
    Services which are a part of ASP.NET Core framework such as IApplicationBuilder, IHostingEnvironment, ILoggerFactory, etc.

Application Services: 
    Services (custom types or classes) which you as a programmer create for your application.
*/
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

namespace netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        
    }
}
