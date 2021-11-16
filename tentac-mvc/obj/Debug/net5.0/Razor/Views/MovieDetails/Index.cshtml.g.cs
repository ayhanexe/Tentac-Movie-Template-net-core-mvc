#pragma checksum "C:\Users\aykhansab\source\repos\tentac-mvc\tentac-mvc\Views\MovieDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe42474af5ace757d650ad7a07840bc9d19e277e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieDetails_Index), @"mvc.1.0.view", @"/Views/MovieDetails/Index.cshtml")]
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
#line 1 "C:\Users\aykhansab\source\repos\tentac-mvc\tentac-mvc\Views\_ViewImports.cshtml"
using tentac_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aykhansab\source\repos\tentac-mvc\tentac-mvc\Views\_ViewImports.cshtml"
using tentac_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe42474af5ace757d650ad7a07840bc9d19e277e", @"/Views/MovieDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233576b5dc1b30382ee4cb098ca902831e0e1e8b", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 28, "\"", 74, 1);
#nullable restore
#line 2 "C:\Users\aykhansab\source\repos\tentac-mvc\tentac-mvc\Views\MovieDetails\Index.cshtml"
WriteAttributeValue("", 35, Url.Content("~/css/movie-details.css"), 35, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
            }
            );
            WriteLiteral("\r\n<main id=\"main\" class=\"md:p-20 p-5\">\r\n    <section class=\"info flex md:flex-nowrap flex-wrap gap-5\">\r\n        <div class=\"image\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 249, "\"", 255, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-poster object-cover object-center\"");
            BeginWriteAttribute("alt", " alt=\"", 304, "\"", 310, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""favorite-container"">
                <span class=""bi bi-heart-fill favorite-icon""></span>
            </div>
        </div>
        <div class=""text"">
            <h1 class=""movie-name text-white text-4xl font-semibold mb-5""></h1>
            <div class=""properties flex md:gap-5 gap-2 mb-4"">
                <div class=""property-item d-flex flex-col"">
                    <div class=""property-key font-semibold text-md text-center"">Place</div>
                    <div class=""property-value text-center text-xs"">US</div>
                </div>
                <div class=""property-item d-flex flex-col"">
                    <div class=""property-key font-semibold text-md text-center"">Time</div>
                    <div class=""property-value text-center text-xs"">45min</div>
                </div>
                <div class=""property-item d-flex flex-col"">
                    <div class=""property-key font-semibold text-md text-center"">Year</div>
                    <div class");
            WriteLiteral(@"=""property-value text-center text-xs"">2011</div>
                </div>
                <div class=""property-item d-flex flex-col"">
                    <div class=""property-key font-semibold text-md text-center"">Language</div>
                    <div class=""property-value text-center text-xs"">English</div>
                </div>
            </div>
            <p class=""movie-text"">
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident ipsum eligendi
                atque nobis neque
                exercitationem nesciunt deserunt molestiae, totam error nisi, vero aliquid qui molestias, deleniti
                ullam debitis harum eaque! Lorem ipsum dolor sit amet consectetur adipisicing elit. Atque impedit ad
                aut blanditiis. Deleniti sunt aliquid eum fugit. Delectus reprehenderit veniam modi voluptas.
                Explicabo laboriosam labore dolores, rem eveniet inventore. Lorem ipsum dolor sit amet consectetur
                adipisicing elit. L");
            WriteLiteral(@"abore unde officia nihil mollitia? Ipsa repellat suscipit magnam consectetur!
                Quos hic nam exercitationem rerum reiciendis nostrum quis. Minima magni nesciunt provident. lorem
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Mollitia magnam quisquam eius eaque,
                impedit sed modi praesentium quam rem nam earum maiores consequatur vel, eos pariatur aliquid magni.
                Obcaecati, tempora. Lorem, ipsum dolor sit amet consectetur adipisicing elit. Minus sed veritatis
                optio beatae ratione voluptates praesentium repellendus. Nesciunt odit cum ipsam, adipisci vitae
                enim alias, dolores, unde sit amet in. lorem
            </p>
        </div>
    </section>
    <section class=""video-area my-20"">
        <div class=""title text-4xl text-white font-semibold mb-5""></div>
        <iframe style=""width:70%;"" class=""trailer-frame""");
            BeginWriteAttribute("src", " src=\"", 3294, "\"", 3300, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""YouTube video player"" frameborder=""0""
                allowfullscreen></iframe>
    </section>
    <section class=""comments mt-20"">
        <h1 class=""text-4xl font-bold text-white mb-5"">Comments</h1>
        <div class=""message-area flex py-3 gap-5"">
            <div class=""profile"">
                <img src=""https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500""
                     class=""object-cover object-center"">
            </div>
            <textarea class=""message-input"" cols=""30"" rows=""10"" placeholder=""Message""></textarea>
        </div>
        <div class=""comments-area pt-20"">
            <div class=""comment-item flex"">
                <div class=""profile"">
                    <img src=""https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500""
                         class=""object-cover object-center"">
                </div>
                <div class=""comment-container"">
  ");
            WriteLiteral(@"                  <p class=""text-sm"">
                        Lorem ipsum dolor, sit amet consectetur adipisicing elit. Aperiam veritatis
                        aut nesciunt
                        repellendus omnis. Inventore quam veniam, sequi tenetur eveniet, commodi harum expedita in
                        magni numquam, eum cumque perferendis iusto.
                    </p>
                    <div class=""actions-container"">
                        <span class=""dislike hand-icon bi bi-hand-thumbs-down-fill""></span>
                        <span class=""like-count"">21</span>
                        <span class=""like hand-icon bi bi-hand-thumbs-up-fill""></span>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5155, "\"", 5198, 1);
#nullable restore
#line 89 "C:\Users\aykhansab\source\repos\tentac-mvc\tentac-mvc\Views\MovieDetails\Index.cshtml"
WriteAttributeValue("", 5161, Url.Content("~/js/movie-details.js"), 5161, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"module\"></script>\r\n");
            }
            );
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
