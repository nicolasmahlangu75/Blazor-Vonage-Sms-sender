#pragma checksum "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54499f9e186ba43c5632bd009920f8d6d581c2d2600e38e4add83e1578cf2587"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSmsApp.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using BlazorSmsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\_Imports.razor"
using BlazorSmsApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
using BlazorSmsApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to the Blazor SMS Sender.</h1>\r\n<hr>");
#nullable restore
#line 7 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
 if (MessageId!=null)
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
__builder.AddContent(1, MessageId);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
              ;
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<hr>\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 12 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
                  SmsObj

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-10");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label>To Number:</label>\r\n\t\t\t\t\t");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
                                                                         SmsObj.RecipientNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SmsObj.RecipientNumber = __value, SmsObj.RecipientNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\t\t\r\n\t\t");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-10");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>SMS Text:</label>\r\n\t\t\t\t");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
                                                                     SmsObj.TextMessage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SmsObj.TextMessage = __value, SmsObj.TextMessage));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\t\t<hr>\r\n\r\n\t\t");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-10");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "btn btn-primary");
                __builder2.AddAttribute(34, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
                                                      SendSMSClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, "Send SMS");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Apex User\WorkSpace\Project\sms-notification\BlazorSmsSenderApp\BlazorSmsApp\Pages\Index.razor"
      
	public SmsModel SmsObj = new SmsModel();
	public string MessageId;

	public void SendSMSClick()
	{
		var response = _smsService.SendSms(SmsObj);
		MessageId = response.Messages[0].MessageId;
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SmsService _smsService { get; set; }
    }
}
#pragma warning restore 1591