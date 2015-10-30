using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Editor;
using EPiServer.ServiceLocation;
using EPiServer.SpecializedProperties;
using EPiServer.Web.Routing;

namespace Geta.EPi.RedirectBlock.Infrastructure
{
    public class RedirectAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (PageEditing.PageIsInEditMode)
                return;
            
            var requested= ServiceLocator.Current.GetInstance<PageRouteHelper>();
            if (requested.Page == null)
                return;

            ContentArea contentArea;
            string contentAreaName = requested.Page.Property.FirstOrDefault(x => x is PropertyContentArea)?.Name;
            if (contentAreaName==null)
                return;
            
            if (requested.Page[contentAreaName] ==null)
                return;
            else
            {
                    contentArea = (ContentArea)requested.Page[contentAreaName];
            }

            var redirectBlock = contentArea.FilteredItems.Select(x => x.GetContent()).FirstOrDefault(x => x is Models.Blocks.RedirectBlock);
            if (redirectBlock==null)
                return;
            Url contentReference=((Models.Blocks.RedirectBlock)redirectBlock).RedirectUrl;
            filterContext.Result = new RedirectResult(contentReference.OriginalString);

        }




    }
}
