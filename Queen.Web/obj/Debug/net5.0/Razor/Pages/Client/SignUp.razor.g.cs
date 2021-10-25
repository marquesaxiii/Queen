#pragma checksum "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61bcc86cbe6f8bbc8d05367b4ea25674ea192974"
// <auto-generated/>
#pragma warning disable 1591
namespace Queen.Web.Pages.Client
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : ClientBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<div><h2>Sign Up to Queen</h2></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.OpenElement(4, "form");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "<label for=\"fullName\" class=\"form-label\">Full Name</label>\r\n          ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "fullName");
            __builder.AddAttribute(11, "required");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                                                                 Client.FullName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Client.FullName = __value, Client.FullName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "<label for=\"gender\" class=\"form-label\">Gender</label>\r\n          ");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "class", "form-select");
            __builder.AddAttribute(19, "id", "gender");
            __builder.AddAttribute(20, "required");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                                                   Client.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Client.Gender = __value, Client.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "selected");
            __builder.AddAttribute(25, "disabled");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 18 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                              Gender.NotSpecified

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, "NotSpecified");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 19 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                            Gender.Male

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", 
#nullable restore
#line 20 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                            Gender.Female

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddMarkupContent(38, "<label for=\"birthday\" class=\"form-label\">Birthday</label>\r\n          ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "date");
            __builder.AddAttribute(41, "class", "form-control is-invalid");
            __builder.AddAttribute(42, "id", "birthday");
            __builder.AddAttribute(43, "required");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                                                                            Client.DateOfBirth

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(45, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Client.DateOfBirth = __value, Client.DateOfBirth, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n          ");
            __builder.AddMarkupContent(47, "<div class=\"invalid-feedback\">Please indicate date of birth.</div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "<label for=\"mobileNumber\" class=\"form-label\">Mobile Number</label>\r\n          ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "class", "form-control is-invalid");
            __builder.AddAttribute(54, "id", "mobileNumber");
            __builder.AddAttribute(55, "required");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                                                                                Client.MobileNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Client.MobileNo = __value, Client.MobileNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n          ");
            __builder.AddMarkupContent(59, "<div class=\"invalid-feedback\">Please provide your mobile number.</div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddMarkupContent(62, "<label for=\"emailAd\" class=\"form-label\">Email</label>\r\n          ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "class", "form-control is-invalid");
            __builder.AddAttribute(66, "id", "emailAd");
            __builder.AddAttribute(67, "required");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                                                                           Client.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Client.Email = __value, Client.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n          ");
            __builder.AddMarkupContent(71, "<div class=\"valid-feedback\">Email is available</div>\r\n          ");
            __builder.AddMarkupContent(72, "<div class=\"invalid-feedback\">Email already taken.</div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenElement(74, "div");
            __builder.AddMarkupContent(75, "<label for=\"password\" class=\"form-label\">Password</label>\r\n          ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "password");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "id", "password");
            __builder.AddAttribute(80, "required");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Projects\Net Core\Queen\Queen.Web\Pages\Client\SignUp.razor"
                                                                                     Client.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Client.Password = __value, Client.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
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