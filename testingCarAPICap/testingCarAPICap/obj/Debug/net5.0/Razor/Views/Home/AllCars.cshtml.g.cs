#pragma checksum "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3068b8fed3f9bbb563de01187501fd53d2418f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCars), @"mvc.1.0.view", @"/Views/Home/AllCars.cshtml")]
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
#line 1 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\_ViewImports.cshtml"
using testingCarAPICap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\_ViewImports.cshtml"
using testingCarAPICap.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3068b8fed3f9bbb563de01187501fd53d2418f", @"/Views/Home/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab7bebc522cbbcd5900cebc9b0bc4be6e305163", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Car List: </h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml"
 foreach (Car c in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"border: solid 2px black\">\r\n        <p>Make: ");
#nullable restore
#line 8 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml"
            Write(c.make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Model: ");
#nullable restore
#line 9 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml"
             Write(c.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Year: ");
#nullable restore
#line 10 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml"
            Write(c.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Color: ");
#nullable restore
#line 11 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml"
             Write(c.color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Josh\source\repos\testingCarAPICap\testingCarAPICap\Views\Home\AllCars.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591