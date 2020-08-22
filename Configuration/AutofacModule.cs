
using Autofac;
using PrivateWork.Core;
using PrivateWork.Data;

namespace PrivateWork.API.Configuration
{
    public class AutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseOptions>().As<IDatabaseOptions>();
            builder.RegisterType<UrlOptions>().As<IUrlOptions>();
            builder.RegisterType<ProductsRepositoty>().As<IProductsRepositoty>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();


        }
    }
}
