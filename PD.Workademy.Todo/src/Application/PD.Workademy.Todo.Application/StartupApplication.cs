using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PD.Workademy.Todo.Application.Services;

namespace PD.Workademy.Todo.Application
{
    public class StartupApplication
    {
        public StartupApplication(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }
        public IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Dependancies
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITodoItemService, TodoItemService>();
            
        }
    }
}
