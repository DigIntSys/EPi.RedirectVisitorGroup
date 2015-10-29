using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Geta.EPi.RedirectBlock.Models.Blocks
{
    public class RedirectBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual String Name { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Page to redirect",
            Description = "Redirect to this page",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual Url contentReference { get; set; }


    }
}