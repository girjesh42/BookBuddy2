#pragma checksum "C:\Users\Girjesh kumar\Desktop\bb\WebAppBookBudd\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "077ce09ef6efb0282da9c605240a948cef426605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\Girjesh kumar\Desktop\bb\WebAppBookBudd\Views\_ViewImports.cshtml"
using WebAppBookBudd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Girjesh kumar\Desktop\bb\WebAppBookBudd\Views\_ViewImports.cshtml"
using WebAppBookBudd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"077ce09ef6efb0282da9c605240a948cef426605", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb57e1efa7f988ed6b504ae9275e164e264bb0d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("block mbr-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-form-title", new global::Microsoft.AspNetCore.Html.HtmlString("Mobirise Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Girjesh kumar\Desktop\bb\WebAppBookBudd\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Contact Us</h1>

<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <div class=""google-map""><iframe width=""600"" height=""450"" style=""border:0"" loading=""lazy"" allowfullscreen
        src=""https://www.google.com/maps/embed/v1/place?q=place_id:ChIJc0FzvwLBDDkRDUOg3j9PgfM&key=AIzaSyAdqxg4IHSeLIeFzpttxp7hdFbwnJOu-6E""></iframe></div>
        </div>
        <div class=""col"">
            <h2 class=""pb-3 align-left mbr-fonts-style display-2"">
                Drop a Line
            </h2>
            <div>
                <div class=""icon-block pb-3"">
                    <span class=""icon-block__icon"">
                        <span class=""mbri-letter mbr-iconfont"" media-simple=""true""></span>
                    </span>
                    <h4 class=""icon-block__title align-left mbr-fonts-style display-5"">
                        Don't hesitate to contact us
                    </h4>
                </div>
                <div class=""icon-contacts pb-3"">
      ");
            WriteLiteral(@"              <h5 class=""align-left mbr-fonts-style display-7"">
                        Ready for offers and cooperation
                    </h5>
                    <p class=""mbr-text align-left mbr-fonts-style display-7"">
                        Phone: +91 7999595507 <br>
                        Email: bookbuddy1@mail.com
                    </p>
                </div>
            </div>
            <div data-form-type=""formoid"">
                <div data-form-alert=""""");
            BeginWriteAttribute("hidden", " hidden=\"", 1555, "\"", 1564, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Thanks for filling out the form!\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "077ce09ef6efb0282da9c605240a948cef4266056625", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" data-form-email=""true"" value=""VyfBhjXY/U/Zmt1Pt1h8AUq3OZw8hzMN2LHhS02AKmRlJXOXYztQHFLe4ZtOqtsGZcolY6Zc/k02XjN6+grxxBoiXlO8zOY2aPEWv+XteZzFKh7BTcuG/y+UuTZ6thxI"">
                    <div class=""row"">
                        <div class=""col-md-6 multi-horizontal"" data-for=""name"">
                            <input type=""text"" class=""form-control input"" name=""name"" data-form-field=""Name"" placeholder=""Your Name""");
                BeginWriteAttribute("required", " required=\"", 2204, "\"", 2215, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""name-form4-2y"">
                        </div>
                        <div class=""col-md-6 multi-horizontal"" data-for=""phone"">
                            <input type=""text"" class=""form-control input"" name=""phone"" data-form-field=""Phone"" placeholder=""Phone""");
                BeginWriteAttribute("required", " required=\"", 2482, "\"", 2493, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"phone-form4-2y\">\r\n                        </div>\r\n                        <div class=\"col-md-12\" data-for=\"email\">\r\n                            <input type=\"text\" class=\"form-control input\" name=\"email\" data-form-field=\"Email\" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 2745, "\"", 2756, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""email-form4-2y"">
                        </div>
                        <div class=""col-md-12"" data-for=""message"">
                            <textarea class=""form-control input"" name=""message"" rows=""3"" data-form-field=""Message"" placeholder=""Message"" style=""resize:none"" id=""message-form4-2y""></textarea>
                        </div>
                        <div class=""input-group-btn col-md-12"" style=""margin-top: 10px;"">
                            <button");
                BeginWriteAttribute("href", " href=\"", 3230, "\"", 3237, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-primary btn-form display-4\">SEND MESSAGE</button>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
