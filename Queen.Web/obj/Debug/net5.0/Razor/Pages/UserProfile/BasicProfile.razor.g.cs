#pragma checksum "C:\Projects\Net Core\Queen\Queen.Web\Pages\UserProfile\BasicProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61cf9b7952aee683a727b7facb9bc4632a446b20"
// <auto-generated/>
#pragma warning disable 1591
namespace Queen.Web.Pages.UserProfile
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared.Entity.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared.Entity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Projects\Net Core\Queen\Queen.Web\_Imports.razor"
using Queen.Shared.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/basicprofile")]
    public partial class BasicProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "<h2>Queen\'s Member Profile</h2>\r\n     ");
            __builder.AddMarkupContent(4, "<p>Personal Details:</p>            \r\n     ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "<thead><tr><th>Full Name</th>\r\n           <th>Gender</th>\r\n           <th>Date of Birth</th>\r\n           <th>Mobile No.</th>\r\n           <th>Email</th></tr></thead>\r\n       ");
            __builder.OpenElement(8, "tbody");
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
#nullable restore
#line 20 "C:\Projects\Net Core\Queen\Queen.Web\Pages\UserProfile\BasicProfile.razor"
              foreach (var fullname in UserProfileState.FullNameList)
             {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\Projects\Net Core\Queen\Queen.Web\Pages\UserProfile\BasicProfile.razor"
                     fullname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Projects\Net Core\Queen\Queen.Web\Pages\UserProfile\BasicProfile.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n         ");
            __builder.AddMarkupContent(14, "<tr><td>Mary</td>\r\n           <td>Moe</td>\r\n           <td>mary@example.com</td></tr>\r\n         ");
            __builder.AddMarkupContent(15, "<tr><td>July</td>\r\n           <td>Dooley</td>\r\n           <td>july@example.com</td></tr>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserProfileState UserProfileState { get; set; }
    }
}
#pragma warning restore 1591
