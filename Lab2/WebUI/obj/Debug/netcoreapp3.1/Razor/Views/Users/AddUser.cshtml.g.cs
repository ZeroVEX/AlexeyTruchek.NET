#pragma checksum "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Users\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c8b2922d6170bfd557fc762c370eab9ba8f300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AddUser), @"mvc.1.0.view", @"/Views/Users/AddUser.cshtml")]
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
#line 1 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\_ViewImports.cshtml"
using WebUI.App_Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c8b2922d6170bfd557fc762c370eab9ba8f300", @"/Views/Users/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663a78a22c301d934546fdb22d7e5ded85de9de6", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Users\AddUser.cshtml"
  
    ViewData["Title"] = "Добавление пользователя";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Форма добавления пользователя</h3>\r\n    <p>Для добавления пользователя заполните следующие поля:</p>\r\n");
#nullable restore
#line 8 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Users\AddUser.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <input type=""hidden"" value=""1"" name=""UserType"" />
        <table>
            <tr>
                <td>Логин:</td>
                <td><input type=""text"" name=""Login"" /></td>
            </tr>
            <tr>
                <td>Пароль:</td>
                <td><input type=""text"" name=""Password"" /></td>
            </tr>
            <tr>
                <td>Название компании:</td>
                <td><input type=""text"" name=""CompanyName"" /></td>
            </tr>
            <tr><td><input type=""submit"" value=""Отправить"" /></td></tr>
        </table>
");
#nullable restore
#line 26 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Users\AddUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
