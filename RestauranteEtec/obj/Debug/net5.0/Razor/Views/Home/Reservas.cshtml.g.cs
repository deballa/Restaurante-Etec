#pragma checksum "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Reservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002bb7a2898750d0a0454e308c0e2b784f0e0afc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Reservas), @"mvc.1.0.view", @"/Views/Home/Reservas.cshtml")]
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
#line 1 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\_ViewImports.cshtml"
using RestauranteEtec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\_ViewImports.cshtml"
using RestauranteEtec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002bb7a2898750d0a0454e308c0e2b784f0e0afc", @"/Views/Home/Reservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec6ffb7a6cb3ace4e99614baab6122d53ef1c87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Reservas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("appointment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Reservas.cshtml"
  
    ViewData["Title"] = "Reservas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 84, "\"", 149, 4);
            WriteAttributeValue("", 92, "background-image:", 92, 17, true);
            WriteAttributeValue(" ", 109, "url(", 110, 5, true);
#nullable restore
#line 5 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Reservas.cshtml"
WriteAttributeValue("", 114, Url.Content("~/images/bg_5.jpg"), 114, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 147, ");", 147, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-5"">
                <h1 class=""mb-2 bread"">Book A Table Now</h1>
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home <i class=""fa fa-chevron-right""></i></a></span> <span>Reservation <i class=""fa fa-chevron-right""></i></span></p>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-wrap-about ftco-no-pb ftco-no-pt"">
    <div class=""container"">
        <div class=""row no-gutters"">
            <div class=""col-sm-12 p-4 p-md-5 d-flex align-items-center justify-content-center bg-primary"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc6329", async() => {
                WriteLiteral(@"
                    <h3 class=""mb-3"">Book your Table</h3>
                    <div class=""row justify-content-center"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Name"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control"" placeholder=""Email"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Phone"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
       ");
                WriteLiteral(@"                         <div class=""input-wrap"">
                                    <div class=""icon""><span class=""fa fa-calendar""></span></div>
                                    <input type=""text"" class=""form-control book_date"" placeholder=""Check-In"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""input-wrap"">
                                    <div class=""icon""><span class=""fa fa-clock-o""></span></div>
                                    <input type=""text"" class=""form-control book_time"" placeholder=""Time"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""form-field"">
                        ");
                WriteLiteral("            <div class=\"select-wrap\">\r\n                                        <div class=\"icon\"><span class=\"fa fa-chevron-down\"></span></div>\r\n                                        <select");
                BeginWriteAttribute("name", " name=\"", 3270, "\"", 3277, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3278, "\"", 3283, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc9314", async() => {
                    WriteLiteral("Guest");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc10580", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc11843", async() => {
                    WriteLiteral("2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc13106", async() => {
                    WriteLiteral("3");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc14369", async() => {
                    WriteLiteral("4");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002bb7a2898750d0a0454e308c0e2b784f0e0afc15632", async() => {
                    WriteLiteral("5");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <input type=""submit"" value=""Book Your Table Now"" class=""btn btn-white py-3 px-4"">
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"ftco-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex\">\r\n            <div class=\"col-md-6 d-flex\">\r\n                <div class=\"img img-2 w-100 mr-md-2\"");
            BeginWriteAttribute("style", " style=\"", 4543, "\"", 4608, 4);
            WriteAttributeValue("", 4551, "background-image:", 4551, 17, true);
            WriteAttributeValue(" ", 4568, "url(", 4569, 5, true);
#nullable restore
#line 88 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Reservas.cshtml"
WriteAttributeValue("", 4573, Url.Content("~/images/bg_6.jpg"), 4573, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4606, ");", 4606, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"img img-2 w-100 ml-md-2\"");
            BeginWriteAttribute("style", " style=\"", 4670, "\"", 4735, 4);
            WriteAttributeValue("", 4678, "background-image:", 4678, 17, true);
            WriteAttributeValue(" ", 4695, "url(", 4696, 5, true);
#nullable restore
#line 89 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Reservas.cshtml"
WriteAttributeValue("", 4700, Url.Content("~/images/bg_4.jpg"), 4700, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4733, ");", 4733, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
            </div>
            <div class=""col-md-6 ftco-animate makereservation p-4 p-md-5"">
                <div class=""heading-section ftco-animate mb-5"">
                    <span class=""subheading"">This is our secrets</span>
                    <h2 class=""mb-4"">Perfect Ingredients</h2>
                    <p>
                        Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.
                    </p>
                    <p><a href=""#"" class=""btn btn-primary"">Learn more</a></p>
                </div>
            </div>
        </div>
    </div>
</section>");
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
