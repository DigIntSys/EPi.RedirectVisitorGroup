using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace $rootnamespace$.Models.Blocks
{
    [ContentType(DisplayName = "RedirectBlock", GUID = "4c2d94fc-4b49-4ca8-bae8-7bec195b13f9", Description = "")]
    public class RedirectBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Name { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Page to redirect",
            Description = "Redirect to this page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual PageReference pageReference { get; set; }

        //[ScaffoldColumn(false)]


    }
}