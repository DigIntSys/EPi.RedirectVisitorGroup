# Geta.EPi.RedirectVisitorGroup

![](http://tc.geta.no/app/rest/builds/buildType:(id:TeamFrederik_EPiRedirectVisitorGroup_EPiRedirectVisitorGroupCreateAndPublishNuGe)/statusIcon)

Allows editors to redirect to EPiServer pages and external URLs based on different visitor group criterias.

```
Install-Package Geta.EPi.RedirectVisitorGroup
```

Implement the interface IRedirectVisitorGroup in the content types that should be able to redirect based on visitor group criterias.

Editors can then drag and drop pages with or without shortcuts to external content into the RedirectVisitorGroup content area (and of course use personalization).

![alt demo](https://github.com/Geta/EPi.RedirectVisitorGroup/blob/master/RedirectVisitorGroup.gif) 
