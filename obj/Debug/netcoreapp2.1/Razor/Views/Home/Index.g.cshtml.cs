#pragma checksum "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80951116ce28a221e3b140cad4446bd2f0cee047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\_ViewImports.cshtml"
using Food_Delivery;

#line default
#line hidden
#line 2 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\_ViewImports.cshtml"
using Food_Delivery.Data.Models;

#line default
#line hidden
#line 3 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\_ViewImports.cshtml"
using Food_Delivery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80951116ce28a221e3b140cad4446bd2f0cee047", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2d55f5af2058651627916f60fbd5448dc7d893", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 608, true);
            WriteLiteral(@"<div class=""buners"">
    <div class=""smallbuners"">
        <div class=""smallbaner"">
            <img class =""smallbaner_img"" src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/fish.jpg"" />
        </div>
        <div class=""smallbaner"">
            <img class =""smallbaner_img"" src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/34.jpg"" />
        </div>
    </div>
    <div class=""bigbaners"">
        <div class=""bigbaner"">
            <img src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/07/cashoo.jpg"" />
        </div>
    </div>
");
            EndContext();
            BeginContext(882, 231, true);
            WriteLiteral("    <div class=\"combo\">\r\n        <div class=\"baner\">\r\n            <img class =\"img_baner\" src=\"https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/1245tgv.jpg\" />\r\n        </div>\r\n        <div class=\"sale_products\">\r\n");
            EndContext();
#line 31 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
              
                foreach (Product product in Model.SaleProducts)
                {
                    if (product.Name == "Комбо 1" || product.Name == "Комбо 2")
                    {

#line default
#line hidden
            BeginContext(1317, 59, true);
            WriteLiteral("                        <div>\r\n                            ");
            EndContext();
            BeginContext(1377, 47, false);
#line 37 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("AllProducts", product));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 35, true);
            WriteLiteral(";\r\n                        </div>\r\n");
            EndContext();
#line 39 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(1516, 265, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""cheesroles"">
        <div class=""baner"">
            <img class =""img_baner"" src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/filadelf.jpg"" />
        </div>
        <div class=""sale_products"">
");
            EndContext();
#line 49 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
              
                foreach (Product product in Model.SaleProducts)
                {
                    if (product.Name == "Рол Філадельфія Крабс" || product.Name == "Рол Філадельфія Унагі")
                    {

#line default
#line hidden
            BeginContext(2013, 59, true);
            WriteLiteral("                        <div>\r\n                            ");
            EndContext();
            BeginContext(2073, 47, false);
#line 55 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("AllProducts", product));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 35, true);
            WriteLiteral(";\r\n                        </div>\r\n");
            EndContext();
#line 57 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(2212, 270, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""tobigcompany"">
        <div class=""baner"">
            <img class =""img_baner"" src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/Big-company.jpg"" />
        </div>
        <div class=""sale_products"">
");
            EndContext();
#line 67 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
              
                foreach (Product product in Model.SaleProducts)
                {
                    if (product.Name == "Асорті 9 смаків" || product.Name == "Асорті МЕГА")
                    {

#line default
#line hidden
            BeginContext(2698, 59, true);
            WriteLiteral("                        <div>\r\n                            ");
            EndContext();
            BeginContext(2758, 47, false);
#line 73 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("AllProducts", product));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 35, true);
            WriteLiteral(";\r\n                        </div>\r\n");
            EndContext();
#line 75 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(2897, 263, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""spicypizza"">
        <div class=""baner"">
            <img class =""img_baner"" src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/hoters.jpg"" />
        </div>
        <div class=""sale_products"">
");
            EndContext();
#line 85 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
              
                foreach (Product product in Model.SaleProducts)
                {
                    if (product.Name == "Діабло" || product.Name == "Мексиканська")
                    {

#line default
#line hidden
            BeginContext(3368, 59, true);
            WriteLiteral("                        <div>\r\n                            ");
            EndContext();
            BeginContext(3428, 47, false);
#line 91 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("AllProducts", product));

#line default
#line hidden
            EndContext();
            BeginContext(3475, 35, true);
            WriteLiteral(";\r\n                        </div>\r\n");
            EndContext();
#line 93 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(3567, 280, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""vega"">
        <div class=""baner"">
            <img class =""img_baner"" src=""https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2016/09/06-HomePage-FullWidth-Sidebar.jpg"" />
        </div>
        <div class=""sale_products"">
");
            EndContext();
#line 103 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
              
                foreach (Product product in Model.SaleProducts)
                {
                    if (product.Name == "Асорті Вега" || product.Name == "Вегетеріанська")
                    {

#line default
#line hidden
            BeginContext(4062, 59, true);
            WriteLiteral("                        <div>\r\n                            ");
            EndContext();
            BeginContext(4122, 47, false);
#line 109 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("AllProducts", product));

#line default
#line hidden
            EndContext();
            BeginContext(4169, 35, true);
            WriteLiteral(";\r\n                        </div>\r\n");
            EndContext();
#line 111 "C:\Users\sshevchuckaa\Desktop\Food_Delivery\Food_Delivery\Food_Delivery\Food_Delivery\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(4261, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
