#pragma checksum "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0400f1a89a0eb6bad850a5f832727bd7a38192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject.Pages.Pages_Ratings), @"mvc.1.0.razor-page", @"/Pages/Ratings.cshtml")]
namespace FinalProject.Pages
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
#line 1 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0400f1a89a0eb6bad850a5f832727bd7a38192", @"/Pages/Ratings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52dbc840adbca4b7145a128150fec29662d4a16e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ratings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml"
  
    ViewData["Title"] = "Ratings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center><h1>RATING FILTER</h1></center>\r\n<h2>\r\n    Following is the list of books categorizd by the ratings.\r\n    The most popular books hold a rating of 5 and the least popular books hold a rating of 2 or less.\r\n    Browse and Enjoy!!\r\n</h2>\r\n\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml"
 foreach (var usr in Model.Userbook)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n\r\n        <div class=\"Card-header\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml"
       Write(usr.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p>Book Name: ");
#nullable restore
#line 25 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml"
                     Write(usr.Book);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Book Author:");
#nullable restore
#line 26 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml"
                      Write(usr.Book);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 30 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\Ratings.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.Pages.RatingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject.Pages.RatingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject.Pages.RatingsModel>)PageContext?.ViewData;
        public FinalProject.Pages.RatingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591