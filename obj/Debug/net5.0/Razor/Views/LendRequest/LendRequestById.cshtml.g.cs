#pragma checksum "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e803b3c55922d427df2a04182b40a4ce037383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LendRequest_LendRequestById), @"mvc.1.0.view", @"/Views/LendRequest/LendRequestById.cshtml")]
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
#line 1 "F:\edited project\varsha group\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using LibraryManagmentSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\edited project\varsha group\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e803b3c55922d427df2a04182b40a4ce037383", @"/Views/LendRequest/LendRequestById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6355110b3b3130b8c1d3bd28097ff5dc2d12590", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LendRequest_LendRequestById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryManagmentSystem.Models.LendRequest>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/imgs/books.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
  
	Layout="_userLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""container"">
  <div class=""row justify-content-md-center""> 
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-body"">
                  <div class=""row"">
                     <div class=""col"">
                        <center>
                           <h4>Your all records</h4>
                        </center>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <center>
                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4e803b3c55922d427df2a04182b40a4ce0373834749", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </center>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <hr>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <table class=""table table-striped table-bordered"" >
                            <thead>

                                <tr>
                                    <td>Lend Id </td>
                                    <td>User Name </td>
                                    <td>Book Name</td>
                                    <td>Fine Amount</td>
                                    <td>Status</td>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 44 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                 foreach (var request in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 47 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.LendId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 48 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.AccountsInfo.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 49 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.BooksInfo.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td> ");
#nullable restore
#line 50 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                        Write(request.FineAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 51 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.LendStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 53 "F:\edited project\varsha group\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                        </table>\n                     </div>\n                  </div>\n        </div>\n    </div>\n</div>\n</div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryManagmentSystem.Models.LendRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591