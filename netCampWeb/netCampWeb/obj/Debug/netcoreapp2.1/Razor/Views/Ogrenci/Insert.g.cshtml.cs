#pragma checksum "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9863cb18e1f294dad9e057cfd2d4e97f557689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Insert), @"mvc.1.0.view", @"/Views/Ogrenci/Insert.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ogrenci/Insert.cshtml", typeof(AspNetCore.Views_Ogrenci_Insert))]
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
#line 1 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\_ViewImports.cshtml"
using netCampWeb;

#line default
#line hidden
#line 2 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\_ViewImports.cshtml"
using netCampWeb.Models;

#line default
#line hidden
#line 2 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
using netCampWeb.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9863cb18e1f294dad9e057cfd2d4e97f557689", @"/Views/Ogrenci/Insert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03fb6e8e878c4bc3c45629a4a650a88e048518e", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_Insert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ogrenci", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
  
    ViewData["Title"] = "Ogrenci Ekleme Formu";

#line default
#line hidden
            BeginContext(107, 23, true);
            WriteLiteral("\r\n\r\n<h2>Ogrenci Formu\r\n");
            EndContext();
            BeginContext(130, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f49b05267e8144678d4c22a914b62db7", async() => {
                BeginContext(213, 5, true);
                WriteLiteral(" Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(231, 968, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a6429bbfd644755bd9605235d5a30f4", async() => {
                BeginContext(282, 70, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label>Kullanıcı Adı</label>\r\n");
                EndContext();
                BeginContext(386, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(395, 69, false);
#line 15 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
   Write(Html.TextBoxFor(q => q.KullaniciAdi, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(464, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(610, 78, true);
                WriteLiteral("    </div>\r\n    <div class=\"form-group\">\r\n        <label>Adı</label>\r\n        ");
                EndContext();
                BeginContext(689, 60, false);
#line 21 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
   Write(Html.TextBoxFor(q => q.Adi, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(749, 84, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label> Soyadı</label>\r\n        ");
                EndContext();
                BeginContext(834, 63, false);
#line 25 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
   Write(Html.TextBoxFor(q => q.Soyadi, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(897, 81, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Yası</label>\r\n        ");
                EndContext();
                BeginContext(979, 61, false);
#line 29 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
   Write(Html.TextBoxFor(q => q.Yasi, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1040, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
                EndContext();
                BeginContext(1096, 76, true);
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n    <p>");
                EndContext();
                BeginContext(1173, 13, false);
#line 35 "C:\Users\Gamze\source\repos\.netCamp\netCampWeb\netCampWeb\Views\Ogrenci\Insert.cshtml"
  Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(1186, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
