@using EPiServer
@using EPiServer.Core
@using EPiServer.Editor
@using EPiServer.Web.Mvc.Html
@using EPiServer.Web.Routing
@model $rootnamespace$.Models.Blocks.RedirectBlock
@{
    Layout = null;
}

<div>
    @Html.PropertyFor(x => x.Name)<br/>
</div>

