#pragma checksum "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ae5cca7e607a68ba3a513f66160cbe21db96ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_DataDictDetail_DataDictDetailIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/DataDictDetail/DataDictDetailIndex.cshtml")]
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
#line 2 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ae5cca7e607a68ba3a513f66160cbe21db96ed", @"/Areas/SystemManage/Views/DataDictDetail/DataDictDetailIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_DataDictDetail_DataDictDetailIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        字典类：<input id=""dictType"" col=""DictType"" type=""text"" readonly=""readonly"" />
                    </li>
                    <li>
                        字典键：<input id=""dictKey"" col=""DictKey"" type=""text"" />
                    </li>
                    <li>
                        字典值：<input id=""dictValue"" col=""DictValue"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm"" id=""toolbarPermission"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
    ");
            WriteLiteral(@"        <a id=""btnEdit"" class=""btn btn-primary disabled"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
        </div>

        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">

    var dictType = ys.request(""dictType"");

    $(function () {
        $(""#dictType"").val(dictType);

        initGrid();
    });

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 47 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                   Write(Url.Content("~/SystemManage/DataDictDetail/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            sortName: 'DictSort',
            sortOrder: 'Asc',
            toolbar: '#toolbarPermission',
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'DictKey', title: '字典键' },
                { field: 'DictValue', title: '字典值' },
                {
                    field: 'IsDefault', title: '系统默认', formatter: function (value, row, index) {
                        return ys.getValueByKey(ys.getJson(");
#nullable restore
#line 60 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                                                      Write(Html.Raw(typeof(IsEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"), value);
                    }
                },
                {
                    field: 'ListClass', title: '显示样式', formatter: function (value, row, index) {
                        if (value) {
                            return '<span class=""badge badge-' + value + '"">&nbsp;&nbsp;&nbsp;&nbsp;</span>';
                        }
                    }
                },
                {
                    field: 'DictStatus', title: '状态', formatter: function (value, row, index) {
                        if (row.DictStatus == """);
#nullable restore
#line 72 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                                          Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"badge badge-primary\">\' + \"");
#nullable restore
#line 73 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                                                                      Write(StatusEnum.Yes.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            return \'<span class=\"badge badge-warning\">\' + \"");
#nullable restore
#line 75 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                                                                      Write(StatusEnum.No.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + '</span>';
                        }
                    }
                },
                {
                    field: 'BaseModifyTime', title: '创建时间', formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        })
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                id");
            WriteLiteral(" = selectedRow[0].Id;\r\n            }\r\n        }\r\n        ys.openDialog({\r\n            title: id > 0 ? \"编辑字典数据\" : \"添加字典数据\",\r\n            content: \'");
#nullable restore
#line 111 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                 Write(Url.Content("~/SystemManage/DataDictDetail/DataDictDetailForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id + '&dictType=' + dictType,
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function deleteForm() {
        var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 125 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\DataDictDetail\DataDictDetailIndex.cshtml"
                     Write(Url.Content("~/SystemManage/DataDictDetail/DeleteFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids,
                    type: ""post"",
                    success: function (obj) {
                        if (obj.Tag == 1) {
                            ys.msgSuccess(obj.Message);
                            searchGrid();
                        }
                        else {
                            ys.msgError(obj.Message);
                        }
                    }
                });
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
