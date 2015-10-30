using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Geta.EPi.RedirectVisitorGroup
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RedirectInitialization: IInitializableModule
    {
        private static bool _initialized;

        public void Initialize(InitializationEngine context)
        {
            if (_initialized)
            {
                return;
            }

            GlobalFilters.Filters.Add(new RedirectAttribute());

            _initialized = true;
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}