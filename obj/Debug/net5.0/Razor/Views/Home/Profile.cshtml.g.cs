#pragma checksum "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93765b89ee3a3247939773935964729dc8dc4244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\_ViewImports.cshtml"
using twelve_pins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\_ViewImports.cshtml"
using twelve_pins.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93765b89ee3a3247939773935964729dc8dc4244", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57511120aa0574db89f5162b4026b2ae467a1797", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center d-flex-column m-4\" >\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 4 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                     Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                                      Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
      </div>
      <h3 class=""m-4"">Lane Reservations</h3>
      <table class=""m-4 px-3"" style=""border: 3px black solid; padding: 20px"">
        <thead class=""m-4"">
          <th style=""border: 3px black solid; padding: 20px"">Time</th>
          <th style=""border: 3px black solid; padding: 20px"">Lane</th>
        </thead>
");
#nullable restore
#line 12 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
         foreach(ReservedLane resLane in @Model.Lanes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td style=\"border: 3px black solid; padding: 20px\">");
#nullable restore
#line 14 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                                                        Write(resLane.ReserveDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td style=\"border: 3px black solid; padding: 20px\">");
#nullable restore
#line 15 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                                                        Write(resLane.ReservedLaneId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 16 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </table>\r\n      <h3 class=\"m-4\">Leagues</h3>\r\n      <table class=\"m-4 px-3\" style=\"border: 3px black solid; padding: 20px\">\r\n");
#nullable restore
#line 20 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
         foreach(LeagueMember league in @Model.Leagues)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td style=\"border: 3px black solid; padding: 20px\">");
#nullable restore
#line 22 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                                                        Write(league.League.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td style=\"border: 3px black solid; padding: 20px\">");
#nullable restore
#line 23 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                                                        Write(league.League.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td style=\"border: 3px black solid; padding: 20px\">");
#nullable restore
#line 24 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
                                                        Write(league.League.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </table>\r\n    </div>\r\n    <div class=\"card-body\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
