#pragma checksum "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506b259594770de11bef2c275d72ffe521ac49e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Add), @"mvc.1.0.view", @"/Views/Contact/Add.cshtml")]
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
#line 1 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\_ViewImports.cshtml"
using ContactListAssignmente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\_ViewImports.cshtml"
using ContactListAssignmente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506b259594770de11bef2c275d72ffe521ac49e9", @"/Views/Contact/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed71b5dd014d11c7fd6005e2e8a0cc64c891edf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Add.cshtml"
  
    ViewData["Title"] = "Contacts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h1>Add Contact</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Add.cshtml"
     using (Html.BeginForm("Add", "Contact", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""form-group"">
                <label for=""firstName"">First Name</label>
                <input type=""text"" class=""form-control"" id=""firstName"" placeholder=""Enter First Name"" name=""firstName"" />
            </div>
            <div class=""form-group"">
                <label for=""lastName"">Last Name</label>
                <input type=""text"" class=""form-control"" id=""lastName"" placeholder=""Enter Last Name"" name=""lastName"">
            </div>
            <div class=""form-group"">
                <label for=""phone"">Phone</label>
                <input type=""tel"" class=""form-control"" id=""phone"" placeholder=""Enter Phone Number"" name=""phone"">
            </div>
            <div class=""form-group"">
                <label for=""email"">Email</label>
                <input type=""email"" class=""form-control"" id=""email"" placeholder=""Enter Email Address"" name=""email"">
            </div>
            <button type=""submit"" class=""btn btn-primary"">SAVE</button>
");
#nullable restore
#line 29 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
