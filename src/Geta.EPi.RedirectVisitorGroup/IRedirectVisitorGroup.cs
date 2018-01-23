using EPiServer.Core;

namespace Geta.EPi.RedirectVisitorGroup
{
	/// <summary>
	/// Marker interface used to indicate that there is a ContentArea property for visitor criteria redirection
	/// </summary>
	public interface IRedirectVisitorGroup
	{
		ContentArea RedirectContentArea { get; set; }
	}
}