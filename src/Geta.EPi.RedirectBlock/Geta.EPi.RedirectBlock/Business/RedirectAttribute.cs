using System;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

namespace Geta.EPi.RedirectBlock.Business
{
    public class RedirectAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!bIsPageController(filterContext.Controller.GetType()))
                return;
            
            var s= ServiceLocator.Current.GetInstance<PageRouteHelper>();
            if (s.Page == null)
                return;
            
            ContentArea contentArea;
            if (s.Page["contentArea"]==null)
                return;
            else
            {
                    contentArea = (ContentArea) s.Page["ContentArea"];
            }

            if (contentArea== null)
                return;
            var redirectBlock = contentArea.FilteredItems.Select(x => x.GetContent()).FirstOrDefault(x => x is Models.Blocks.RedirectBlock);
            if (redirectBlock==null)
                return;
            Url contentReference=((Models.Blocks.RedirectBlock)redirectBlock).contentReference;
            filterContext.Result = new RedirectResult(contentReference.OriginalString);
                
            
        }


        private bool bIsPageController(Type type)
        {
            if (type.Name == typeof (PageController<PageData>).Name)
                return true;
            else
            {
                if (type.BaseType!=typeof(object) && type.BaseType!=null && type.BaseType.Name!= "ContentController`1")
                    return bIsPageController(type.BaseType);
            }
            return false;
        }

    }
}
