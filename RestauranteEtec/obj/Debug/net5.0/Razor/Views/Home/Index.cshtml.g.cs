#pragma checksum "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707b645620352401ce3ed4cae3b0cb7373ab690f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707b645620352401ce3ed4cae3b0cb7373ab690f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec6ffb7a6cb3ace4e99614baab6122d53ef1c87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Banners -->\r\n<section class=\"hero-wrap\">\r\n    <div class=\"home-slider owl-carousel js-fullheight\">\r\n        <div class=\"slider-item js-fullheight\"");
            BeginWriteAttribute("style", " style=\"", 193, "\"", 257, 3);
            WriteAttributeValue("", 201, "background-image:url(", 201, 21, true);
#nullable restore
#line 8 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 222, Url.Content("~/images/bg_1.jpg"), 222, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 255, ");", 255, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""overlay""></div>
            <div class=""container"">
                <div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-center"">
                    <div class=""col-md-12 ftco-animate"">
                        <div class=""text w-100 mt-5 text-center"">
                            <span class=""subheading"">Restaurante Etec</span>
                            <h1>Cozinhando Desde</h1>
                            <span class=""subheading-2"">1993</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""slider-item js-fullheight""");
            BeginWriteAttribute("style", " style=\"", 947, "\"", 1011, 3);
            WriteAttributeValue("", 955, "background-image:url(", 955, 21, true);
#nullable restore
#line 23 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 976, Url.Content("~/images/bg_2.jpg"), 976, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1009, ");", 1009, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""overlay""></div>
            <div class=""container"">
                <div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-center"">
                    <div class=""col-md-12 ftco-animate"">
                        <div class=""text w-100 mt-5 text-center"">
                            <span class=""subheading"">Restaurante Etec</span>
                            <h1>A Melhor Qualidade</h1>
                            <span class=""subheading-2 sub"">Pratos Diversos</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- end banners -->
<!-- Menu -->
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-2"">
            <div class=""col-md-7 text-center heading-section ftco-animate"">
                <span class=""subheading"">Especialidades</span>
                <h2 class=""mb-4"">Nosso Menu");
            WriteLiteral(@"</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-lg-4"">
                <div class=""menu-wrap"">
                    <div class=""heading-menu text-center ftco-animate"">
                        <h3>Café da Manhã</h3>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img""");
            BeginWriteAttribute("style", " style=\"", 2451, "\"", 2523, 4);
            WriteAttributeValue("", 2459, "background-image:", 2459, 17, true);
            WriteAttributeValue(" ", 2476, "url(", 2477, 5, true);
#nullable restore
#line 56 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 2481, Url.Content("~/images/breakfast-1.jpg"), 2481, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2521, ");", 2521, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img""");
            BeginWriteAttribute("style", " style=\"", 3276, "\"", 3348, 4);
            WriteAttributeValue("", 3284, "background-image:", 3284, 17, true);
            WriteAttributeValue(" ", 3301, "url(", 3302, 5, true);
#nullable restore
#line 70 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 3306, Url.Content("~/images/breakfast-2.jpg"), 3306, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3346, ");", 3346, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus border-bottom-0 d-flex ftco-animate"">
                        <div class=""menu-img img""");
            BeginWriteAttribute("style", " style=\"", 4117, "\"", 4189, 4);
            WriteAttributeValue("", 4125, "background-image:", 4125, 17, true);
            WriteAttributeValue(" ", 4142, "url(", 4143, 5, true);
#nullable restore
#line 84 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 4147, Url.Content("~/images/breakfast-3.jpg"), 4147, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4187, ");", 4187, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <span class=""flat flaticon-bread"" style=""left: 0;""></span>
                    <span class=""flat flaticon-breakfast"" style=""right: 0;""></span>
                </div>
            </div>

            <div class=""col-md-6 col-lg-4"">
                <div class=""menu-wrap"">
                    <div class=""heading-menu text-center ftco-animate"">
            ");
            WriteLiteral("            <h3>Almoço</h3>\r\n                    </div>\r\n                    <div class=\"menus d-flex ftco-animate\">\r\n                        <div class=\"menu-img img\"");
            BeginWriteAttribute("style", " style=\"", 5381, "\"", 5449, 4);
            WriteAttributeValue("", 5389, "background-image:", 5389, 17, true);
            WriteAttributeValue(" ", 5406, "url(", 5407, 5, true);
#nullable restore
#line 108 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 5411, Url.Content("~/images/lunch-1.jpg"), 5411, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5447, ");", 5447, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img""");
            BeginWriteAttribute("style", " style=\"", 6202, "\"", 6270, 4);
            WriteAttributeValue("", 6210, "background-image:", 6210, 17, true);
            WriteAttributeValue(" ", 6227, "url(", 6228, 5, true);
#nullable restore
#line 122 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 6232, Url.Content("~/images/lunch-2.jpg"), 6232, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6268, ");", 6268, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus border-bottom-0 d-flex ftco-animate"">
                        <div class=""menu-img img""");
            BeginWriteAttribute("style", " style=\"", 7039, "\"", 7107, 4);
            WriteAttributeValue("", 7047, "background-image:", 7047, 17, true);
            WriteAttributeValue(" ", 7064, "url(", 7065, 5, true);
#nullable restore
#line 136 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 7069, Url.Content("~/images/lunch-3.jpg"), 7069, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7105, ");", 7105, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <span class=""flat flaticon-pizza"" style=""left: 0;""></span>
                    <span class=""flat flaticon-chicken"" style=""right: 0;""></span>
                </div>
            </div>

            <div class=""col-md-6 col-lg-4"">
                <div class=""menu-wrap"">
                    <div class=""heading-menu text-center ftco-animate"">
              ");
            WriteLiteral(@"          <h3>Jantar</h3>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/dinner-1.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/dinner-2.jpg);""></");
            WriteLiteral(@"div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus border-bottom-0 d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/dinner-3.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roa");
            WriteLiteral(@"st Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <span class=""flat flaticon-omelette"" style=""left: 0;""></span>
                    <span class=""flat flaticon-burger"" style=""right: 0;""></span>
                </div>
            </div>

            <!--  -->
            <div class=""col-md-6 col-lg-4"">
                <div class=""menu-wrap"">
                    <div class=""heading-menu text-center ftco-animate"">
                        <h3>Sobremessas</h3>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""back");
            WriteLiteral(@"ground-image: url(images/dessert-1.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/dessert-2.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                   ");
            WriteLiteral(@"                 <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus border-bottom-0 d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/dessert-3.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</");
            WriteLiteral(@"span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <span class=""flat flaticon-cupcake"" style=""left: 0;""></span>
                    <span class=""flat flaticon-ice-cream"" style=""right: 0;""></span>
                </div>
            </div>

            <div class=""col-md-6 col-lg-4"">
                <div class=""menu-wrap"">
                    <div class=""heading-menu text-center ftco-animate"">
                        <h3>Vinhos</h3>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/wine-1.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
   ");
            WriteLiteral(@"                                 <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/wine-2.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</spa");
            WriteLiteral(@"n>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus border-bottom-0 d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/wine-3.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
        ");
            WriteLiteral(@"                </div>
                    </div>
                    <span class=""flat flaticon-wine"" style=""left: 0;""></span>
                    <span class=""flat flaticon-wine-1"" style=""right: 0;""></span>
                </div>
            </div>

            <div class=""col-md-6 col-lg-4"">
                <div class=""menu-wrap"">
                    <div class=""heading-menu text-center ftco-animate"">
                        <h3>Bebidas &amp; Chá</h3>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/drink-1.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span cla");
            WriteLiteral(@"ss=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <div class=""menus d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/drink-2.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
    ");
            WriteLiteral(@"                    </div>
                    </div>
                    <div class=""menus border-bottom-0 d-flex ftco-animate"">
                        <div class=""menu-img img"" style=""background-image: url(images/drink-3.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Beef Roast Source</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                    <span class=""flat flaticon-wine"" style=""left: 0;""></span>
                    <span class=""flat flaticon-wine-1"" style=""right: 0");
            WriteLiteral(";\"></span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- end menu -->\r\n<!-- Banner 2 -->\r\n<section class=\"ftco-section ftco-intro\"");
            BeginWriteAttribute("style", " style=\"", 19570, "\"", 19635, 4);
            WriteAttributeValue("", 19578, "background-image:", 19578, 17, true);
            WriteAttributeValue(" ", 19595, "url(", 19596, 5, true);
#nullable restore
#line 367 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 19600, Url.Content("~/images/bg_3.jpg"), 19600, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 19633, ");", 19633, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""overlay"">
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <span>Agendamentos para</span>
                <h2>Jantares Particulares &amp; Happy Hours</h2>
            </div>
        </div>
    </div>
</section>
<!-- end banner 2 -->
<!-- Chefes -->
<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-2"">
            <div class=""col-md-7 text-center heading-section ftco-animate"">
                <span class=""subheading"">Chef</span>
                <h2 class=""mb-4"">Nossos Chefes</h2>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 390 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
             foreach(var chefe in ViewBag.Chefes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                    <div class=\"staff\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 20583, "\"", 20639, 4);
            WriteAttributeValue("", 20591, "background-image:", 20591, 17, true);
            WriteAttributeValue(" ", 20608, "url(", 20609, 5, true);
#nullable restore
#line 394 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 20613, Url.Content(chefe.Foto), 20613, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 20637, ");", 20637, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"text px-4 pt-2\">\r\n                        <h3>");
#nullable restore
#line 396 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
                       Write(chefe.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <span class=\"position mb-2\">");
#nullable restore
#line 397 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
                                               Write(chefe.Cargo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <div class=\"faded\">\r\n                                <p>");
#nullable restore
#line 399 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
                              Write(chefe.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 404 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
            }          

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- end chefes -->


<!-- Reserva
<section class=""ftco-section ftco-wrap-about ftco-no-pb ftco-no-pt"">
    <div class=""container"">
        <div class=""row no-gutters"">
            <div class=""col-sm-4 p-4 p-md-5 d-flex align-items-center justify-content-center bg-primary"">
                <form action=""#"" class=""appointment-form"">
                    <h3 class=""mb-3"">Reserve sua Mesa</h3>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Nome"">
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control"" placeholder=""E-mail"">
                            </div>
                        </div>
           ");
            WriteLiteral(@"             <div class=""col-md-12"">
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Fone"">
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <div class=""input-wrap"">
                                    <div class=""icon""><span class=""fa fa-calendar""></span></div>
                                    <input type=""text"" class=""form-control book_date"" placeholder=""Data"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <div class=""input-wrap"">
                                    <div class=""icon""><span class=""fa fa-clock-o""></span></div>
                                    <in");
            WriteLiteral(@"put type=""text"" class=""form-control book_time"" placeholder=""Hora"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <div class=""form-field"">
                                    <div class=""select-wrap"">
                                        <div class=""icon""><span class=""fa fa-chevron-down""></span></div>
                                        <select name="""" id="""" class=""form-control"">
                                            <option value="""">Convidados</option>
                                            <option value="""">1</option>
                                            <option value="""">2</option>
                                            <option value="""">3</option>
                                            <option value="""">4</option>
                                            <option value=""");
            WriteLiteral(@""">5</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <input type=""submit"" value=""Reserve agora"" class=""btn btn-white py-3 px-4"">
                            </div>
                        </div>
                    </div>
                </form>
            </div>
            <div class=""col-sm-8 wrap-about py-5 ftco-animate img"" style=""background-image: url(");
#nullable restore
#line 475 "C:\Users\debor\Documents\2020-2021 ETEC DS\3 DS\Programação Web III\Projetos\RestauranteEtec\RestauranteEtec\Views\Home\Index.cshtml"
                                                                                           Write(Url.Content("~/images/about.jpg"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@");"">
                <div class=""row pb-5 pb-md-0"">
                    <div class=""col-md-12 col-lg-7"">
                        <div class=""heading-section mt-5 mb-4"">
                            <div class=""pl-lg-3 ml-md-5"">
                                <span class=""subheading"">Sobre nós</span>
                                <h2 class=""mb-4"">Bem vindo ao RestauranteEtec</h2>
                            </div>
                        </div>
                        <div class=""pl-lg-3 ml-md-5"">
                            <p>On her way she met a copy. The copy warned the Little Blind Text, that where it came from it would have been rewritten a thousand times and everything that was left from its origin would be the word ""and"" and the Little Blind Text should turn around and return to its own, safe country. A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.</p>
     ");
            WriteLiteral("                   </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n -->\r\n");
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
