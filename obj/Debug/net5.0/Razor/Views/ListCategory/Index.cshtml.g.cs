#pragma checksum "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0d509eff43de5d03c39d9999193852e013bba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListCategory_Index), @"mvc.1.0.view", @"/Views/ListCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0d509eff43de5d03c39d9999193852e013bba5", @"/Views/ListCategory/Index.cshtml")]
    public class Views_ListCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<LabeledData.Models.MstCategoryDto>, LabeledData.Models.MstCategoryDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/list-category.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
  
	Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2e0d509eff43de5d03c39d9999193852e013bba54286", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container-contact100\">\r\n\t<div class=\"align-items-center row\" style=\"width:85%;\">\r\n\t\t<div class=\"wrap-contact100 h-100 col-xl-6 col-lg-12\" style=\"padding: 10px 20px;width:700px;\">\r\n");
#nullable restore
#line 12 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
             using (Html.BeginForm("Index", "ListCategory", FormMethod.Get, new { @class = "d-flex row" }))
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<input class=\"form-control me-2 col-xs-12 col-lg-5\" type=\"search\" name=\"nameSearch\" placeholder=\"Enter name\" aria-label=\"Search\"");
            BeginWriteAttribute("value", " value=\"", 666, "\"", 693, 1);
#nullable restore
#line 14 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 674, ViewBag.nameSearch, 674, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t<select name=\"tagType\" class=\"me-2 col-xs-12 col-lg-3\">\r\n\t\t\t\t\t<option value=\"-1\">Select type</option>\r\n");
#nullable restore
#line 17 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                     foreach (KeyValuePair<int, string> item in ViewBag.typeList)
					{
						if (ViewBag.tagType == item.Key)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 945, "\"", 962, 1);
#nullable restore
#line 21 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 953, item.Key, 953, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 21 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                          Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 22 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 1039, "\"", 1056, 1);
#nullable restore
#line 25 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 1047, item.Key, 1047, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 26 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
						}
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</select>\r\n\t\t\t\t<button class=\"btn btn-outline-success col-xs-12 col-lg-2\" type=\"submit\">Search</button>\r\n");
#nullable restore
#line 30 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
			<div class=""mt-4"">
				<table class=""table"">
					<thead class=""container-fluid"">
						<tr>
							<th scope=""col"" style=""width:15%"">#</th>
							<th scope=""col"">Name</th>
							<th scope=""col"" style=""width:25%"">Type</th>
							<th scope=""col"" style=""width:20%"">Action</th>
						</tr>
					</thead>
");
#nullable restore
#line 42 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                     foreach (var data in Model.Item1.Select((value, index) => new { index, value }))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tbody style=\"border:1px solid black;\">\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<th scope=\"row\" class=\"text-center text-break\">");
#nullable restore
#line 46 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                                           Write(ViewBag.offset + data.index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t<td class=\"text-break\">");
#nullable restore
#line 47 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                  Write(data.value.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"text-break\">");
#nullable restore
#line 48 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                  Write(data.value.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"d-flex justify-content-around border-0\">\r\n\t\t\t\t\t\t\t\t\t<button class=\"btn btn-success btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2079, "\"", 2176, 3);
            WriteAttributeValue("", 2089, "window.location.href=\'", 2089, 22, true);
#nullable restore
#line 50 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 2111, Url.Action("Index", "EditCategory", new { id = data.value.Id }), 2111, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2175, "\'", 2175, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button>\r\n\t\t\t\t\t\t\t\t\t<button class=\"btn btn-danger btn-sm rounded-0\" type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2343, "\"", 2401, 4);
            WriteAttributeValue("", 2353, "confirmDelete(", 2353, 14, true);
#nullable restore
#line 51 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 2367, data.value.Id, 2367, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2381, ",", 2381, 1, true);
            WriteAttributeValue(" ", 2382, "\'delete-category\')", 2383, 19, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></button>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t</tbody>\r\n");
#nullable restore
#line 55 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</table>\r\n\t\t\t</div>\r\n\r\n");
#nullable restore
#line 59 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
             if (ViewBag.totalPage > 1)
			{
				ViewBag.firstPage = ViewBag.listPaging[0];

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"mt-3\">\r\n\t\t\t\t\t<nav aria-label=\"Page navigation example\">\r\n\t\t\t\t\t\t<ul class=\"pagination\">\r\n");
#nullable restore
#line 65 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                             if (ViewBag.firstPage > ViewBag.limitPaging)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t\t<a class=\"page-link\" aria-label=\"Previous\"");
            BeginWriteAttribute("href", " href=\"", 2858, "\"", 3065, 1);
#nullable restore
#line 68 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 2865, Url.Action("Index", "ListCategory", new
								{
									page = ViewBag.firstPage - ViewBag.limitPaging,
									nameSearch = ViewBag.nameSearch,
									tagType = ViewBag.tagType
								}), 2865, 200, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span aria-hidden=\"true\">&laquo;</span></a>\r\n\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 75 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                             foreach (var pageNumber in ViewBag.listPaging)
							{
								if (ViewBag.page == pageNumber)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li class=\"page-item\"><a class=\"page-link text-white\" style=\"background-color:#2D78B2;\">");
#nullable restore
#line 80 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                                                                                       Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 81 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
								}
								else
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3473, "\"", 3661, 1);
#nullable restore
#line 85 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 3480, Url.Action("Index", "ListCategory", new
										{
											page = pageNumber,
											nameSearch = ViewBag.nameSearch,
											tagType = ViewBag.tagType
										}), 3480, 181, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                       Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 92 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
								}
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                             if ((ViewBag.firstPage + ViewBag.limitPaging) <= ViewBag.totalPage)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3865, "\"", 4072, 1);
#nullable restore
#line 97 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 3872, Url.Action("Index", "ListCategory", new
								{
									page = ViewBag.firstPage + ViewBag.limitPaging,
									nameSearch = ViewBag.nameSearch,
									tagType = ViewBag.tagType
								}), 3872, 200, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span aria-hidden=\"true\">&raquo;</span></a>\r\n\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 104 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t</nav>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 108 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\r\n");
#nullable restore
#line 111 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
         if (Model.Item2 == null || Model.Item2.Id == 0)
		{
			ViewBag.controller = Html.BeginForm("Index", "AddCategory", FormMethod.Post, new { @class = "validate-form col-xl-6 col-lg-12 d-flex flex-xl-row-reverse justify-content-md-center" });
		}
		else
		{
			ViewBag.controller = Html.BeginForm("Index", "EditCategory", FormMethod.Post, new { @class = "validate-form col-xl-6 col-lg-12 d-flex flex-xl-row-reverse justify-content-md-center" });
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<div class=\"wrap-contact100 h-100 mt-3\">\r\n");
#nullable restore
#line 121 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
             using (ViewBag.controller)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
           Write(Html.ValidationSummary(true, null));

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
           Write(Html.Hidden("Id", Model.Item2.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                 if (Model.Item2 == null || Model.Item2.Id == 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<span class=\"contact100-form-title\">\r\n\t\t\t\t\t\tAdd Category\r\n\t\t\t\t\t</span>\r\n");
#nullable restore
#line 132 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<span class=\"contact100-form-title\">\r\n\t\t\t\t\t\tEdit Category\r\n\t\t\t\t\t</span>\r\n");
#nullable restore
#line 138 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"text-danger fw-bold text-center mb-4\">\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t");
#nullable restore
#line 142 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                   Write(Html.ValidationMessage("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t");
#nullable restore
#line 145 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                   Write(Html.ValidationMessage("TagType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t\t<div class=\"wrap-input100 validate-input\">\r\n\t\t\t\t\t<span class=\"label-input100\">Name</span>\r\n\t\t\t\t\t");
#nullable restore
#line 151 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
               Write(Html.TextBox("Name", Model.Item2.Name, new { placeholder = "Enter name", @class = "input100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t\t<div class=\"wrap-input100 input100-select\">\r\n\t\t\t\t\t<span class=\"label-input100\">Type</span>\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t<select name=\"TagType\" class=\"selection-2\">\r\n\t\t\t\t\t\t\t<option value=\"-1\">--- Select type ---</option>\r\n");
#nullable restore
#line 160 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                             foreach (KeyValuePair<int, string> item in ViewBag.typeList)
							{
								if (ViewBag.typeId == item.Key)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 5922, "\"", 5939, 1);
#nullable restore
#line 164 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 5930, item.Key, 5930, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 164 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                                  Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 165 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
								}
								else
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 6024, "\"", 6041, 1);
#nullable restore
#line 168 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
WriteAttributeValue("", 6032, item.Key, 6032, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 168 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
                                                         Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 169 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
								}
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</select>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t\t</div>\r\n");
            WriteLiteral(@"				<div class=""container-contact100-form-btn"">
					<div class=""wrap-contact100-form-btn"">
						<div class=""contact100-form-bgbtn""></div>
						<button class=""contact100-form-btn"">
							<span>
								Submit
								<i class=""fa fa-long-arrow-right m-l-7"" aria-hidden=""true""></i>
							</span>
						</button>
					</div>
				</div>
");
#nullable restore
#line 187 "D:\asp .net\LabeledDataManagement\Views\ListCategory\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div id=\"dropDownSelect1\"></div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n<script>\r\n\t$(\".selection-2\").select2({\r\n\t\tminimumResultsForSearch: 20,\r\n\t\tdropdownParent: $(\'#dropDownSelect1\')\r\n\t});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<LabeledData.Models.MstCategoryDto>, LabeledData.Models.MstCategoryDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591