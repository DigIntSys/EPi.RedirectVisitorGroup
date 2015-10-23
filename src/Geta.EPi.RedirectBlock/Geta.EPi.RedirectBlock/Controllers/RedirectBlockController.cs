using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using Geta.EPi.RedirectBlock.Models.Blocks;

namespace Geta.EPi.RedirectBlock.Controllers
{
    public class RedirectBlockController : BlockController<Models.Blocks.RedirectBlock>
    {
        public override ActionResult Index(Models.Blocks.RedirectBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
