#pragma checksum "C:\Ashok\VS2019\Web2FA\MVCApplication\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8596392cefc2dfb0d8ee5a864ec22465494fd7e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
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
#line 1 "C:\Ashok\VS2019\Web2FA\MVCApplication\Views\_ViewImports.cshtml"
using MVCApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ashok\VS2019\Web2FA\MVCApplication\Views\_ViewImports.cshtml"
using MVCApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8596392cefc2dfb0d8ee5a864ec22465494fd7e1", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028b587f7c3aef1c3cb40ecb12fa0a996d7d3625", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCApplication.Models.UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script src=\"https://code.jquery.com/jquery-3.4.1.min.js\"\r\n        integrity=\"sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Ashok\VS2019\Web2FA\MVCApplication\Views\Home\Show.cshtml"
  
    ViewData["Title"] = "User Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 11 "C:\Ashok\VS2019\Web2FA\MVCApplication\Views\Home\Show.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n\r\n<select>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8596392cefc2dfb0d8ee5a864ec22465494fd7e14302", async() => {
                WriteLiteral("User Id");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8596392cefc2dfb0d8ee5a864ec22465494fd7e15466", async() => {
                WriteLiteral("Created Date");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</select>\r\n<td>User id</td>\r\n<input type=\"text\" id=\"userData\" />\r\n<input type=\"button\" value=\"submit\" onclick=\"submit()\" />\r\n<table class=\"table table-bordered\">\r\n   \r\n</table>\r\n\r\n<input type=\"button\" value=\"Export To Excel\"");
            BeginWriteAttribute("onclick", " onclick=\"", 669, "\"", 731, 3);
            WriteAttributeValue("", 679, "location.href=\'", 679, 15, true);
#nullable restore
#line 27 "C:\Ashok\VS2019\Web2FA\MVCApplication\Views\Home\Show.cshtml"
WriteAttributeValue("", 694, Url.Action("ExportToExcel", "Home"), 694, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 730, "\'", 730, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
<script>
    function submit() {
        var inputData = $(""#userData"").val();
        var object = {
            ""inputType"": $(""select"").val(),
            ""information"": inputData
        }
        console.log(object);
        debugger;
        $.ajax({
            url: ""/home/UserDetails"",
            type: ""POST"",
            data: object,
            success:
                function (json) {
                   
                    var tr;

                    var data=json;
                    tr = $('<tr>');
                    tr.append(""<th>User ID</th>"");
                    tr.append(""<th>Name</th>"");
                    tr.append(""<th>email</th>"");
                    tr.append(""<th>Phone</th>"");
                    tr.append(""<th>Opar ID</th></tr>"");
                    $(""table"").append(tr);
                    for (var i = 0; i < json.length; i++) {
                         console.log(json[i]);
                        tr = $('<tr>');
               
                    tr.");
            WriteLiteral(@"append(""<td>"" + json[i][""userId""] + ""</td>"");
                    tr.append(""<td>"" + json[i][""userName""] + ""</td>"");
                    tr.append(""<td>"" + json[i][""eMail""] + ""</td>"");
                    tr.append(""<td>"" + json[i][""phone""] + ""</td>"");
                        tr.append(""<td>"" + json[i][""oparId""] + ""</td>"");
                         $('table').append(tr);
                    }
                    

                       
                    //Append each row to html table
                   
                },
            error: function (error) {
                console.log(""error"");
            }
        })
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCApplication.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
