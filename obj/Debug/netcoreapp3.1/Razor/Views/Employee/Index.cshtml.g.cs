#pragma checksum "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af60a6c823536f21e4df2f3005e8ac75d0c4994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
using CoreLaboratory2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af60a6c823536f21e4df2f3005e8ac75d0c4994", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d820409025540ca9fc7237ddcd705ab13462dbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n        <th>Surname</th>\r\n        <th>Laboratory</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
           Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
           Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
           Write(item.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
           Write(item.Laboratory.LaboratoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 639, "\"", 687, 2);
            WriteAttributeValue("", 646, "/Employee/DeleteEmployee/", 646, 25, true);
#nullable restore
#line 25 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 671, item.EmployeeID, 671, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 795, 2);
            WriteAttributeValue("", 754, "/Employee/UpdateEmployee/", 754, 25, true);
#nullable restore
#line 26 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 779, item.EmployeeID, 779, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 904, 2);
            WriteAttributeValue("", 863, "/Employee/EmployeeDetail/", 863, 25, true);
#nullable restore
#line 27 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
WriteAttributeValue("", 888, item.EmployeeID, 888, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\" style=\"background-color:#ffd800;\">Details</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\cagrii\Desktop\WebProject\CoreLaboratory2\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Employee/NewEmployee/\" class=\"btn btn-primary\">New Employee</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591