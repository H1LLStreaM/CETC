<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsulForm4MDT.aspx.cs" Inherits="CETCWeb.ConsulForm4MDT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="shortcut icon" href="favicon.ico" />
    <link href="css/bootstrap.min.css?v=3.3.6" rel="stylesheet" />
    <link href="css/font-awesome.min.css?v=4.4.0" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet">
    <link href="css/style.min.css?v=4.1.0" rel="stylesheet" />
    <script src="js/jquery.min.js?v=2.1.4"></script>
    <script src="js/bootstrap.min.js?v=3.3.6"></script>
    <script src="js/content.min.js?v=1.0.0"></script>
    <script type="text/javascript" src="http://tajs.qq.com/stats?sId=9051096" charset="UTF-8"></script>
</head>
<body class="gray-bg">
    <form id="form1" runat="server">
        <div class="wrapper wrapper-content animated fadeIn">
            <div class="col-sm-8">
                <div class="ibox">
                    <div class="ibox-content">
                        <span class="text-muted small pull-right">最后更新：<i class="fa fa-clock-o"></i> 2015-09-01 12:00</span>
                        <h2>客户管理</h2>
                        <p>
                            所有客户必须通过邮件验证
                        </p>
                        <div class="input-group">
                        </div>
                        <div class="clients-list">
                            <ul class="nav nav-tabs">
                                <li class="active"><a data-toggle="tab" href="#tab-1"><i class="fa fa-user"></i>发起申请</a>
                                </li>
                                <li class=""><a data-toggle="tab" href="#tab-2"><i class="fa fa-briefcase"></i>历史追踪</a>
                                </li>
                            </ul>
                            <div class="tab-content">
                                <div id="tab-1" class="tab-pane active">
                                    <div class="full-height-scroll">
                                        <div class="table-responsive">

                                            <div class="ibox-content blue-border-line">
                                                <div class="row">
                                                    <div class="col-sm-12">
                                                        <form class="form-horizontal m-t " id="commentForm " novalidate="novalidate ">

                                                            <div class="row">
                                                                <div class="col-sm-6">
                                                                    <div class="form-group">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">患者情况：</label>
                                                                            <div class="col-md-8 col-xs-8 col-sm-8  ">
                                                                                <div class="row">
                                                                                    <div class="col-sm-10 ">
                                                                                        <select class="form-control m-b" name="account" id="cmbPatSrc" runat="server">
                                                                                            <option value="option 1">院内-住院病人</option>
                                                                                            <option value="option 2">院内-门诊病人 </option>
                                                                                        </select>
                                                                                    </div>
                                                                                    <div class="col-sm-1 text-center"></div>
                                                                                    <div class="col-sm-10 ">
                                                                                        <select class="form-control m-b" name="account" id="cmbPattype" runat="server">
                                                                                            <option value="option 1">一般</option>
                                                                                            <option value="option 2">急诊 </option>
                                                                                            <option value="option 3">危重</option>
                                                                                            <option value="option 4">科研 </option>
                                                                                            <option value="option 5">数字 </option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label">住院/门诊号：</label>
                                                                            <div class="col-sm-10 ">

                                                                                <asp:TextBox ID="txtpatno" runat="server" class="form-control " AutoCompleteType="Search"></asp:TextBox>
                                                                                <asp:Button ID="btnSearchPatinfo" runat="server" Text="Button" OnClick="btnSearchPatinfo_Click"></asp:Button>
                                                                                <%--<input id="cemail " type="text " class="form-control " name="email " required=" " aria-required="true " />--%>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label">身份证号：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <input id="txtIDCard " readonly="readonly" type="text " class="form-control " name="url " />
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label">患者姓名：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <input id="txtPatname " readonly="readonly" type="text " class="form-control " name="url " />
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-sm-6">

                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">申请人电话：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <input id="curl " type="text " class="form-control " name="url " />
                                                                            </div>
                                                                        </div>
                                                                    </div>

                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label">患者电话：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <input id="txtTel " type="text " class="form-control " name="url " />
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label">病情概述：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <textarea class="form-control " placeholder="包含主诉，病史、诊治过程等" id="txtRemark" runat="server"></textarea>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-sm-12">
                                                                    <div class="divider-change"></div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-6 col-xs-6 col-sm-6">
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">时间地点：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <input id="cemail " type="text " class="form-control " name="email " required=" " aria-required="true " />
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">联系方式：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <input id="curl " type="text " class="form-control " name="url ">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">科室和专家：</label>
                                                                            <div class="col-sm-10 ">
                                                                                <textarea id="curl " placeholder="按回车键选择科到或专家" class="form-control " name="url "></textarea>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6 col-xs-6 col-sm-6">
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">会诊目的：</label>
                                                                            <div class="col-sm-10">
                                                                                <input id="cemail " type="text " class="form-control " name="email " />
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">会诊原因：</label>
                                                                            <div class="col-sm-10">
                                                                                <select class="form-control m-b" name="account" id="comboBoxEdit1" runat="server">
                                                                                    <option value="option 1" selected="selected">临床确诊困难或疗效不满意的疑难、危重病例</option>
                                                                                    <option value="option 2">恶性肿瘤患者</option>
                                                                                    <option value="option 3">出现严重并发症的病例</option>
                                                                                    <option value="option 4">拟请院外专家会诊的病例</option>
                                                                                    <option value="option 5">已发生医疗纠纷、医疗投诉或可能出现纠纷的病例</option>
                                                                                </select>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="row">
                                                                            <label class="col-sm-2 control-label ">科室负责人：</label>
                                                                            <div class="col-sm-10">
                                                                                <textarea id="txtKezhuren " placeholder="回车选择科室负责人" class="form-control " name="url "></textarea>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-sm-4 col-sm-offset-4">
                                                                    <button class="btn btn-info dim" type="submit ">提交</button>
                                                                    <button class="btn btn-info dim" type="submit ">新建</button>
                                                                </div>
                                                            </div>
                                                        </form>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div id="tab-2" class="tab-pane">
                                            <div class="full-height-scroll">
                                                <div class="table-responsive">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <script src="js/jquery.min.js?v=2.1.4"></script>
                <script src="js/bootstrap.min.js?v=3.3.6"></script>
                <script src="js/content.min.js?v=1.0.0"></script>
                <script type="text/javascript" src="http://tajs.qq.com/stats?sId=9051096" charset="UTF-8"></script>
    </form>
</body>
</html>