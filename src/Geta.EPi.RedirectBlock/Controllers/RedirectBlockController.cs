using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

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
