#pragma checksum "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf683238141dcbe7ae2aa9e6398c8f8d4108018a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListUser_Index), @"mvc.1.0.view", @"/Views/ListUser/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf683238141dcbe7ae2aa9e6398c8f8d4108018a", @"/Views/ListUser/Index.cshtml")]
    public class Views_ListUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LabeledData.Models.TblUserDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/list-user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
  
	Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf683238141dcbe7ae2aa9e6398c8f8d4108018a4212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container-contact100\">\r\n\t<div class=\"wrap-contact100\" style=\"padding: 10px 20px;width:1000px;\">\r\n");
#nullable restore
#line 11 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
         using (Html.BeginForm("Index", "ListUser", FormMethod.Get, new { @class = "d-flex" }))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<input class=\"form-control me-2 input-search\" type=\"search\" name=\"username\" placeholder=\"Enter keyword\" aria-label=\"Search\"");
            BeginWriteAttribute("value", " value=\"", 517, "\"", 548, 1);
#nullable restore
#line 13 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 525, ViewBag.usernameSearch, 525, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t<button class=\"btn btn-outline-success\" type=\"submit\">Search username</button>\r\n");
#nullable restore
#line 15 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
		<div class=""mt-4"">
			<table class=""table"">
				<thead class=""container-fluid"">
					<tr>
						<th scope=""col"" style=""width:8%"">#</th>
						<th scope=""col"" style=""width:20%"">Username</th>
						<th scope=""col"">Name</th>
						<th scope=""col"" style=""width:8%"">KPI</th>
						<th scope=""col"" style=""width:15%"">Action</th>
					</tr>
				</thead>
");
#nullable restore
#line 28 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                 foreach (var data in Model.Select((value, index) => new { index, value }))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tbody style=\"border:1px solid black;\">\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<th scope=\"row\" class=\"text-center text-break\">");
#nullable restore
#line 32 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                                                                       Write(ViewBag.offset + data.index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t<td class=\"text-break\">");
#nullable restore
#line 33 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                                              Write(data.value.LoginName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td class=\"text-break\">");
#nullable restore
#line 34 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                                              Write(data.value.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td class=\"text-center text-break\">");
#nullable restore
#line 35 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                                                          Write(data.value.DataCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td class=\"d-flex justify-content-around border-0\">\r\n\t\t\t\t\t\t\t\t<button class=\"btn btn-success btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1615, "\"", 1719, 3);
            WriteAttributeValue("", 1625, "window.location.href=\'", 1625, 22, true);
#nullable restore
#line 37 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 1647, Url.Action("Index", "EditAccount", new { userId = data.value.UserId }), 1647, 71, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1718, "\'", 1718, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button>\r\n\t\t\t\t\t\t\t\t<button class=\"btn btn-danger btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1885, "\"", 1943, 4);
            WriteAttributeValue("", 1895, "confirmDelete(", 1895, 14, true);
#nullable restore
#line 38 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 1909, data.value.UserId, 1909, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1927, ",", 1927, 1, true);
            WriteAttributeValue(" ", 1928, "\'delete-user\')", 1929, 15, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></button>\r\n\t\t\t\t\t\t\t\t<button class=\"btn btn-primary btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Open API\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2113, "\"", 2150, 3);
            WriteAttributeValue("", 2123, "openAPI(", 2123, 8, true);
#nullable restore
#line 39 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 2131, data.value.UserId, 2131, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2149, ")", 2149, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-external-link\"></i></button>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t</tbody>\r\n");
#nullable restore
#line 43 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</table>\r\n\t\t</div>\r\n\r\n");
#nullable restore
#line 47 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
         if (ViewBag.totalPage > 1)
		{
			ViewBag.firstPage = ViewBag.listPaging[0];

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"mt-3\">\r\n\t\t\t\t<nav aria-label=\"Page navigation example\">\r\n\t\t\t\t\t<ul class=\"pagination\">\r\n");
#nullable restore
#line 53 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                         if (ViewBag.firstPage > ViewBag.limitPaging)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t<a class=\"page-link\" aria-label=\"Previous\"");
            BeginWriteAttribute("href", " href=\"", 2599, "\"", 2767, 1);
#nullable restore
#line 56 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 2606, Url.Action("Index", "ListUser", new
								{
									page = ViewBag.firstPage - ViewBag.limitPaging,
									username = ViewBag.usernameSearch
								}), 2606, 161, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span aria-hidden=\"true\">&laquo;</span></a>\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 62 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                         foreach (var pageNumber in ViewBag.listPaging)
						{
							if (ViewBag.page == pageNumber)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"page-item\"><a class=\"page-link text-white\" style=\"background-color:#2D78B2;\">");
#nullable restore
#line 67 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                                                                                                                   Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 68 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3163, "\"", 3310, 1);
#nullable restore
#line 72 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 3170, Url.Action("Index", "ListUser", new
										{
											page = pageNumber,
											username = ViewBag.usernameSearch
										}), 3170, 140, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                                       Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 78 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
								}
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
                         if ((ViewBag.firstPage + ViewBag.limitPaging) <= ViewBag.totalPage)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3510, "\"", 3678, 1);
#nullable restore
#line 83 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 3517, Url.Action("Index", "ListUser", new
								{
									page = ViewBag.firstPage + ViewBag.limitPaging,
									username = ViewBag.usernameSearch
								}), 3517, 161, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span aria-hidden=\"true\">&raquo;</span></a>\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 89 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</ul>\r\n\t\t\t\t</nav>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 93 "D:\asp .net\LabeledDataManagement\Views\ListUser\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LabeledData.Models.TblUserDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591