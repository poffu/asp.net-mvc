#pragma checksum "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9386f3cda4f1ca751bba743c5a6db3f408591794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddData_Index), @"mvc.1.0.view", @"/Views/AddData/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9386f3cda4f1ca751bba743c5a6db3f408591794", @"/Views/AddData/Index.cshtml")]
    public class Views_AddData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LabeledData.Models.LabeledDataDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
 if (Model == null || Model.Id == 0)
{
	ViewBag.controller = Html.BeginForm("Index", "AddData", FormMethod.Post, new { enctype = "multipart/form-data", @class = "contact100-form validate-form" });
}
else
{
	ViewBag.controller = Html.BeginForm("Index", "EditData", FormMethod.Post, new { enctype = "multipart/form-data", @class = "contact100-form validate-form" });
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
  
	Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-contact100\">\r\n\t<div class=\"wrap-contact100\" style=\"width:1000px;\">\r\n");
#nullable restore
#line 18 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
         using (ViewBag.controller)
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
       Write(Html.Hidden("AudioName", (object)ViewBag.audioName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
       Write(Html.Hidden("ImageName", (object)ViewBag.imageName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
       Write(Html.Hidden("UserId", (object)ViewBag.userId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
             if (Model == null || Model.Id == 0)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<span class=\"contact100-form-title\">\r\n\t\t\t\t\tAdd Data\r\n\t\t\t\t</span>\r\n");
#nullable restore
#line 31 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<span class=\"contact100-form-title\">\r\n\t\t\t\t\tEdit Data\r\n\t\t\t\t</span>\r\n");
#nullable restore
#line 37 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"text-danger fw-bold text-center mb-4\">\r\n\t\t\t\t<div>\r\n\t\t\t\t\t");
#nullable restore
#line 41 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.EnglishTestId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t");
#nullable restore
#line 44 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.TestFormatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t");
#nullable restore
#line 47 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.TopicId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t");
#nullable restore
#line 50 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t");
#nullable restore
#line 52 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Audio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 input100-select\">\r\n\t\t\t\t<span class=\"label-input100\">English test</span>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<select name=\"EnglishTestId\" class=\"selection-2\">\r\n\t\t\t\t\t\t<option value=\"0\">--- Select english test ---</option>\r\n");
#nullable restore
#line 60 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                         foreach (var item in ViewBag.englishTestList)
						{
							if (ViewBag.englishTestId == item.Id)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 1824, "\"", 1840, 1);
#nullable restore
#line 64 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
WriteAttributeValue("", 1832, item.Id, 1832, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 64 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 65 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 1920, "\"", 1936, 1);
#nullable restore
#line 68 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
WriteAttributeValue("", 1928, item.Id, 1928, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 69 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</select>\r\n\t\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 input100-select\">\r\n\t\t\t\t<span class=\"label-input100\">Test format</span>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<select name=\"TestFormatId\" class=\"selection-2\">\r\n\t\t\t\t\t\t<option value=\"0\">--- Select test format ---</option>\r\n");
#nullable restore
#line 81 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                         foreach (var item in ViewBag.testFormatList)
						{
							if (ViewBag.testFormatId == item.Id)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 2422, "\"", 2438, 1);
#nullable restore
#line 85 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
WriteAttributeValue("", 2430, item.Id, 2430, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 85 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 86 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 2518, "\"", 2534, 1);
#nullable restore
#line 89 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
WriteAttributeValue("", 2526, item.Id, 2526, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 90 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</select>\r\n\t\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 input100-select\">\r\n\t\t\t\t<span class=\"label-input100\">Topic</span>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<select name=\"TopicId\" class=\"selection-2\">\r\n\t\t\t\t\t\t<option value=\"0\">--- Select topic ---</option>\r\n");
#nullable restore
#line 102 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                         foreach (var item in ViewBag.topicList)
						{
							if (ViewBag.topicId == item.Id)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 2993, "\"", 3009, 1);
#nullable restore
#line 106 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
WriteAttributeValue("", 3001, item.Id, 3001, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 106 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 107 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 3089, "\"", 3105, 1);
#nullable restore
#line 110 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
WriteAttributeValue("", 3097, item.Id, 3097, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 111 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</select>\r\n\t\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 validate-input\">\r\n\t\t\t\t<span class=\"label-input100\">Question</span>\r\n\t\t\t\t");
#nullable restore
#line 120 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Question, new { placeholder = "Enter question", @class = "input100", @style = "min-height:155px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 validate-input\">\r\n\t\t\t\t<span class=\"label-input100\">Content</span>\r\n\t\t\t\t");
#nullable restore
#line 126 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Content, new { placeholder = "Enter content", @class = "input100", @style = "min-height:155px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 validate-input\">\r\n\t\t\t\t<span class=\"label-input100\">Score</span>\r\n\t\t\t\t");
#nullable restore
#line 132 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Score, new { placeholder = "Enter score", @class = "input100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 validate-input\">\r\n\t\t\t\t<span class=\"label-input100\">Audio</span>\r\n\t\t\t\t");
#nullable restore
#line 138 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Audio, new { placeholder = "Enter file", @class = "input100", type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t<div class=\"wrap-input100 validate-input\">\r\n\t\t\t\t<span class=\"label-input100\">Image</span>\r\n\t\t\t\t");
#nullable restore
#line 144 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Image, new { placeholder = "Enter file", multiple = "multiple", @class = "input100", type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"focus-input100\"></span>\r\n\t\t\t</div>\r\n");
            WriteLiteral(@"			<div class=""container-contact100-form-btn"">
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
#line 159 "D:\asp .net\LabeledDataManagement\Views\AddData\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n<div id=\"dropDownSelect1\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LabeledData.Models.LabeledDataDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
