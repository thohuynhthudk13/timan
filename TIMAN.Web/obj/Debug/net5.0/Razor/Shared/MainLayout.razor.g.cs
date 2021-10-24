#pragma checksum "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06f52b603fb73718885623500249fa8807cddf5"
// <auto-generated/>
#pragma warning disable 1591
namespace TIMAN.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using TIMAN.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\_Imports.razor"
using TIMAN.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\Shared\MainLayout.razor"
using TIMAN.Model;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "b-mwqxqo6v4i");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "header-top");
            __builder.AddAttribute(4, "b-mwqxqo6v4i");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddAttribute(7, "b-mwqxqo6v4i");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "header-middle-content");
            __builder.AddAttribute(10, "b-mwqxqo6v4i");
            __builder.AddMarkupContent(11, @"<div class=""header-middle-left"" b-mwqxqo6v4i><a id=""logo"" class=""header-logo"" href=""/"" rel=""js-header-logo"" b-mwqxqo6v4i><img class=""header-logo-pc loading"" src=""	https://timan.vn/Thumb.ashx?s=500&file=/UploadImages/timan-logo.png"" alt=""Timan - Kênh Mua Sắm Giày Trực Tuyến Hàng Đầu Việt Nam"" width=""150px"" height=""24px"" data-was-processed=""true"" b-mwqxqo6v4i></a></div>
                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "header-middle-center");
            __builder.AddAttribute(14, "b-mwqxqo6v4i");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "header-search-content");
            __builder.AddAttribute(17, "rel", "js-header-search-content");
            __builder.AddAttribute(18, "b-mwqxqo6v4i");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "header-search-box");
            __builder.AddAttribute(21, "b-mwqxqo6v4i");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "name", "txtSearch");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "id", "txtSearch");
            __builder.AddAttribute(26, "class", "search has-error header-search-input");
            __builder.AddAttribute(27, "autocomplete", "off");
            __builder.AddAttribute(28, "placeholder", "Tìm kiếm trên Timan...");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\Shared\MainLayout.razor"
                                                 TuKhoaTimKiem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TuKhoaTimKiem = __value, TuKhoaTimKiem));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(31, "b-mwqxqo6v4i");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            <span class=\"not-visible\" b-mwqxqo6v4i></span>\r\n                            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "header-search-button");
            __builder.AddAttribute(35, "id", "btnSearchText");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\Shared\MainLayout.razor"
                                               TimKiemSanPham

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "b-mwqxqo6v4i");
            __builder.AddMarkupContent(38, "<i class=\"fas fa-search\" b-mwqxqo6v4i></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.AddMarkupContent(40, @"<div class=""header-bottom"" b-mwqxqo6v4i><div class=""container"" b-mwqxqo6v4i><ul class=""main-menu"" b-mwqxqo6v4i><li class=""active"" b-mwqxqo6v4i><a href=""/"" b-mwqxqo6v4i><span b-mwqxqo6v4i>Trang chủ</span></a></li>
                <li b-mwqxqo6v4i><a href=""/giay-nam"" b-mwqxqo6v4i><span b-mwqxqo6v4i>Giày nam</span></a></li>
                <li b-mwqxqo6v4i><a href=""/giay-nu"" b-mwqxqo6v4i><span b-mwqxqo6v4i>Giày nữ</span></a></li>
                <li b-mwqxqo6v4i><a href=""/thoi-trang-nam"" b-mwqxqo6v4i><span b-mwqxqo6v4i>Thời trang nam</span></a></li>
                <li b-mwqxqo6v4i><a href=""/thoi-trang-nữ"" b-mwqxqo6v4i><span b-mwqxqo6v4i>Thời trang nữ</span></a></li>
                <li b-mwqxqo6v4i><a href=""/thoi-trang-be-yeu"" b-mwqxqo6v4i><span b-mwqxqo6v4i>Thời trang bé yêu</span></a></li></ul></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.AddContent(42, 
#nullable restore
#line 77 "D:\CODE\Blazor\TIMANWeb\TIMAN.Web\Shared\MainLayout.razor"
 Body

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
