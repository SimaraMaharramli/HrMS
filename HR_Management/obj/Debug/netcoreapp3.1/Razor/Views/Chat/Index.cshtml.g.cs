#pragma checksum "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e662fc538685786d64a7469b0908033a8868a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "C:\C#\.NET\HrManagement\HR_Management\Views\_ViewImports.cshtml"
using HR_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\.NET\HrManagement\HR_Management\Views\_ViewImports.cshtml"
using HR_Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\C#\.NET\HrManagement\HR_Management\Views\_ViewImports.cshtml"
using HR_Management.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\C#\.NET\HrManagement\HR_Management\Views\_ViewImports.cshtml"
using HR_Management.ViewModels.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e662fc538685786d64a7469b0908033a8868a96", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e9ff844df84e1ca927f096d6adb896ea008787", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
  
    EmployeeUser loggedUser = null;
    if (User.Identity.IsAuthenticated)
    {
        loggedUser = await _userManager.FindByNameAsync(User.Identity.Name);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Index start-->
<section class=""pr-chat"">
    <div class=""dashboard-wrapper"">
        <div class=""dashboard-header"">
            <div class=""left-header"">
                <button class=""navbar-toggler"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink""
                         width=""34px"" height=""34px"" viewBox=""0 0 24 24"" version=""1.1"">
                        <g stroke=""none"" stroke-width=""1"" fill=""#d0d3d6"" fill-rule=""evenodd"">
                            <rect x=""0"" y=""0"" width=""24"" height=""24""></rect>
                            <rect fill=""#3445e5"" x=""4"" y=""4"" width=""7"" height=""7"" rx=""1.5""></rect>
                            <path d=""M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 C13.6715729,11 13");
            WriteLiteral(@",10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z""
                                  fill=""#3445e5"" opacity=""0.3""></path>
                        </g>
                    </svg>
                </button>
                <h3>Chat</h3>
            </div>
        </div>
        <div class=""dashboard-content"">
            <div class=""card"">
                <div class=""row g-0"">
                    <div class=""col-12 col-lg-5 col-xl-3 border-right"">
                        <div class=""px-4 d-none d-md-block"">
                            <div class=""d-flex align-items-center"">
                                <div class=""flex-grow-1"">
                                    <input type=""text"" class=""form-control my-3"" placeholder=""Search..."" />
                                </div>
               ");
            WriteLiteral("             </div>\r\n                        </div>\r\n                        <!--Employees-->\r\n");
#nullable restore
#line 46 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                         foreach (var emp in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("id", " id=\"", 2595, "\"", 2607, 1);
#nullable restore
#line 48 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
WriteAttributeValue("", 2600, emp.Id, 2600, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action border-0 d-none\">\r\n");
#nullable restore
#line 49 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                  
                                    var time = (DateTime.Now - (DateTime)emp.DisconnectedAt).Minutes;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e662fc538685786d64a7469b0908033a8868a9610720", async() => {
                WriteLiteral("\r\n                                                <div class=\"d-flex align-items-start\" style=\"padding: 10px 20px ;\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e662fc538685786d64a7469b0908033a8868a9611151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3262, "~/assets/images/userPhotos/", 3262, 27, true);
#nullable restore
#line 54 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
AddHtmlAttributeValue("", 3289, emp.ProfilePhoto, 3289, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    <div class=\"d-flex gap-1 flex-grow-1 ml-3\">\r\n                                                        <span class=\"contact-name\">");
#nullable restore
#line 56 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                                                              Write(emp.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                        <div class=\"d-flex align-items-center small\">\r\n                                                            <span");
                BeginWriteAttribute("class", " class=\"", 3733, "\"", 3812, 4);
                WriteAttributeValue("", 3741, "fas", 3741, 3, true);
                WriteAttributeValue(" ", 3744, "fa-circle", 3745, 10, true);
#nullable restore
#line 58 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 3754, emp.ConnectionId == null?"chat-offline":"chat-online", 3755, 56, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3811, "", 3812, 1, true);
                EndWriteAttribute();
                WriteLiteral("></span> \r\n");
                WriteLiteral("                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                                                                              Write(emp.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                                                                                                  Write(emp.FullName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-name", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                                                                                                                             Write(emp.ProfilePhoto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-photo", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                                                                                                                                                                   Write(time);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-connectionAt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                                                                                                                                                                                                              Write(loggedUser.FullName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-messagefrom", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n");
#nullable restore
#line 66 "C:\C#\.NET\HrManagement\HR_Management\Views\Chat\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <hr class=""d-block d-lg-none mt-1 mb-0"" />
                    </div>
                    <div class=""col-12 col-lg-7 col-xl-9"">
                        <div class=""py-2 px-4 border-bottom d-none d-lg-block"">
                            <div class=""d-flex align-items-center py-1"">
");
            WriteLiteral(@"                                <div class=""flex-grow-1 pl-3"">
                                    <strong  id=""userInput"">Select someone to chat ...</strong>
                                    <small id=""connectionAt""></small>
                                </div>
                                <div>
                                    <button class=""btn btn-primary btn-lg mr-1 px-3"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24""
                                             viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor""
                                             stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""
                                             class=""feather feather-phone feather-lg"">
                                            <path d=""M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 ");
            WriteLiteral(@"0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"">
                                            </path>
                                        </svg>
                                    </button>
                                    <button class=""btn btn-primary btn-lg mr-1 px-3 d-none d-md-inline-block"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24""
                                             viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor""
                                             stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""
                                             class=""feather feather-video feather-lg"">
                                            <polygon points=""23 7 16 12 23 17 23 7""></polygon>
                                            <rect x=""1"" y=""5"" width=""15"" height=""14"" rx=""2"" ry=""2""></rect>
                                        ");
            WriteLiteral(@"</svg>
                                    </button>
                                    <button class=""btn btn-primary btn-lg px-3"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24""
                                             viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor""
                                             stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""
                                             class=""feather feather-more-horizontal feather-lg"">
                                            <circle cx=""12"" cy=""12"" r=""1""></circle>
                                            <circle cx=""19"" cy=""12"" r=""1""></circle>
                                            <circle cx=""5"" cy=""12"" r=""1""></circle>
                                        </svg>
                                    </button>
                                </div>
                            </div>
                        </div>
                  ");
            WriteLiteral("      <input type=\"hidden\" name=\"Id\" id=\"idInput\"");
            BeginWriteAttribute("value", " value=\"", 8028, "\"", 8036, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"position-relative\">\r\n                            <div class=\"chat-messages message-list p-4\" style=\"min-height: 570px; max-height: 570px;\">\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""flex-grow-0 py-3 px-4 border-top"">
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control"" id=""messageInput"" placeholder=""Type your message"" />
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e662fc538685786d64a7469b0908033a8868a9623298", async() => {
                WriteLiteral("Send");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--Index end-->\r\n");
            DefineSection("CssChat", async() => {
                WriteLiteral("\r\n            <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" />\r\n");
            }
            );
            DefineSection("ScriptChat", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e662fc538685786d64a7469b0908033a8868a9625186", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<EmployeeUser> _userManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591