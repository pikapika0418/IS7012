#pragma checksum "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1ed012233790cac6766089989e6ef2ffe73d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject.Pages.Pages_UserBookProfile), @"mvc.1.0.razor-page", @"/Pages/UserBookProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1ed012233790cac6766089989e6ef2ffe73d83", @"/Pages/UserBookProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52dbc840adbca4b7145a128150fec29662d4a16e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserBookProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SearchUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 50px;display:block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
  
    ViewData["Title"] = "UserBookProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>User Profile</h1>\r\n\r\n<script>\r\n    function hideUserSearch() {\r\n        document.getElementById(\'searchUser\').style.display = \"none\";\r\n    }\r\n\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ed012233790cac6766089989e6ef2ffe73d835544", async() => {
                WriteLiteral(@"
    <table width=""50%"">
        <tbody>
            <tr>
                <td>
                    <div class=""form-group"">
                        <label class=""control-label"" for=""search"">User Name</label>
                        <input type=""text"" class=""form-control"" name=""SearchUser"" id=""searchUser"" />
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Search User"" class=""btn btn-default""/>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1ed012233790cac6766089989e6ef2ffe73d837830", async() => {
                WriteLiteral("\r\n    <div style=hideUserSearch()>\r\n");
#nullable restore
#line 34 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.SearchUser))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
             if (Model.UserProfileName != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h4>Hi ");
#nullable restore
#line 38 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                  Write(Model.UserProfileName.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 39 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
         if (Model.UserBooks != null && Model.UserBooks.Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table>
                <thead>
                    <tr style=""padding:10px;"">
                        <th>Book</th>
                        <th>Check-Out Date</th>
                        <th>Check-In Date</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 53 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                     if (Model.UserBooks != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                         foreach (var userbooks in Model.UserBooks)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                               Write(userbooks.BookId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                               Write(userbooks.CheckoutDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 60 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                                 if (!userbooks.CheckInDate.Equals(null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 62 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                                   Write(userbooks.CheckInDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td></td>\r\n");
#nullable restore
#line 64 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>To be Returned</td>\r\n                                    <td><button action=\"submit\" id=\"submit\" type=\"submit\">Check In</button></td>\r\n");
#nullable restore
#line 69 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>No entries available</p>\r\n");
#nullable restore
#line 76 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 79 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>No entries available</p>\r\n");
#nullable restore
#line 84 "C:\Users\Sunny Vishwa Ramesh\Desktop\Anjana .NET\IS7012\FinalProject\FinalProject\Pages\UserBookProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.Pages.UserBookProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject.Pages.UserBookProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject.Pages.UserBookProfileModel>)PageContext?.ViewData;
        public FinalProject.Pages.UserBookProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591