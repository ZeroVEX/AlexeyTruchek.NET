#pragma checksum "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Recipes\DeleteRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89f8aef092af65baff5c3ad8cefb0d868bb5380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_DeleteRecipe), @"mvc.1.0.view", @"/Views/Recipes/DeleteRecipe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89f8aef092af65baff5c3ad8cefb0d868bb5380", @"/Views/Recipes/DeleteRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663a78a22c301d934546fdb22d7e5ded85de9de6", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_DeleteRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Recipes\DeleteRecipe.cshtml"
  
    ViewData["Title"] = "Удаление рецепта";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Форма удаления рецепта</h3>\r\n    <p>Для удаления рецепта введите его ID:</p>\r\n");
#nullable restore
#line 8 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Recipes\DeleteRecipe.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>ID:</td>\r\n                <td><input type=\"number\" name=\"ID\" /></td>\r\n            </tr>\r\n            <tr><td><input type=\"submit\" value=\"Отправить\" /></td></tr>\r\n        </table>\r\n");
#nullable restore
#line 17 "C:\Users\Alex\Documents\GitHub\AlexeyTruchek.NET\Lab2\WebUI\Views\Recipes\DeleteRecipe.cshtml"
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