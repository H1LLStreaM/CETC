<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winDeptList.aspx.cs" Inherits="CETCWeb.winDeptList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="shortcut icon" href="favicon.ico" />
    <link href="css/bootstrap.min.css?v=3.3.6" rel="stylesheet" />
    <link href="css/font-awesome.min.css?v=4.4.0" rel="stylesheet" />
    <link href="css/plugins/jsTree/style.min.css" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet" />
    <link href="css/style.min.css?v=4.1.0" rel="stylesheet" />
    <link href="css/plugins/bootstrap-table/bootstrap-table.min.css" rel="stylesheet" />
    <title></title>
</head>
<body class="gray-bg">
    <div class="wrapper wrapper-content  animated fadeInRight">

        <div class="row">
            <div class="col-sm-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-content">
                        <input id="test3" type="text" />
                        <input id="btn3" type="button" value="button" /></div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">

                        <div class="ibox-tools">
                            <a class="collapse-link">
                                <i class="fa fa-chevron-up"></i>
                            </a>
                            <a class="close-link">
                                <i class="fa fa-times"></i>
                            </a>
                        </div>
                    </div>
                    <div class="ibox-content">
                        <div id="using_json">
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-sm-6">
                <!-- Example Checkbox Select -->
                <div class="example-wrap">
                    <h4 class="example-title">复选框</h4>
                    <div class="example">
                        <table data-toggle="table" data-url="js/demo/bootstrap_table_test.json" data-height="299" data-click-to-select="true" data-mobile-responsive="true">
                            <thead>
                                <tr>
                                    <th data-field="state" data-checkbox="true"></th>
                                    <th data-field="name">名称</th>
                                    <th data-field="price">价格</th>
                                    <th data-field="column1">列1</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <!-- End Example Checkbox Select -->
            </div>
        </div>
    </div>
    <script src="js/jquery.min.js?v=2.1.4"></script>
    <script src="js/bootstrap.min.js?v=3.3.6"></script>
    <script src="js/content.min.js?v=1.0.0"></script>
    <script src="js/plugins/jsTree/jstree.min.js"></script>
    <script src="js/plugins/bootstrap-table/bootstrap-table.min.js"></script>
    <script src="js/plugins/bootstrap-table/bootstrap-table-mobile.min.js"></script>
    <script src="js/plugins/bootstrap-table/locale/bootstrap-table-zh-CN.min.js"></script>
    <script src="js/demo/bootstrap-table-demo.min.js"></script>
    <script type="text/javascript" src="http://tajs.qq.com/stats?sId=9051096" charset="UTF-8"></script>
    <style>
        .jstree-open > .jstree-anchor > .fa-folder:before {
            content: "\f07c";
        }

        .jstree-default .jstree-icon.none {
            width: 0;
        }
    </style>
    <script>
        $(document).ready(function () {
            var json = <%=getJson()%>;
            var options = { "core": {} };
            options.core.data = json;
            console.log(JSON.stringify(options));
            $(document).ready(function () {$("#using_json").jstree(options) });
        });
        //$(document).ready(function () {
        //    $("#using_json").jstree({
        //        "core": {
        //            "data": [{ "text": "发热门诊", "state": { "opened": true } }, { "text": "急症科", "state": { "opened": true }, "children": [{ "text": "急诊病房", "children": [{ "text": "急诊病房1", "icon": "none" }, { "text": "急诊病房2", "icon": "none" }, { "text": "急诊病房3", "icon": "none" }, { "text": "急诊病房4", "icon": "none" }], "state": { "opened": true } }, { "text": "血液科", "children": [{ "text": "bootstrap.js", "icon": "none" }, { "text": "hplus.min.js", "icon": "none" }, { "text": "jquery.min.js", "icon": "none" }, { "text": "jsTree.min.js", "icon": "none" }, { "text": "custom.min.js", "icon": "none" }], "state": { "opened": true } }, { "text": "html", "children": [{ "text": "layout.html", "icon": "none" }, { "text": "navigation.html", "icon": "none" }, { "text": "navbar.html", "icon": "none" }, { "text": "footer.html", "icon": "none" }, { "text": "sidebar.html", "icon": "none" }], "state": { "opened": true } }] }, "Fonts", "Images", "Scripts", "Templates", ]

        //        }
        //    })
        //});
    </script>
    <script type="text/javascript" src="http://tajs.qq.com/stats?sId=9051096" charset="UTF-8"></script>
</body>
</html>