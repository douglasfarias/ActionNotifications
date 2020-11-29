#pragma checksum "D:\dev\ActionNotifications\ActionNotificationItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6913491865eee641f55c028749e45979b51d2a31"
// <auto-generated/>
#pragma warning disable 1591
namespace ActionNotifications
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\dev\ActionNotifications\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\dev\ActionNotifications\_Imports.razor"
using ActionNotifications.Models;

#line default
#line hidden
#line 3 "D:\dev\ActionNotifications\_Imports.razor"
using System.Drawing;

#line default
#line hidden
    public partial class ActionNotificationItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "toast fade show");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddAttribute(3, "aria-live", "assertive");
            __builder.AddAttribute(4, "aria-atomic", "true");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "toast-header");
            __builder.OpenElement(7, "strong");
            __builder.AddAttribute(8, "class", "mr-auto");
            __builder.AddContent(9, 
#line 3 "D:\dev\ActionNotifications\ActionNotificationItem.razor"
                             _ActionNotification.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<small class=\"text-muted\">agora</small>\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "ml-2 mb-1 close");
            __builder.AddAttribute(15, "data-dismiss", "toast");
            __builder.AddAttribute(16, "aria-label", "Close");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "D:\dev\ActionNotifications\ActionNotificationItem.razor"
                                                                                                    (() => this._CloseHandler.InvokeAsync(_ActionNotification))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(18, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n  ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "toast-body");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "style", "color:" + (
#line 10 "D:\dev\ActionNotifications\ActionNotificationItem.razor"
                          _ActionNotification.TextColor.Name

#line default
#line hidden
            ) + ";");
            __builder.OpenElement(24, "strong");
            __builder.AddContent(25, 
#line 10 "D:\dev\ActionNotifications\ActionNotificationItem.razor"
                                                                        _ActionNotification.Message

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "D:\dev\ActionNotifications\ActionNotificationItem.razor"
      
    [Parameter]
    public ActionNotification _ActionNotification { get; set; }

    [Parameter]
    public EventCallback<ActionNotification> _CloseHandler { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if(_ActionNotification.TextColor == null)
        {
            _ActionNotification.TextColor = Color.Black;
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
