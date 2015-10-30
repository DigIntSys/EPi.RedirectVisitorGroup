using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Geta.EPi.RedirectBlock.Models.Blocks
{
    [ContentType(DisplayName = "RedirectBlock", GUID = "f6b137df-37b7-40b1-b28e-6c999cfa3aff", Description = "")]
    public class RedirectBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Page to redirect to",
            Description = "Redirect to this page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual Url RedirectUrl { get; set; }


    }
}