#pragma checksum "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e731ed7876732252aab37ab5ccfef195e300a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_LeaguePage), @"mvc.1.0.view", @"/Views/Event/LeaguePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e731ed7876732252aab37ab5ccfef195e300a15", @"/Views/Event/LeaguePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57511120aa0574db89f5162b4026b2ae467a1797", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_LeaguePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueMember>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JoinLeague", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<h3 class=""text-center mt-5 display-4"">League Page</h3>
<hr />

<div class=""container"">
<div class=""row mt-5"">
<div class=""col-6"">
<img src=""/img/bowling-alley-c.jpg"" class=""d-block w-100 mr-5"" alt=""image3"">
</div>
    <div class=""col-6"">
  <div class=""form-group"">
");
#nullable restore
#line 13 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
       foreach(League league in ViewBag.AllLeagues) 
      {

        bool alreadyJoined = league.LeagueMembers.Any(join => Context.Session.GetInt32("UserId") == join.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 17 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
       Write(league.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
      Write(league.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Start Date: ");
#nullable restore
#line 19 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
                  Write(league.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e731ed7876732252aab37ab5ccfef195e300a156164", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
           if (!alreadyJoined)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <button class=\"btn btn-outline-success m-3\">Join League</button> \r\n");
#nullable restore
#line 24 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
          } 
          else {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button class=\"btn btn-outline-danger btn-sm\">Leave League</button>\r\n");
#nullable restore
#line 27 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leagueId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
                                                                     WriteLiteral(league.LeagueId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["leagueId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leagueId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["leagueId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 29 "C:\Users\james\OneDrive\Desktop\code_projects\twelve_pins\Views\Event\LeaguePage.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueMember> Html { get; private set; }
    }
}
#pragma warning restore 1591
