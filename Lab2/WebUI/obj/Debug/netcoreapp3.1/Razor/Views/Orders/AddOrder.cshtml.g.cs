#pragma checksum "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Orders\AddOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6e4184d2a44470e4fa8ff46dd483271e8801c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_AddOrder), @"mvc.1.0.view", @"/Views/Orders/AddOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e4184d2a44470e4fa8ff46dd483271e8801c04", @"/Views/Orders/AddOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663a78a22c301d934546fdb22d7e5ded85de9de6", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_AddOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Orders\AddOrder.cshtml"
  
    ViewData["Title"] = "Добавление заказа";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Форма добавления заказа</h3>\r\n    <p>Для добавления заказа заполните следующие поля:</p>\r\n");
#nullable restore
#line 8 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Orders\AddOrder.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <tr>
                <td>ID Пользователя:</td>
                <td><input type=""text"" name=""UserID"" /></td>
            </tr>
            <tr>
                <td>ID продукта:</td>
                <td><input type=""text"" name=""ProductID"" /></td>
            </tr>
            <tr>
                <td>Количество:</td>
                <td><input type=""text"" name=""Quantity"" /></td>
            </tr>
            <tr><td><input type=""submit"" value=""Отправить"" /></td></tr>
        </table>
");
#nullable restore
#line 25 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Orders\AddOrder.cshtml"
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
