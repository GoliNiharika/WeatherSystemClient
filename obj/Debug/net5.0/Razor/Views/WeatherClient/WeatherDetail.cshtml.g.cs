#pragma checksum "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1591ea3e2613e79cbceaf8ace9c5680f0ef477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WeatherClient_WeatherDetail), @"mvc.1.0.view", @"/Views/WeatherClient/WeatherDetail.cshtml")]
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
#line 1 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\_ViewImports.cshtml"
using WeatherClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\_ViewImports.cshtml"
using WeatherClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1591ea3e2613e79cbceaf8ace9c5680f0ef477", @"/Views/WeatherClient/WeatherDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d067d653abb8198352c72854dbb027352bda6781", @"/Views/_ViewImports.cshtml")]
    public class Views_WeatherClient_WeatherDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherClient.Models.WeatherDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #eaffff; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
  
    ViewData["Title"] = "WeatherDetail";
    Layout = "~/Views/Shared/_AfterLoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>WeatherDetail</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1591ea3e2613e79cbceaf8ace9c5680f0ef4774357", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"" style=""overflow-y: auto;"">
                <div class=""row"">
                    <div class=""card-body"" style=""background-color: #c0e2ff"">
                        <div class=""col-4"">
                            <div class=""card"" style=""overflow-y: auto;"">
                                <div class=""card-body"" style=""background-color: lightgrey"">
                                    <p>sdu jweyuyu hgwet ytwyetywhe ytwyghgwuqy</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-4"">
                            <div class=""card"" style=""overflow-y: auto;"">
                                <div class=""card-body"" style=""background-color: lightgrey"">
                                    <p>sdu jweyuyu hgwet ytwyetywhe ytwyghgwuqy</p>
                                </div>
                            </div>
                   ");
                WriteLiteral(@"     </div>
                        <div class=""col-3"">
                            <div class=""card"" style=""overflow-y: auto;"">
                                <div class=""card-body"" style=""background-color: lightgrey"">
                                    <p>sdu jweyuyu hgwet ytwyetywhe ytwyghgwuqy</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div>

        <hr />
        <dl class=""row"">
            <dt class=""col-sm-2"">
                ");
#nullable restore
#line 48 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Wid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayFor(model => model.Wid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 54 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 57 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 60 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Temperature));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 63 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayFor(model => model.Temperature));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 66 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Humidity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 69 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayFor(model => model.Humidity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 72 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Visibility));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 75 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
           Write(Html.DisplayFor(model => model.Visibility));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 80 "C:\Users\ngoli\source\repos\WeatherClient\WeatherSystemClient\Views\WeatherClient\WeatherDetail.cshtml"
   Write(Html.ActionLink("Edit", "Edit", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1591ea3e2613e79cbceaf8ace9c5680f0ef47710246", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherClient.Models.WeatherDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
