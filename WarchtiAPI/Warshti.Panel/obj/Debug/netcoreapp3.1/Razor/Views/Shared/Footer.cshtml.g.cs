#pragma checksum "E:\Professional Projeccts\WarchtiAPI\WarchtiAPI\Warshti.Panel\Views\Shared\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b8ec8c2b52e656ffd1cb0e2c7bb8c7b6e9de90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Footer), @"mvc.1.0.view", @"/Views/Shared/Footer.cshtml")]
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
#line 4 "E:\Professional Projeccts\WarchtiAPI\WarchtiAPI\Warshti.Panel\Views\_ViewImports.cshtml"
using Warshti.Panel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b8ec8c2b52e656ffd1cb0e2c7bb8c7b6e9de90", @"/Views/Shared/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73f1a77e33a6cc2cc22236925c0f1f6e9cdba64", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "E:\Professional Projeccts\WarchtiAPI\WarchtiAPI\Warshti.Panel\Views\Shared\Footer.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""footer bg-white py-4 d-flex flex-lg-column"" id=""kt_footer"">

    <!--begin::Container-->
    <div class=""container-fluid d-flex flex-column flex-md-row align-items-center justify-content-between"">

        <!--begin::Copyright-->
        <div class=""text-dark order-2 order-md-1"">
            <span class=""text-muted font-weight-bold mr-2"">");
#nullable restore
#line 13 "E:\Professional Projeccts\WarchtiAPI\WarchtiAPI\Warshti.Panel\Views\Shared\Footer.cshtml"
                                                      Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ©</span>
            <a href=""#"" target=""_blank"" class=""text-dark-75 text-hover-primary"">Deep Blue System Solutions</a>
        </div>
        <!--end::Copyright-->

        <!--begin::Nav-->
        <div class=""nav nav-dark"">
            <a href=""#"" target=""_blank"" class=""nav-link pl-0 pr-5"">About</a>
            <a href=""#"" target=""_blank"" class=""nav-link pl-0 pr-0"">Contact</a>
        </div>
        <!--end::Nav-->

    </div>
    <!--end::Container-->

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591