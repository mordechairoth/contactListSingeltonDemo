#pragma checksum "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10aabc23a152f5fb4909f941d4a7bd3cd614ee16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Edit), @"mvc.1.0.view", @"/Views/Contact/Edit.cshtml")]
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
#nullable restore
#line 1 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
using ContactListAssignmente.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10aabc23a152f5fb4909f941d4a7bd3cd614ee16", @"/Views/Contact/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed71b5dd014d11c7fd6005e2e8a0cc64c891edf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
  
    ViewData["Title"] = "Contacts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h1>Edit Contact</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
     using (Html.BeginForm("Edit", "Contact", FormMethod.Post))
    {
        Contact contact = ContactsHandler.GetInstance().Find(ViewBag.ContactId);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"firstName\">First Name</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"firstName\" placeholder=\"Enter First Name\" name=\"firstName\"");
            BeginWriteAttribute("value", " value=\"", 499, "\"", 525, 1);
#nullable restore
#line 16 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
WriteAttributeValue("", 507, contact.FirstName, 507, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"lastName\">Last Name</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"lastName\" placeholder=\"Enter Last Name\" name=\"lastName\"");
            BeginWriteAttribute("value", " value=\"", 744, "\"", 769, 1);
#nullable restore
#line 20 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
WriteAttributeValue("", 752, contact.LastName, 752, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"phone\">Phone</label>\r\n            <input type=\"tel\" class=\"form-control\" id=\"phone\" placeholder=\"Enter Phone Number\" name=\"phone\"");
            BeginWriteAttribute("value", " value=\"", 976, "\"", 998, 1);
#nullable restore
#line 24 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
WriteAttributeValue("", 984, contact.Phone, 984, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"email\">Email</label>\r\n            <input type=\"email\" class=\"form-control\" id=\"email\" placeholder=\"Enter Email Address\" name=\"email\"");
            BeginWriteAttribute("value", " value=\"", 1208, "\"", 1230, 1);
#nullable restore
#line 28 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
WriteAttributeValue("", 1216, contact.Email, 1216, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1278, "\"", 1297, 1);
#nullable restore
#line 30 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
WriteAttributeValue("", 1286, contact.Id, 1286, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <button type=\"submit\" class=\"btn btn-primary\">SAVE</button>\r\n");
#nullable restore
#line 32 "C:\Users\morde\source\repos\ContactListAssignmente\ContactListAssignmente\Views\Contact\Edit.cshtml"
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
