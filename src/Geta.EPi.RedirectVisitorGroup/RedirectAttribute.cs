using System.Linq;
using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;
using EPiServer.Web.Routing.Segments.Internal;

namespace Geta.EPi.RedirectVisitorGroup
{
	public class RedirectAttribute : ActionFilterAttribute
	{
		public Injected<IPageRouteHelper> PageRouteHelper { get; set; }
		public Injected<UrlResolver> UrlResolver { get; set; }

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (RequestSegmentContext.CurrentContextMode == ContextMode.Edit ||
			    RequestSegmentContext.CurrentContextMode == ContextMode.Preview)
			{
				return;
			}

			var content = PageRouteHelper.Service.Content;

			// ReSharper disable once SuspiciousTypeConversion.Global
			var redirectPage = (content as IRedirectVisitorGroup)?.RedirectContentArea?.FilteredItems.Select(x => x.GetContent())
				.FirstOrDefault();

			if (redirectPage == null)
			{
				return;
			}

			string url = UrlResolver.Service.GetUrl(redirectPage.ContentLink);

			if (redirectPage is PageData)
			{
				PageShortcutType propertyLinkType = ((PageData) redirectPage).LinkType;

				if (propertyLinkType == PageShortcutType.External)
				{
					url = ((PageData) redirectPage).LinkURL;
				}
			}

			filterContext.Result = new RedirectResult(url);
		}
	}
}