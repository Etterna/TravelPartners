using System.Configuration;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using TravelPartners.Repositories;
using TravelPartners.Repositories.Db;

namespace TravelPartners.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            builder.RegisterType<Repository>().As<IRepository>()
                .WithParameter("connectionString", connectionString);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}