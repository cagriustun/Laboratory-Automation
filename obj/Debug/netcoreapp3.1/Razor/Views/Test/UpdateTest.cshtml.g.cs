#pragma checksum "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5947d79c7365cef2e95b67e329b9672b4270f6b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_UpdateTest), @"mvc.1.0.view", @"/Views/Test/UpdateTest.cshtml")]
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
#line 2 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\_ViewImports.cshtml"
using CoreLaboratory2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5947d79c7365cef2e95b67e329b9672b4270f6b9", @"/Views/Test/UpdateTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d820409025540ca9fc7237ddcd705ab13462dbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_UpdateTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreLaboratory2.Models.Test>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
  
    ViewData["Title"] = "UpdateTest";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 7 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
 using (Html.BeginForm("UpdateTest1", "Test", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Test ID</b>\r\n");
#nullable restore
#line 10 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
Write(Html.TextBoxFor(x => x.TestID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Test Name</b>\r\n");
#nullable restore
#line 13 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
Write(Html.TextBoxFor(x => x.TestName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Test Type</b>\r\n");
#nullable restore
#line 16 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
Write(Html.TextBoxFor(x => x.TestTypes, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Test Description</b>\r\n");
#nullable restore
#line 19 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
Write(Html.TextBoxFor(x => x.TestDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Employee</b>\r\n");
#nullable restore
#line 22 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
Write(Html.DropDownListFor(x => x.Employee.EmployeeID, (List<SelectListItem>)ViewBag.data, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Update Employee</button>\r\n");
#nullable restore
#line 25 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Test\UpdateTest.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreLaboratory2.Models.Test> Html { get; private set; }
    }
}
#pragma warning restore 1591