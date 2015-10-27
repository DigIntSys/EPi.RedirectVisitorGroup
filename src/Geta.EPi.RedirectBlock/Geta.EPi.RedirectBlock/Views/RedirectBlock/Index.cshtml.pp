﻿@using EPiServer
@using EPiServer.Core
@using EPiServer.Editor
@using EPiServer.Web.Routing
@model $rootnamespace$.Models.Blocks.RedirectBlock
@{
    Layout = null;
}

<div>
    @Html.PropertyFor(x => x.Name)<br/>

    @{
        var redirectedPage = DataFactory.Instance.Get<PageData>(new ContentReference(Model.pageReference.ID));
        var urlResolver = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<EPiServer.Web.Routing.UrlResolver>();
        var pageUrl = urlResolver.GetVirtualPath(redirectedPage);
    }

    @if (PageEditing.PageIsInEditMode)
    {
        @Html.PropertyFor((x=>x.pageReference))
    }
    else
    {
        <script type="text/javascript">
            window.location.replace("@pageUrl.GetUrl()");
        </script>
       
    }
    
</div>
