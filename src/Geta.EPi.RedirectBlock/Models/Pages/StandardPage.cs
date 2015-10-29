using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Geta.EPi.RedirectBlock.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "c0946018-ce3b-4775-96e0-f47384571ae4", Description = "")]
    public class StandardPage : PageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }


        public virtual ContentArea contentAreaIsHere { get; set; }
    }
}