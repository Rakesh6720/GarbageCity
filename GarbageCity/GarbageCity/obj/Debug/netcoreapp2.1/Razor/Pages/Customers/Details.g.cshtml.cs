#pragma checksum "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b8e4f2da53b8d7eaa9ce98bda1a0bd0025d875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GarbageCity.Pages.Customers.Pages_Customers_Details), @"mvc.1.0.razor-page", @"/Pages/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Customers/Details.cshtml", typeof(GarbageCity.Pages.Customers.Pages_Customers_Details), null)]
namespace GarbageCity.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\_ViewImports.cshtml"
using GarbageCity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b8e4f2da53b8d7eaa9ce98bda1a0bd0025d875", @"/Pages/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb82facc1959d0aaf5b75938f803be54ad9075f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customers_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 114, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Customer</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(210, 53, false);
#line 15 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(263, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(304, 49, false);
#line 18 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(353, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(394, 57, false);
#line 21 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(451, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(492, 53, false);
#line 24 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(545, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(586, 52, false);
#line 27 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Address));

#line default
#line hidden
            EndContext();
            BeginContext(638, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(679, 48, false);
#line 30 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Address));

#line default
#line hidden
            EndContext();
            BeginContext(727, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(768, 52, false);
#line 33 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(820, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(861, 48, false);
#line 36 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(909, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(950, 54, false);
#line 39 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.PickupDay));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1045, 50, false);
#line 42 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.PickupDay));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1137, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bdcbe1b0b04e66be0a550d935debbd", async() => {
                BeginContext(1200, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\rbaru\OneDrive\Desktop\Visual_Studio_Projects\GarbageCity_MvcCore\GarbageCity\GarbageCity\Pages\Customers\Details.cshtml"
                           WriteLiteral(Model.Customer.CustomerID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1215, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de0326e4b0b4a4abcdc48b9500c8748", async() => {
                BeginContext(1237, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1253, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GarbageCity.Pages.Customers.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GarbageCity.Pages.Customers.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GarbageCity.Pages.Customers.DetailsModel>)PageContext?.ViewData;
        public GarbageCity.Pages.Customers.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
