#pragma checksum "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79a5d39e8c1f0fd34d5f2e2b5757171f279c219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Form_Editor), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Form/Editor.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 3 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79a5d39e8c1f0fd34d5f2e2b5757171f279c219", @"/Areas/DemoManage/Views/Form/Editor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Form_Editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 162, "\"", 227, 1);
#nullable restore
#line 7 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
WriteAttributeValue("", 169, Url.Content("~/lib/summernote/0.8.15/summernote.min.css"), 169, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 275, "\'", 334, 1);
#nullable restore
#line 8 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
WriteAttributeValue("", 281, Url.Content("~/lib/summernote/0.8.15/summernote.js"), 281, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 381, "\'", 455, 1);
#nullable restore
#line 9 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
WriteAttributeValue("", 387, Url.Content("~/lib/summernote/0.8.15/lang/summernote-zh-CN.min.js"), 387, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-content"">
                    <h2>Summernote</h2>
                    <p>
                        <a href=""https://github.com/summernote/summernote"" target=""_blank"">Summernote</a> 是一个简单的基于Bootstrap的WYSIWYG富文本编辑器
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Summernote 富文本编辑器</h5>
                </div>
                <div class=""ibox-content no-padding"">
                    <div class=""summernote"">
                        <h2>一沙后台管理系统</h2>
                        <p>
                            YiShaAdmin 是一个开源的后台管理系统快速开发框架，基于.NET Core Web技术（ASP.NET Core Web，ASP.NET Core Web Api），主要目的让开发者专注业务，
           ");
            WriteLiteral(@"                 降低技术难度，从而节省人力成本，缩短项目周期，提高软件安全质量。
                        </p>
                        <p>
                            <span class=""label label-warning"">免费开源</span>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>编辑/保存为html代码示例</h5>
                    <button id=""edit"" class=""btn btn-primary btn-xs m-l-sm"" onclick=""edit()"" type=""button"">编辑</button>
                    <button id=""save"" class=""btn btn-primary  btn-xs"" onclick=""save()"" type=""button"">保存</button>
                </div>
                <div class=""ibox-content"" id=""eg"">

                    <div class=""click2edit wrapper"">
                        <h3>你好，一沙 </h3>
                        <p>
                            YiShaAdmin 是一个开源的后台管理系统快速开发框架，基于.NET Core Web技术（ASP.NE");
            WriteLiteral(@"T Core Web，ASP.NET Core Web Api），主要目的让开发者专注业务，
                            降低技术难度，从而节省人力成本，缩短项目周期，提高软件安全质量。
                        </p>
                        <p>
                            <span class=""label label-warning"">开源免费</span>
                        </p>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('.summernote').summernote({
            lang: 'zh-CN'
        });
    });

    var edit = function () {
        $(""#eg"").addClass(""no-padding"");
        $('.click2edit').summernote({
            lang: 'zh-CN',
            focus: true
        });
    };

    var save = function () {
        $(""#eg"").removeClass(""no-padding"");
        var html = $('.click2edit').summernote('code');
        $('.click2edit').summernote('destroy');
    };
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; }
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
