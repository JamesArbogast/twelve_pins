#pragma checksum "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "652e5ca50852797c4d7987eb02ab7d097cfd0137"
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"652e5ca50852797c4d7987eb02ab7d097cfd0137", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb86fbdb37595224ded6f8eba702c6fc131d03d", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a02ed57f7c7a8ef3c657a53c83cd6b3e2fd134", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57511120aa0574db89f5162b4026b2ae467a1797", @"/Views/_ViewImports.cshtml")]
>>>>>>> ae869cb3e9511b0c849807e8bdeac3b2a5afea81
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"text-center\">\n    <a href=\"/products\"><p>Products</p></a>\n    <h1 class=\"display-4\">");
#nullable restore
#line 5 "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml"
                     Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml"
                                      Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n      </div>\n      <div>Reservations:</div>\n      <ul>\n");
#nullable restore
#line 9 "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml"
         foreach(ReservedLane resLane in @Model.Lanes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <li>");
#nullable restore
#line 11 "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml"
         Write(resLane.Lane.LaneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 12 "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </ul>\n      <div>Leagues:</div>\n      <ul>\n");
#nullable restore
#line 16 "/Users/javanogden/Desktop/pins/twelve_pins/Views/Home/Profile.cshtml"
         foreach(LeagueMember league in @Model.Leagues)
        {
<<<<<<< HEAD
          
=======

#line default
#line hidden
#nullable disable
            WriteLiteral("          <li>");
#nullable restore
#line 18 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
         Write(league.League.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Home\Profile.cshtml"
>>>>>>> ae869cb3e9511b0c849807e8bdeac3b2a5afea81
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </ul>\n    </div>\n    <div class=\"card-body\">\n</div>");
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
