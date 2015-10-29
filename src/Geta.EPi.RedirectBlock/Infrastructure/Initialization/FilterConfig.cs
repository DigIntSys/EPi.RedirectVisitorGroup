using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Geta.EPi.RedirectBlock.Infrastructure.Initialization
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class FilterConfig: IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            GlobalFilters.Filters.Add(new RedirectAttribute());
        }

        public void Uninitialize(InitializationEngine context)
        {
            
        }
    }
}