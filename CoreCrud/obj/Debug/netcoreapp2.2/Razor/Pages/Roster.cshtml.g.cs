#pragma checksum "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6836a799224d851c1db63e2b22d46fcb941a6a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreCrud.Pages.Pages_Roster), @"mvc.1.0.razor-page", @"/Pages/Roster.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Roster.cshtml", typeof(CoreCrud.Pages.Pages_Roster), null)]
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
#line 1 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\_ViewImports.cshtml"
using CoreCrud;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6836a799224d851c1db63e2b22d46fcb941a6a68", @"/Pages/Roster.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70be34fe23130313fbdf16acefe8f2e4f5da9be3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Roster : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
  
    ViewData["Title"] = "Roster";

#line default
#line hidden
            BeginContext(69, 586, true);
            WriteLiteral(@"    <center>
        <h1>Roster</h1>
        <div>
            <img width=""800"" src=""https://rfclipart.com/image/big/c7-16-f4/collection-of-grunge-posters-with-tennis-players-Download-Royalty-free-Vector-File-EPS-108721.jpg"" alt=""TennisPlayers"" />
        </div>
    </center>
<br />
<hr/>
<table class=""table ttable-bordered table-striped"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Rank</th>
            <th>Percentage Won</th>
            <th>Won Grand Slam</th>
            <th>Country</th>
        </tr>
    </thead>
    <tbody>
        ");
            EndContext();
            BeginContext(656, 5, false);
#line 25 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
         foreach (var athlete in Model.Athletes)
        {

#line default
#line hidden
            BeginContext(724, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(771, 12, false);
#line 29 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
                   Write(athlete.Name);

#line default
#line hidden
            EndContext();
            BeginContext(783, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(815, 12, false);
#line 30 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
                   Write(athlete.Rank);

#line default
#line hidden
            EndContext();
            BeginContext(827, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(859, 26, false);
#line 31 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
                   Write(athlete.GamesWonPercentage);

#line default
#line hidden
            EndContext();
            BeginContext(885, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(917, 21, false);
#line 32 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
                   Write(athlete.AthleteAgeBar);

#line default
#line hidden
            EndContext();
            BeginContext(938, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(970, 20, false);
#line 33 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
                   Write(athlete.Country.Name);

#line default
#line hidden
            EndContext();
            BeginContext(990, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\CoreCrud\Pages\Roster.cshtml"
        }

#line default
#line hidden
            BeginContext(1031, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RosterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RosterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RosterModel>)PageContext?.ViewData;
        public RosterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591