#pragma checksum "D:\visual studio\programms\todolist\todolist\Views\auth\signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29d0520b77873a4ac38d59ef2a46a6796eb93dbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_auth_signup), @"mvc.1.0.view", @"/Views/auth/signup.cshtml")]
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
#line 1 "D:\visual studio\programms\todolist\todolist\Views\_ViewImports.cshtml"
using todolist;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\visual studio\programms\todolist\todolist\Views\_ViewImports.cshtml"
using todolist.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29d0520b77873a4ac38d59ef2a46a6796eb93dbf", @"/Views/auth/signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea6fe19a32212eda3686924054d1465ed559315", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_auth_signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/6300959.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail rounded float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\visual studio\programms\todolist\todolist\Views\auth\signup.cshtml"
  
        ViewData["Title"] = "Signup Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"container my-4\">\r\n     <p>\r\n    Hello, Welcome to the signup page\r\n</p>\r\n\r\n     <div class=\"row\">\r\n         <div class = \"col-6\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29d0520b77873a4ac38d59ef2a46a6796eb93dbf5472", async() => {
                WriteLiteral("\r\n                        <div class=\"form-row\">\r\n                            <div class=\"col-6\">\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 377, "\"", 383, 0);
                EndWriteAttribute();
                WriteLiteral(">First name</label>\r\n                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 472, "\"", 479, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 480, "\"", 485, 0);
                EndWriteAttribute();
                WriteLiteral(@"  aria-describedby=""emailHelp"">
                            <small id=""emailHelp"" class=""form-text text-muted""></small>
                        </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""col-6"">  
                               
                            <label");
                BeginWriteAttribute("for", " for=\"", 838, "\"", 844, 0);
                EndWriteAttribute();
                WriteLiteral(">Last name</label>\r\n                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 932, "\"", 939, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 940, "\"", 945, 0);
                EndWriteAttribute();
                WriteLiteral(@"  aria-describedby=""emailHelp"">
                            <small id=""emailHelp"" class=""form-text text-muted""></small>
                     
                            </div>
                        </div>
                          <div class=""form-row"">
                            <div class=""col-6"">  
                                   <label");
                BeginWriteAttribute("for", " for=\"", 1301, "\"", 1307, 0);
                EndWriteAttribute();
                WriteLiteral(">Username</label>\r\n                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1394, "\"", 1401, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1402, "\"", 1407, 0);
                EndWriteAttribute();
                WriteLiteral(@"  aria-describedby=""emailHelp"">
                            <small id=""emailHelp"" class=""form-text text-muted""></small>
                       
                            </div>
                        </div>
                          <div class=""form-row"">
                            <div class=""col-6"">  
                                   <label");
                BeginWriteAttribute("for", " for=\"", 1765, "\"", 1771, 0);
                EndWriteAttribute();
                WriteLiteral(">Email</label>\r\n                            <input type=\"email\" class=\"form-control col-xs-4\"");
                BeginWriteAttribute("name", " name=\"", 1865, "\"", 1872, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1873, "\"", 1878, 0);
                EndWriteAttribute();
                WriteLiteral(@"  aria-describedby=""emailHelp"">
                            <small id=""emailHelp"" class=""form-text text-muted""></small>
                        
                            </div>
                        </div>
                          <div class=""form-row"">
                            <div class=""col-6"">  
                                 <label");
                BeginWriteAttribute("for", " for=\"", 2235, "\"", 2241, 0);
                EndWriteAttribute();
                WriteLiteral(">Password</label>\r\n                            <input type=\"password\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 2332, "\"", 2339, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2340, "\"", 2345, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                       
                            </div>
                        </div>
                          <div class=""form-row"">
                            <div class=""col-6"">  

                            </div>
                        </div>

                    
                        <div class=""form-group form-check"">
                            <input type=""checkbox"" class=""form-check-input""");
                BeginWriteAttribute("id", " id=\"", 2773, "\"", 2778, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 2841, "\"", 2847, 0);
                EndWriteAttribute();
                WriteLiteral(">Check me out</label>\r\n                        </div>\r\n                        <button name=\"submit\" type=\"submit\" class=\"btn btn-primary\">Login</button>\r\n                   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n         </div>\r\n\r\n        <div class = \"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29d0520b77873a4ac38d59ef2a46a6796eb93dbf12184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n     </div>\r\n</div>\r\n                ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
