using SapInfo.Common.JsonUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace CETCWeb
{
    public partial class winDeptList : System.Web.UI.Page
    {
        StringBuilder sb = new StringBuilder();
        List<deptClass> mList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string json = "[{'DEPTNAME':'呼吸药理学实验室','DEPTID':'20246','P_DEPTID':'198','RN':121},{'DEPTNAME':'肿瘤4科','DEPTID':'35','P_DEPTID':'27','RN':76},{'DEPTNAME':'肿瘤5科','DEPTID':'36','P_DEPTID':'27','RN':144},{'DEPTNAME':'肿瘤2科','DEPTID':'33','P_DEPTID':'27','RN':96},{'DEPTNAME':'急诊病房','DEPTID':'159','P_DEPTID':'153','RN':60},{'DEPTNAME':'肿瘤3科','DEPTID':'34','P_DEPTID':'27','RN':122},{'DEPTNAME':'肿瘤放疗病房','DEPTID':'39','P_DEPTID':'5446','RN':35},{'DEPTNAME':'急诊外科','DEPTID':'155','P_DEPTID':'153','RN':71},{'DEPTNAME':'急诊内科','DEPTID':'154','P_DEPTID':'153','RN':2},{'DEPTNAME':'发热门诊','DEPTID':'152','RN':27},{'DEPTNAME':'急症科','DEPTID':'153','RN':15},{'DEPTNAME':'护理部','DEPTID':'43','P_DEPTID':'202','RN':63},{'DEPTNAME':'计算机中心','DEPTID':'42','P_DEPTID':'202','RN':1},{'DEPTNAME':'北院中医康复科','DEPTID':'6612','P_DEPTID':'4222','RN':30},{'DEPTNAME':'妇科1科','DEPTID':'7746','P_DEPTID':'129','RN':48},{'DEPTNAME':'北院肾内病房','DEPTID':'7068','P_DEPTID':'7066','RN':133},{'DEPTNAME':'北院妇产科','DEPTID':'6611','P_DEPTID':'4222','RN':11},{'DEPTNAME':'妇科2科','DEPTID':'7747','P_DEPTID':'129','RN':90},{'DEPTNAME':'北院ICU','DEPTID':'7067','P_DEPTID':'4222','RN':193},{'DEPTNAME':'北院肾内科','DEPTID':'7066','P_DEPTID':'4222','RN':31},{'DEPTNAME':'肾脏内2科','DEPTID':'7744','P_DEPTID':'83','RN':127},{'DEPTNAME':'北院体检中心','DEPTID':'6766','P_DEPTID':'4222','RN':188},{'DEPTNAME':'北院综合内科','DEPTID':'6613','P_DEPTID':'4222','RN':24},{'DEPTNAME':'肾脏内3科','DEPTID':'7745','P_DEPTID':'83','RN':129},{'DEPTNAME':'北院肿瘤内科','DEPTID':'6615','P_DEPTID':'4222','RN':37},{'DEPTNAME':'产科','DEPTID':'7748','P_DEPTID':'129','RN':12},{'DEPTNAME':'心内2科','DEPTID':'4786','P_DEPTID':'75','RN':111},{'DEPTNAME':'西院','DEPTID':'5746','RN':22},{'DEPTNAME':'泌尿外2科','DEPTID':'7741','P_DEPTID':'107','RN':20},{'DEPTNAME':'北院肠道门诊','DEPTID':'6610','P_DEPTID':'4222','RN':88},{'DEPTNAME':'泌尿外3科','DEPTID':'7740','P_DEPTID':'107','RN':67},{'DEPTNAME':'心理咨询','DEPTID':'200','RN':74},{'DEPTNAME':'肾脏内1科','DEPTID':'7743','P_DEPTID':'83','RN':61},{'DEPTNAME':'泌尿外1科','DEPTID':'7742','P_DEPTID':'107','RN':186},{'DEPTNAME':'呼吸内镜','DEPTID':'12348','P_DEPTID':'12346','RN':98},{'DEPTNAME':'检验科','DEPTID':'169','P_DEPTID':'207','RN':52},{'DEPTNAME':'膀胱镜','DEPTID':'12349','P_DEPTID':'12346','RN':119},{'DEPTNAME':'内镜中心','DEPTID':'12346','RN':8},{'DEPTNAME':'消化内镜','DEPTID':'12347','P_DEPTID':'12346','RN':33},{'DEPTNAME':'病案统计室','DEPTID':'26','P_DEPTID':'202','RN':149},{'DEPTNAME':'肿瘤内科','DEPTID':'27','RN':27},{'DEPTNAME':'家庭病床科','DEPTID':'168','RN':18},{'DEPTNAME':'综合干诊科','DEPTID':'161','P_DEPTID':'160','RN':56},{'DEPTNAME':'北院急诊','DEPTID':'6609','P_DEPTID':'4222','RN':34},{'DEPTNAME':'综合介入病房','DEPTID':'164','P_DEPTID':'7186','RN':118},{'DEPTNAME':'后装治疗室','DEPTID':'30','P_DEPTID':'5446','RN':157},{'DEPTNAME':'肿瘤内科门诊','DEPTID':'32','P_DEPTID':'27','RN':112},{'DEPTNAME':'肿瘤1科','DEPTID':'31','P_DEPTID':'27','RN':162},{'DEPTNAME':'脊柱外科','DEPTID':'7733','P_DEPTID':'99','RN':106},{'DEPTNAME':'关节外科','DEPTID':'7734','P_DEPTID':'99','RN':57},{'DEPTNAME':'神经外1科及癫痫中心','DEPTID':'7735','P_DEPTID':'104','RN':115},{'DEPTNAME':'北院','DEPTID':'4222','RN':32},{'DEPTNAME':'神经外2科','DEPTID':'7736','P_DEPTID':'104','RN':93},{'DEPTNAME':'北院药剂科','DEPTID':'6607','P_DEPTID':'4222','RN':33},{'DEPTNAME':'神经内1科','DEPTID':'7737','P_DEPTID':'87','RN':117},{'DEPTNAME':'神经内2科','DEPTID':'7738','P_DEPTID':'87','RN':120},{'DEPTNAME':'神经内3科','DEPTID':'7739','P_DEPTID':'87','RN':31},{'DEPTNAME':'胸外2科','DEPTID':'7732','P_DEPTID':'111','RN':179},{'DEPTNAME':'胸外1科','DEPTID':'7731','P_DEPTID':'111','RN':92},{'DEPTNAME':'医务部','DEPTID':'17','P_DEPTID':'202','RN':50},{'DEPTNAME':'科研部','DEPTID':'14','P_DEPTID':'202','RN':39},{'DEPTNAME':'院部','DEPTID':'11','P_DEPTID':'202','RN':8},{'DEPTNAME':'病理科','DEPTID':'174','P_DEPTID':'207','RN':138},{'DEPTNAME':'药剂科','DEPTID':'175','RN':13},{'DEPTNAME':'北院神经康复病房','DEPTID':'11447','P_DEPTID':'11446','RN':142},{'DEPTNAME':'内分泌2科','DEPTID':'7728','P_DEPTID':'79','RN':49},{'DEPTNAME':'乳腺外科','DEPTID':'7726','P_DEPTID':'94','RN':191},{'DEPTNAME':'内分泌1科','DEPTID':'7727','P_DEPTID':'79','RN':184},{'DEPTNAME':'胃肠外科','DEPTID':'7724','P_DEPTID':'94','RN':189},{'DEPTNAME':'甲状腺外科','DEPTID':'7725','P_DEPTID':'94','RN':155},{'DEPTNAME':'急腹症外科','DEPTID':'7722','P_DEPTID':'94','RN':174},{'DEPTNAME':'ICU室','DEPTID':'4767','RN':34},{'DEPTNAME':'皮肤科','DEPTID':'222','RN':12},{'DEPTNAME':'手足外科','DEPTID':'7721','P_DEPTID':'99','RN':40},{'DEPTNAME':'创伤骨2科','DEPTID':'7720','P_DEPTID':'99','RN':89},{'DEPTNAME':'皮肤门诊','DEPTID':'226','P_DEPTID':'222','RN':10},{'DEPTNAME':'激光美容室','DEPTID':'227','P_DEPTID':'222','RN':134},{'DEPTNAME':'皮肤病房','DEPTID':'228','P_DEPTID':'222','RN':140},{'DEPTNAME':'神经外3科','DEPTID':'11846','P_DEPTID':'104','RN':54},{'DEPTNAME':'北院消化病房','DEPTID':'8046','P_DEPTID':'6613','RN':22},{'DEPTNAME':'临床药学室','DEPTID':'187','P_DEPTID':'175','RN':36},{'DEPTNAME':'核医学科','DEPTID':'189','P_DEPTID':'207','RN':95},{'DEPTNAME':'创伤骨1科','DEPTID':'7719','P_DEPTID':'99','RN':152},{'DEPTNAME':'心内3科','DEPTID':'7715','P_DEPTID':'75','RN':14},{'DEPTNAME':'心内4科','DEPTID':'7716','P_DEPTID':'75','RN':65},{'DEPTNAME':'心内5科','DEPTID':'7717','P_DEPTID':'75','RN':87},{'DEPTNAME':'CCU','DEPTID':'7718','P_DEPTID':'75','RN':183},{'DEPTNAME':'内科门诊','DEPTID':'4243','RN':64},{'DEPTNAME':'呼吸2科','DEPTID':'7711','P_DEPTID':'63','RN':59},{'DEPTNAME':'呼吸3科','DEPTID':'7712','P_DEPTID':'63','RN':147},{'DEPTNAME':'消化1科','DEPTID':'7713','P_DEPTID':'58','RN':136},{'DEPTNAME':'消化2科','DEPTID':'7714','P_DEPTID':'58','RN':109},{'DEPTNAME':'内分泌科','DEPTID':'79','RN':85},{'DEPTNAME':'心内1科','DEPTID':'78','P_DEPTID':'75','RN':110},{'DEPTNAME':'心电图室','DEPTID':'77','P_DEPTID':'75','RN':168},{'DEPTNAME':'整形门诊','DEPTID':'115','P_DEPTID':'114','RN':177},{'DEPTNAME':'胸外病房','DEPTID':'113','P_DEPTID':'111','RN':180},{'DEPTNAME':'泌外门诊','DEPTID':'110','P_DEPTID':'107','RN':187},{'DEPTNAME':'普外(胃肠)门诊','DEPTID':'7986','P_DEPTID':'94','RN':42},{'DEPTNAME':'神经内科','DEPTID':'87','RN':153},{'DEPTNAME':'透析中心','DEPTID':'84','P_DEPTID':'83','RN':116},{'DEPTNAME':'肾内科门诊','DEPTID':'85','P_DEPTID':'83','RN':37},{'DEPTNAME':'中医病房','DEPTID':'125','P_DEPTID':'120','RN':99},{'DEPTNAME':'呼吸门诊','DEPTID':'68','P_DEPTID':'63','RN':148},{'DEPTNAME':'中医推拿门诊','DEPTID':'128','P_DEPTID':'120','RN':172},{'DEPTNAME':'针灸门诊','DEPTID':'121','P_DEPTID':'120','RN':80},{'DEPTNAME':'理疗门诊','DEPTID':'122','P_DEPTID':'120','RN':69},{'DEPTNAME':'中医门诊','DEPTID':'123','P_DEPTID':'120','RN':79},{'DEPTNAME':'口腔颌面外科','DEPTID':'7787','RN':78},{'DEPTNAME':'磁共振MRI','DEPTID':'4262','P_DEPTID':'191','RN':84},{'DEPTNAME':'康复中心','DEPTID':'120','RN':19},{'DEPTNAME':'血液门诊','DEPTID':'71','P_DEPTID':'70','RN':181},{'DEPTNAME':'风湿病房','DEPTID':'73','P_DEPTID':'6566','RN':32},{'DEPTNAME':'风湿门诊','DEPTID':'74','P_DEPTID':'6566','RN':77},{'DEPTNAME':'心血管门诊','DEPTID':'76','P_DEPTID':'75','RN':46},{'DEPTNAME':'眼科门诊','DEPTID':'134','P_DEPTID':'133','RN':160},{'DEPTNAME':'眼科病房','DEPTID':'135','P_DEPTID':'133','RN':146},{'DEPTNAME':'方便门诊','DEPTID':'57','P_DEPTID':'168','RN':53},{'DEPTNAME':'营养部','DEPTID':'56','P_DEPTID':'202','RN':55},{'DEPTNAME':'学生工作部','DEPTID':'13646','P_DEPTID':'202','RN':94},{'DEPTNAME':'儿科病房(新)','DEPTID':'7768','P_DEPTID':'139','RN':165},{'DEPTNAME':'VIP2','DEPTID':'7767','P_DEPTID':'160','RN':97},{'DEPTNAME':'VIP1','DEPTID':'7766','P_DEPTID':'160','RN':163},{'DEPTNAME':'脱发专病门诊','DEPTID':'18146','P_DEPTID':'222','RN':173},{'DEPTNAME':'脊柱外科专科门诊','DEPTID':'7569','P_DEPTID':'99','RN':108},{'DEPTNAME':'肝胆胰外2科','DEPTID':'18247','P_DEPTID':'94','RN':101},{'DEPTNAME':'肝胆胰外1科','DEPTID':'18246','P_DEPTID':'94','RN':70},{'DEPTNAME':'妇产科门诊','DEPTID':'131','P_DEPTID':'129','RN':145},{'DEPTNAME':'消化门诊','DEPTID':'61','P_DEPTID':'58','RN':25},{'DEPTNAME':'耳鼻喉门诊','DEPTID':'143','P_DEPTID':'142','RN':38},{'DEPTNAME':'耳鼻喉病房','DEPTID':'144','P_DEPTID':'142','RN':58},{'DEPTNAME':'口腔科','DEPTID':'147','RN':29},{'DEPTNAME':'供应室','DEPTID':'45','RN':164},{'DEPTNAME':'口腔门诊','DEPTID':'148','P_DEPTID':'147','RN':175},{'DEPTNAME':'创伤骨科专科门诊','DEPTID':'7567','P_DEPTID':'99','RN':176},{'DEPTNAME':'感染科','DEPTID':'149','RN':5},{'DEPTNAME':'门诊麻醉','DEPTID':'47','P_DEPTID':'46','RN':13},{'DEPTNAME':'手术麻醉科','DEPTID':'46','P_DEPTID':'207','RN':2},{'DEPTNAME':'急诊摄片室','DEPTID':'4726','P_DEPTID':'191','RN':82},{'DEPTNAME':'体检超声','DEPTID':'5726','P_DEPTID':'54','RN':125},{'DEPTNAME':'血管外科病房','DEPTID':'5527','P_DEPTID':'5526','RN':4},{'DEPTNAME':'血管外科','DEPTID':'5526','RN':113},{'DEPTNAME':'体检中心','DEPTID':'54','RN':29},{'DEPTNAME':'儿科门诊','DEPTID':'140','P_DEPTID':'139','RN':143},{'DEPTNAME':'麻醉科','DEPTID':'50','P_DEPTID':'46','RN':102},{'DEPTNAME':'儿科病房含PICU','DEPTID':'141','P_DEPTID':'139','RN':139},{'DEPTNAME':'北院泌尿外科门诊','DEPTID':'6699','P_DEPTID':'6629','RN':41},{'DEPTNAME':'免疫风湿科','DEPTID':'6566','RN':51},{'DEPTNAME':'急诊ICU','DEPTID':'7806','P_DEPTID':'153','RN':156},{'DEPTNAME':'肿瘤放疗科','DEPTID':'5446','RN':36},{'DEPTNAME':'放疗门诊','DEPTID':'5447','P_DEPTID':'5446','RN':75},{'DEPTNAME':'静脉配置中心','DEPTID':'7546','P_DEPTID':'175','RN':124},{'DEPTNAME':'北院肾内门诊','DEPTID':'6688','P_DEPTID':'7066','RN':11},{'DEPTNAME':'北院心内科门诊','DEPTID':'6691','P_DEPTID':'6614','RN':86},{'DEPTNAME':'北院普外科门诊','DEPTID':'6695','P_DEPTID':'6627','RN':103},{'DEPTNAME':'北院普外科病房','DEPTID':'6696','P_DEPTID':'6627','RN':23},{'DEPTNAME':'北院骨外科门诊','DEPTID':'6697','P_DEPTID':'6628','RN':105},{'DEPTNAME':'北院骨外科病房','DEPTID':'6698','P_DEPTID':'6628','RN':24},{'DEPTNAME':'北院心内一病房','DEPTID':'6690','P_DEPTID':'6614','RN':17},{'DEPTNAME':'北院急诊外科','DEPTID':'6679','P_DEPTID':'6609','RN':159},{'DEPTNAME':'北院血液净化','DEPTID':'6686','P_DEPTID':'7066','RN':15},{'DEPTNAME':'北院综合内科病房','DEPTID':'6687','P_DEPTID':'6613','RN':21},{'DEPTNAME':'北院中医康复门诊','DEPTID':'6685','P_DEPTID':'6612','RN':43},{'DEPTNAME':'日规化疗2','DEPTID':'10947','P_DEPTID':'27','RN':190},{'DEPTNAME':'泌尿外科','DEPTID':'107','RN':18},{'DEPTNAME':'北院妇产科门诊','DEPTID':'6681','P_DEPTID':'6611','RN':104},{'DEPTNAME':'急诊皮肤科','DEPTID':'4806','P_DEPTID':'153','RN':123},{'DEPTNAME':'神外门诊','DEPTID':'105','P_DEPTID':'104','RN':126},{'DEPTNAME':'神经外科','DEPTID':'104','RN':135},{'DEPTNAME':'体检眼科','DEPTID':'5969','P_DEPTID':'54','RN':171},{'DEPTNAME':'体检耳鼻喉科','DEPTID':'5968','P_DEPTID':'54','RN':169},{'DEPTNAME':'体检外科','DEPTID':'5967','P_DEPTID':'54','RN':7},{'DEPTNAME':'体检内科','DEPTID':'5966','P_DEPTID':'54','RN':161},{'DEPTNAME':'普外门诊','DEPTID':'98','P_DEPTID':'94','RN':192},{'DEPTNAME':'神内门诊','DEPTID':'90','P_DEPTID':'87','RN':100},{'DEPTNAME':'临床麻醉','DEPTID':'4442','P_DEPTID':'50','RN':158},{'DEPTNAME':'神经电生理室','DEPTID':'88','P_DEPTID':'87','RN':5},{'DEPTNAME':'北院神经内科门诊','DEPTID':'6722','P_DEPTID':'6720','RN':154},{'DEPTNAME':'北院神经内科病房','DEPTID':'6723','P_DEPTID':'6720','RN':44},{'DEPTNAME':'北院呼吸内科','DEPTID':'6726','P_DEPTID':'4222','RN':17},{'DEPTNAME':'北院中西医结合科','DEPTID':'6727','P_DEPTID':'4222','RN':21},{'DEPTNAME':'血液2科','DEPTID':'7707','P_DEPTID':'70','RN':178},{'DEPTNAME':'血液1科','DEPTID':'7706','P_DEPTID':'70','RN':66},{'DEPTNAME':'血液4科','DEPTID':'7709','P_DEPTID':'70','RN':47},{'DEPTNAME':'数字胃肠室','DEPTID':'195','P_DEPTID':'191','RN':128},{'DEPTNAME':'北院呼吸内科门诊','DEPTID':'6729','P_DEPTID':'6726','RN':131},{'DEPTNAME':'导管室','DEPTID':'194','P_DEPTID':'191','RN':150},{'DEPTNAME':'血液3科','DEPTID':'7708','P_DEPTID':'70','RN':182},{'DEPTNAME':'普通摄片室','DEPTID':'196','P_DEPTID':'191','RN':170},{'DEPTNAME':'体检摄片','DEPTID':'5686','P_DEPTID':'191','RN':83},{'DEPTNAME':'放射科','DEPTID':'191','P_DEPTID':'207','RN':30},{'DEPTNAME':'超声科','DEPTID':'190','P_DEPTID':'207','RN':26},{'DEPTNAME':'CT室','DEPTID':'192','P_DEPTID':'191','RN':137},{'DEPTNAME':'实验中心','DEPTID':'198','P_DEPTID':'207','RN':167},{'DEPTNAME':'北院内分泌病房','DEPTID':'17947','P_DEPTID':'6613','RN':91},{'DEPTNAME':'北院药库','DEPTID':'6663','P_DEPTID':'6607','RN':132},{'DEPTNAME':'北院中西医结合门诊','DEPTID':'6731','P_DEPTID':'6727','RN':151},{'DEPTNAME':'呼吸1科','DEPTID':'7710','P_DEPTID':'63','RN':3},{'DEPTNAME':'北院呼吸内科病房','DEPTID':'6730','P_DEPTID':'6726','RN':107},{'DEPTNAME':'北院中西医结合病房','DEPTID':'6732','P_DEPTID':'6727','RN':141},{'DEPTNAME':'北院手术室','DEPTID':'6648','P_DEPTID':'6606','RN':68},{'DEPTNAME':'眼科手术室','DEPTID':'7506','P_DEPTID':'133','RN':185},{'DEPTNAME':'北院超声科','DEPTID':'6650','P_DEPTID':'6606','RN':1},{'DEPTNAME':'北院放射科','DEPTID':'6652','P_DEPTID':'6606','RN':62},{'DEPTNAME':'手足外科康复室','DEPTID':'11046','P_DEPTID':'99','RN':28},{'DEPTNAME':'北院病理','DEPTID':'6653','P_DEPTID':'6606','RN':130},{'DEPTNAME':'北院皮肤科门诊','DEPTID':'6704','P_DEPTID':'6633','RN':72},{'DEPTNAME':'北院供应室','DEPTID':'6636','P_DEPTID':'4222','RN':9},{'DEPTNAME':'北院皮肤科','DEPTID':'6633','P_DEPTID':'4222','RN':20},{'DEPTNAME':'感染病房','DEPTID':'5186','P_DEPTID':'149','RN':194},{'DEPTNAME':'肿瘤研究所','DEPTID':'12646','RN':73},{'DEPTNAME':'西院区内科','DEPTID':'6846','P_DEPTID':'5746','RN':16},{'DEPTNAME':'西院区外科','DEPTID':'6848','P_DEPTID':'5746','RN':114},{'DEPTNAME':'计算机设备库','DEPTID':'4906','P_DEPTID':'42','RN':6},{'DEPTNAME':'急诊抢救室','DEPTID':'5866','P_DEPTID':'153','RN':166},{'DEPTNAME':'北院肿瘤病房','DEPTID':'6716','P_DEPTID':'6615','RN':81},{'DEPTNAME':'北院普外科','DEPTID':'6627','P_DEPTID':'4222','RN':14},{'DEPTNAME':'北院骨外科','DEPTID':'6628','P_DEPTID':'4222','RN':25},{'DEPTNAME':'北院泌尿外科','DEPTID':'6629','P_DEPTID':'4222','RN':19},{'DEPTNAME':'北院肿瘤门诊','DEPTID':'6715','P_DEPTID':'6615','RN':45},{'DEPTNAME':'北院神经内科','DEPTID':'6720','P_DEPTID':'4222','RN':9}]";
                DataTable deptDt = SapInfo.Common.JsonUtility.JsonConverter.ToDataTable(json);
                JArray array;
                array = (JArray)JsonConvert.DeserializeObject(json);
                mList = new List<deptClass>();
                mList = JsonConvert.DeserializeObject<List<deptClass>>(json);
                
            }
        }

        public  string getJson()
        {
            string str = sortList(mList);
            //string str = "{'test':'123'}";
            return str;
        }


        /// <summary>
        /// 部门list排序
        /// </summary>
        /// <param name="_list"></param>
        private string sortList(List<deptClass> _list)
        {
            List<string> strList = new List<string>();
            List<deptClass> parentList = new List<deptClass>();
            for (int i = 0; i < _list.Count; i++)
            {
                if (string.IsNullOrEmpty(_list[i].P_DEPTID))
                {
                    _list[i].isRoot = true;
                    parentList.Add(_list[i]);
                    continue;
                }
                string p_deptid = _list[i].P_DEPTID;
                if (!strList.Contains(p_deptid))
                {
                    List<deptClass> tmp = _list.FindAll(a => a.DEPTID == p_deptid);
                    if (tmp.Count == 0) //一级目录
                    {
                        _list[i].isRoot = true;
                        strList.Add(p_deptid);
                        parentList.Add(_list[i]);
                    }
                    else
                        _list[i].isRoot = false;
                }
            }
            return setListProcess(mList, parentList);
        }

        private string setListProcess(List<deptClass> _list, List<deptClass> parentList)
        {
            string json = "";
            try
            {
                for (int i = 0; i < parentList.Count; i++)
                {
                    string item_name = parentList[i].DEPTNAME;
                    List<deptClass> childlist = mList.FindAll(a => a.P_DEPTID == parentList[i].DEPTID);
                    if (childlist.Count > 0)
                    {
                        //string str = listToFormatJson(parentList[i].DEPTID);
                        string var = listToChildJson(parentList[i].DEPTID);
                        json += "{\"text\":\"" + item_name + "\"," + var + ", \"state\": { \"opened\": true }},";
                    }
                    else
                    {
                        json += "{\"text\":\"" + item_name + "\", \"state\": { \"opened\": true }},";
                    }
                }
            }
            catch (Exception ex)
            { }
            json = "[" + json.Substring(0, json.Length - 1) + "]";
            return json;
        }
        List<string> isAddDept = new List<string>();
        private string listToChildJson(string deptid)
        {
            string str = "\"chilidren \":[";
            try
            {
                List<deptClass> childList = mList.FindAll(a => a.P_DEPTID == deptid);
                for (int i = 0; i < childList.Count; i++)
                {
                    string deptName = childList[i].DEPTNAME;
                    string deptId = childList[i].DEPTID;
                    str += "{\"text\": \"" + deptName + " \"";
                    isAddDept.Add(deptId);
                    if (existChildrens(deptId))
                    {
                        str += ","+listToChildJson(deptId)+"},";
                    }
                    else
                        str += "},";
                }
                str = str.Substring(0, str.Length - 1);
                str += "]";
            }
            catch (Exception ex)
            {

            }
            return str;
        }

        private void listToJsTreeJson(List<deptClass> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string deptName = list[i].DEPTNAME;
                string deptid = list[i].DEPTID;


            }
        }

        private bool existChildrens(string deptid)
        {
            List<deptClass> list = mList.FindAll(a => a.P_DEPTID == deptid);
            if (list.Count > 0)
                return true;
            return false;
        }
    }

    public class deptClass
    {
        public string DEPTNAME { get; set; }
        public string DEPTID { get; set; }
        public string P_DEPTID { get; set; }
        public string RN { get; set; }
        public bool isRoot { get; set; }
    }
}