#pragma checksum "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5987c6ae70de484d6ea9070aede3340187f6cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_Delete), @"mvc.1.0.view", @"/Views/Mahasiswa/Delete.cshtml")]
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
#line 1 "D:\workshop\WorkshopASP\Views\_ViewImports.cshtml"
using WorkshopASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workshop\WorkshopASP\Views\_ViewImports.cshtml"
using WorkshopASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5987c6ae70de484d6ea9070aede3340187f6cd", @"/Views/Mahasiswa/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c6461fb8e20312da949cd890efb11bcd14d663", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkshopASP.Models.Mahasiswa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 7 "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h2>Delete Mahasiswa</h2>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a5987c6ae70de484d6ea9070aede3340187f6cd4116", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"Nim\"");
                BeginWriteAttribute("value", " value=\"", 244, "\"", 262, 1);
#nullable restore
#line 11 "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 252, Model.Nim, 252, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label for=\"Nim\">Nim :</label>\r\n                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " \r\n                    value=\"", 409, "\"", 449, 1);
#nullable restore
#line 15 "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 439, Model.Nim, 439, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\" name=\"Nim\" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Nama\">Nama :</label>\r\n                <input type=\"text\" class=\"form-control\" \r\n                name=\"Nama\" readonly=\"readonly\"");
                BeginWriteAttribute("value", " value=\"", 699, "\"", 718, 1);
#nullable restore
#line 20 "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 707, Model.Nama, 707, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n             <div class=\"form-group\">\r\n                <label for=\"IPK\">IPK :</label>\r\n                <input type=\"text\" class=\"form-control\" \r\n                name=\"IPK\" readonly=\"readonly\"");
                BeginWriteAttribute("value", " value=\"", 935, "\"", 953, 1);
#nullable restore
#line 25 "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 943, Model.IPK, 943, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n             <div class=\"form-group\">\r\n                <label for=\"Email\">Email :</label>\r\n                <input type=\"text\" class=\"form-control\" \r\n                name=\"Email\" readonly=\"readonly\"");
                BeginWriteAttribute("value", " value=\"", 1176, "\"", 1196, 1);
#nullable restore
#line 30 "D:\workshop\WorkshopASP\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 1184, Model.Email, 1184, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <button class=\"btn btn-danger\" name=\"action\">Delete</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkshopASP.Models.Mahasiswa> Html { get; private set; }
    }
}
#pragma warning restore 1591