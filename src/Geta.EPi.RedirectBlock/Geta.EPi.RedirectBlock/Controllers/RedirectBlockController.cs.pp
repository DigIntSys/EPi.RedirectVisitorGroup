using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using $rootnamespace$.Models.Blocks;

namespace $rootnamespace$.Controllers
{
    public class RedirectBlockController : BlockController<Models.Blocks.RedirectBlock>
    {
        public override ActionResult Index(Models.Blocks.RedirectBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
