#pragma checksum "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c66a315313a7c2641fa9aae9c0597def8544a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laboratory_Index), @"mvc.1.0.view", @"/Views/Laboratory/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\_ViewImports.cshtml"
using CoreLaboratory2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
using CoreLaboratory2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c66a315313a7c2641fa9aae9c0597def8544a6", @"/Views/Laboratory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d820409025540ca9fc7237ddcd705ab13462dbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Laboratory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Laboratory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c66a315313a7c2641fa9aae9c0597def8544a63720", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.1.1.js\"></script>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
 using (Html.BeginForm("Index", "Laboratory", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Search Laboratory Name ");
#nullable restore
#line 13 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
                      Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 15 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Laboratory</th>\r\n        <th>Type</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
           Write(item.LaboratoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
           Write(item.LaboratoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
           Write(item.LaboratoryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 826, "\"", 880, 2);
            WriteAttributeValue("", 833, "/Laboratory/DeleteLaboratory/", 833, 29, true);
#nullable restore
#line 32 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
WriteAttributeValue("", 862, item.LaboratoryID, 862, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 940, "\"", 994, 2);
            WriteAttributeValue("", 947, "/Laboratory/UpdateLaboratory/", 947, 29, true);
#nullable restore
#line 33 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
WriteAttributeValue("", 976, item.LaboratoryID, 976, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1055, "\"", 1109, 2);
            WriteAttributeValue("", 1062, "/Laboratory/LaboratoryDetail/", 1062, 29, true);
#nullable restore
#line 34 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
WriteAttributeValue("", 1091, item.LaboratoryID, 1091, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\" style=\"background-color:#ffd800;\">Details</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Laboratory\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Laboratory/NewLaboratory/\" class=\"btn btn-primary\">New Laboratory</a>\r\n<script>\r\n    $(\'.btn-danger\').click(function () {\r\n        alert(\"Deletion Successful\");\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Laboratory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
