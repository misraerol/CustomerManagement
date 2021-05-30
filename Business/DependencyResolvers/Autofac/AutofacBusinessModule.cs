using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //dependency injection:bağımlılıları yönettim
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<OtherCustomerManager>().As<ICustomerService>().SingleInstance();

            builder.RegisterType<StarbucksCustomerManager>().As<ICustomerService>().SingleInstance();
           
            builder.RegisterType<MernisServiceAdapter>().As<IUserValidationService>().SingleInstance();

            
        }
    }
}
