#pragma checksum "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7881f69a9c1f0029e626079c9e34f02aceacf70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Promotions_Index), @"mvc.1.0.view", @"/Views/Promotions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7881f69a9c1f0029e626079c9e34f02aceacf70", @"/Views/Promotions/Index.cshtml")]
    public class Views_Promotions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TrackingVoucher_v02.Models.Promotion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BeginDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BeginDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brand.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1202, "\"", 1225, 1);
#nullable restore
#line 46 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
WriteAttributeValue("", 1217, item.Id, 1217, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1278, "\"", 1301, 1);
#nullable restore
#line 47 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
WriteAttributeValue("", 1293, item.Id, 1293, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1356, "\"", 1379, 1);
#nullable restore
#line 48 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
WriteAttributeValue("", 1371, item.Id, 1371, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "D:\Study\Semester7\repo\TrackingVoucher_v02\Views\Promotions\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TrackingVoucher_v02.Models.Promotion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
