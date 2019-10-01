#pragma checksum "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e288f0bfe023a4b88984a6004b4c53fc86f27fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreCrud.Pages.Pages_CountryProfile), @"mvc.1.0.razor-page", @"/Pages/CountryProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CountryProfile.cshtml", typeof(CoreCrud.Pages.Pages_CountryProfile), null)]
namespace CoreCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/_ViewImports.cshtml"
using CoreCrud;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e288f0bfe023a4b88984a6004b4c53fc86f27fb", @"/Pages/CountryProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9585b25c5b6000883b7139a813059c03b8f3107", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CountryProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
  
    ViewData["Title"] = "AthletesInTheCountry";

#line default
#line hidden
            BeginContext(101, 273, true);
            WriteLiteral(@"
<h1>Country Profile</h1>

<table class=""table ttable-bordered table-stripped"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Rank</th>
            <th>Percentage Won</th>
            <th>Grand Slam?</th>
        </tr>
    </thead>
    <tbody>
        ");
            EndContext();
            BeginContext(375, 5, false);
#line 19 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(380, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 20 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
         foreach (var country in Model.Countries)
        {
            foreach (var athlete in Model.Athletes)
            {
                if (athlete.CountryId == country.Id)
                {

#line default
#line hidden
            BeginContext(578, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(624, 12, false);
#line 27 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
                   Write(athlete.Name);

#line default
#line hidden
            EndContext();
            BeginContext(636, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(667, 12, false);
#line 28 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
                   Write(athlete.Rank);

#line default
#line hidden
            EndContext();
            BeginContext(679, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(710, 26, false);
#line 29 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
                   Write(athlete.GamesWonPercentage);

#line default
#line hidden
            EndContext();
            BeginContext(736, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(767, 21, false);
#line 30 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
                   Write(athlete.AthleteAgeBar);

#line default
#line hidden
            EndContext();
            BeginContext(788, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 32 "/Users/anjana/Dotnet/IS7012/CoreCrud/Pages/CountryProfile.cshtml"
                }
            }
        }

#line default
#line hidden
            BeginContext(858, 24, true);
            WriteLiteral("\n    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreCrud.Pages.CountryProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreCrud.Pages.CountryProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreCrud.Pages.CountryProfileModel>)PageContext?.ViewData;
        public CoreCrud.Pages.CountryProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591