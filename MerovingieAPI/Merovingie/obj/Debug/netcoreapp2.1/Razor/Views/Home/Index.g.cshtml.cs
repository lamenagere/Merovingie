#pragma checksum "C:\Users\sargo\Documents\Merovingie\MerovingieAPI\Merovingie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613566539cabb87bf87ef98f98e5b2ca78a83a7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\sargo\Documents\Merovingie\MerovingieAPI\Merovingie\Views\_ViewImports.cshtml"
using Merovingie;

#line default
#line hidden
#line 2 "C:\Users\sargo\Documents\Merovingie\MerovingieAPI\Merovingie\Views\_ViewImports.cshtml"
using Merovingie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613566539cabb87bf87ef98f98e5b2ca78a83a7b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30ba5b52450bb3cf3cc68fb86821bc4d38ea5f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\sargo\Documents\Merovingie\MerovingieAPI\Merovingie\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 858, true);
            WriteLiteral(@"
<h1>Web Sockets Tests</h1>
<span id=""stateLabel"">Ready</span>
<div id=""connectionForm"">
    <label for=""connectionUrl"">Websocket connection URL:</label>
    <input id=""connectionUrl"" name=""connectionUrl"" type=""text"" />
    <button id=""connectButton"" type=""submit"">Connect</button>

    <label for=""sendMessage"">Enter your message:</label>
    <input id=""sendMessage"" name=""sendMessage"" type=""text"" />
    <button id=""sendButton"" type=""submit"">Send</button>
    <button id=""closeButton"" disabled>Close Socket</button>
</div>

<div>
    <button type=""button"" id=""loadbutton"">
        Load Game
    </button>
</div>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>From</th>
            <th>To</th>
            <th>Data</th>
        </tr>
    </thead>
    <tbody id=""commsLog"">

    </tbody>
</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
