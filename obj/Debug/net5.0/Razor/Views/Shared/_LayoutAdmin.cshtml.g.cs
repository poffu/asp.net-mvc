#pragma checksum "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d2554c8429d6c792779aacc165ae68a5fa32b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d2554c8429d6c792779aacc165ae68a5fa32b4", @"/Views/Shared/_LayoutAdmin.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/view/images/icons/favicon.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/site.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/site.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4d2554c8429d6c792779aacc165ae68a5fa32b45016", async() => {
                WriteLiteral("\r\n\t<meta charset=\"UTF-8\">\r\n\t<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4d2554c8429d6c792779aacc165ae68a5fa32b45449", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4d2554c8429d6c792779aacc165ae68a5fa32b46712", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4d2554c8429d6c792779aacc165ae68a5fa32b47889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<title>Label Tool</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4d2554c8429d6c792779aacc165ae68a5fa32b49727", async() => {
                WriteLiteral(@"
	<header>
		<div class=""container-fluid p-0"">
			<nav class=""navbar navbar-expand-lg bg-light"">
				<div class=""container-fluid"">
					<label class=""navbar-brand"">Labeled Management</label>
					<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" style=""color:#f8f9fa"">
						<span class=""navbar-toggler-icon"">
							<i class=""fa fa-navicon"" style=""color:black; font-size:28px;""></i>
						</span>
					</button>
					<div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
						<ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
							<li class=""nav-item fw-bold"">
								");
#nullable restore
#line 28 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
                           Write(Html.ActionLink("Home", "Index", "ListUser", null, new { @class = "nav-link text-black" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li class=\"nav-item fw-bold\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 31 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
                           Write(Html.ActionLink("Category", "Index", "ListCategory", null, new { @class = "nav-link text-black" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li class=\"nav-item fw-bold\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 34 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
                           Write(Html.ActionLink("Creat Account", "Index", "CreateAccount", null, new { @class = "nav-link text-black" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li class=\"nav-item fw-bold\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 37 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
                           Write(Html.ActionLink("Change Password", "Index", "ChangePassword", null, new { @class = "nav-link text-black" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li class=\"nav-item fw-bold\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 40 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
                           Write(Html.ActionLink("Logout", "Logout", "Login", null, new { @class = "nav-link text-black" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
							</li>
						</ul>
					</div>
				</div>
			</nav>
		</div>
	</header>

	<div class=""CustomConfirmParent"" id=""alertConfirm"" style=""display: none"">
		<div class=""CustomConfirmBody"">
			<div class=""ConfirmTitle"">Notification</div>
			<div class=""ConfirmMessage"">
				<span id=""messageAlert""></span>
			</div>
			<div class=""ConfirmFooter d-flex justify-content-between px-3 pt-4 text-end"">
				<button class=""ConfirmButton btn btn-primary"" onclick=""confirmOKAlert()"">OK</button>
				<button class=""ConfirmButton btn btn-secondary"" onclick=""confirmCancel()"">Cancel</button>
			</div>
			<input type=""hidden"" id=""hiddenId""");
                BeginWriteAttribute("value", " value=\"", 2448, "\"", 2456, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" id=\"action\"");
                BeginWriteAttribute("value", " value=\"", 2497, "\"", 2505, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t</div>\r\n\t</div>\r\n\r\n");
#nullable restore
#line 64 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
     if (TempData["AlertMessage"] != null)
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<div class=\"CustomConfirmParent\" id=\"alertBox\">\r\n\t\t\t<div class=\"CustomConfirmBody\">\r\n\t\t\t\t<div class=\"ConfirmTitle\">Notification</div>\r\n\t\t\t\t<div class=\"ConfirmMessage\">");
#nullable restore
#line 69 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
                                       Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\t\t\t\t<div class=\"ConfirmFooter px-3 pt-4 text-end\">\r\n\t\t\t\t\t<button class=\"ConfirmButton btn btn-primary\" id=\"btnOK\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2892, "\"", 2931, 3);
                WriteAttributeValue("", 2902, "confirmOK(\'", 2902, 11, true);
#nullable restore
#line 71 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 2913, TempData["Url"], 2913, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2929, "\')", 2929, 2, true);
                EndWriteAttribute();
                WriteLiteral(">OK</button>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 75 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
	}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t");
#nullable restore
#line 77 "D:\asp .net\LabeledDataManagement\Views\Shared\_LayoutAdmin.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n\t$(\".selection-2\").select2({\r\n\t\tminimumResultsForSearch: 20,\r\n\t\tdropdownParent: $(\'#dropDownSelect1\')\r\n\t});\r\n</script>\r\n\r\n</html>");
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
