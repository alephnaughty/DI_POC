using Microsoft.Extensions.DependencyInjection;


/*
ASP.NET Core allows us to register our application services with IoC container, 
in the ConfigureServices method of the Startup class. The ConfigureServices method 
includes a parameter of IServiceCollection type which is used to register application services.
*/

namespace netcore
{
    public class Startup
    {
        // register ILog with IoC container in ConfigureServices()

        public void ConfigureServices(IServiceCollection services)
        {
            // Add() method of IServiceCollection instance is used to register a service with an IoC container

            // The ServiceDescriptor is used to specify a service type and its instance.

            // ILog = service type 
            // MyConsoleLogger = service instance

            services.Add(new ServiceDescriptor(typeof(ILog), new MyConsoleLogger()));

            // ILog service is registered as a singleton by default

            // Now, an IoC container will create a singleton object of MyConsoleLogger class 
            // and inject it in the constructor of classes wherever we include ILog as a 
            // constructor or method parameter throughout the application.

            // Thus, we can register our custom application services with an IoC container in 
            // the ASP.NET Core application.
        }
    }
}
/*
The built-in IoC container supports three kinds of lifetimes:

    Singleton: 
        IoC container will create and share a single instance of a service throughout the application's lifetime.

    Transient: 
        The IoC container will create a new instance of the specified service type every time you ask for it.

    Scoped: 
        IoC container will create an instance of the specified service type once per request and 
        will be shared in a single request.


The following example shows how to register a service with different lifetimes.

    public void ConfigureServices(IServiceCollection services)
    {
        // singleton
        services.Add(new ServiceDescriptor(typeof(ILog), new MyConsoleLogger()));    
        
        // Transient
        services.Add(new ServiceDescriptor(typeof(ILog), typeof(MyConsoleLogger), ServiceLifetime.Transient));
        
        // Scoped
        services.Add(new ServiceDescriptor(typeof(ILog), typeof(MyConsoleLogger), ServiceLifetime.Scoped));
    }


Extension Methods for Registration

    ASP.NET Core framework includes extension methods for each types of lifetime; 
    AddSingleton(), AddTransient() and AddScoped() methods for singleton, transient and scoped lifetime respectively.

    The following example shows the ways of registering types (service) using extension methods.

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ILog, MyConsoleLogger>();
            services.AddSingleton(typeof(ILog), typeof(MyConsoleLogger));

            services.AddTransient<ILog, MyConsoleLogger>();
            services.AddTransient(typeof(ILog), typeof(MyConsoleLogger));

            services.AddScoped<ILog, MyConsoleLogger>();
            services.AddScoped(typeof(ILog), typeof(MyConsoleLogger));
        }

*/


