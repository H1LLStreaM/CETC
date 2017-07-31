using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CETCWeb
{
    public partial class ConsulForm4MDT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtpatno.Attributes.Add("onkeydown", "btnSearchPatinfo_Click()");
        }

        protected void btnSearchPatinfo_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Hello');</script>");  

            #region
            //string xxx = this.txtpatno.Text.ToString().Trim();
            //string yyy = this.cmbPatSrc.InnerText.ToString();
            //int yyy1 = this.cmbPatSrc.SelectedIndex;
            //int zzz1 = this.cmbPattype.SelectedIndex;

            //if (xxx == "") return;

            ////this.initUI();
            //this.txtpatno.Text = xxx;
            //this.cmbPatSrc.SelectedIndex = yyy1;
            //this.cmbPattype.SelectedIndex = zzz1;
            //try
            //{
            //    //通过治疗号码，获取病人基本信息。
            //    Dictionary<string, object> parms = new Dictionary<string, object>();
            //    parms["FUNC"] = "CHECKINHOSPNO";
            //    parms["PATSRC"] = yyy;
            //    parms["INHOSPNO"] = xxx;
            //    //var json = HttpServiceHelper.Default.PostData("YLT_FindPatinfo", parms, null);
            //    //if (json != null)
            //    //{
            //    //    JsonHelper jh = new JsonHelper(json);
            //    //    if (jh["code"] != null && jh["code"] == "_fail")
            //    //    {
            //    //        MessageBoxHelper.ShowFail("通过住院号或者门诊号没有找到对应的病人院内信息，请填写正确再提交！");
            //    //    }
            //    //    else
            //    //    {
            //    //        if (int.Parse(jh["WARDLOG_NUM"]) == 0)
            //    //            MessageBoxHelper.ShowWarning("无医嘱的病人提交申请，被目标医院驳回申请几率较高！");

            //    //        patinfo = Serializer.FromJson<PatInfo>(jh.ToString());
            //    //        this.txtIDCard.Text = jh["CARDNO"];
            //    //        this.txtPatname.Text = jh["NAME"];
            //    //        this.txtTel.Text = jh["RELATIVETEL"];
            //    //        this.txtTel.Text = jh["RELATIVETEL"];
            //    //    }
            //    //}
            //    this.txtRemark.Focus();
                #region MyRegion
                //       < select id = "getPatInfos" parameterClass = "net.sf.json.JSONObject" resultClass = "net.sf.json.JSONObject" >< ![CDATA[
                //       select * from dl_view_病人信息 t where 1 = 1

                //       ]] >

                //           < isNotEmpty prepend = " and " property = "CARDNO" > CARDNO =#CARDNO#</isNotEmpty>
                //   < isEqual prepend = " and " property = "ISZY" compareValue = "Y" > INHOSPNO is not null </ isEqual >

                //               < isEqual prepend = " and " property = "ISZY" compareValue = "N" > OUTPATNO is not null </ isEqual >

                //                           < isNotEmpty prepend = " and " property = "OUTPATNO" > OUTPATNO =#OUTPATNO# and ZYID in(select nvl(max(x.ZYID), 0) from dl_view_病人信息 x where x.OUTPATNO=#OUTPATNO# group by x.INHOSPNO)</isNotEmpty>
                //< isNotEmpty prepend = " and " property = "INHOSPNO" >< ![CDATA[INHOSPNO =#INHOSPNO# and ZYID in(select nvl(max(x.ZYID), 0) from dl_view_病人信息 x where x.INHOSPNO = #INHOSPNO# group by x.INHOSPNO)]]></isNotEmpty>
                //order by ZYID desc
                //       </ select >
                #endregion
           // }
            //catch { }
            #endregion
        }
    }
}