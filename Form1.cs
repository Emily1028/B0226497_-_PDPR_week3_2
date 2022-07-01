using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            students stu_1, stu_2, stu_3, stu_4, stu_5;
            stu_1.sid = "B0226497_1";
            stu_2.sid = "B0226497_2";
            stu_3.sid = "B0226497_3";
            stu_4.sid = "B0226497_4";
            stu_5.sid = "B0226497_5";
            stu_1.sname = "段昱如_1";
            stu_2.sname = "段昱如_2";
            stu_3.sname = "段昱如_3";
            stu_4.sname = "段昱如_4";
            stu_5.sname = "段昱如_5";
            stu_1.stel = "000001";
            stu_2.stel = "000002";
            stu_3.stel = "000003";
            stu_4.stel = "000004";
            stu_5.stel = "000005";
            stu_1.chi = 87;
            stu_2.chi = 77;
            stu_3.chi = 75;
            stu_4.chi = 74;
            stu_5.chi = 84;
            stu_1.math = 65;
            stu_2.math = 76;
            stu_3.math = 68;
            stu_4.math = 78;
            stu_5.math = 78;
            stu_1.eng = 78;
            stu_2.eng = 79;
            stu_3.eng = 89;
            stu_4.eng = 97;
            stu_5.eng = 80;
            string str= "學生各項資料:";
            str += $"\n學號:{stu_1.sid},姓名:{stu_1.sname},電話:{stu_1.stel},國文:{stu_1.chi},數學:{stu_1.math},英文:{stu_1.eng},平均:{(stu_1.chi+ stu_1.math+ stu_1.eng)/3}";
            str += $"\n學號:{stu_2.sid},姓名:{stu_2.sname},電話:{stu_2.stel},國文:{stu_2.chi},數學:{stu_2.math},英文:{stu_2.eng},平均:{(stu_2.chi + stu_2.math + stu_2.eng) / 3}";
            str += $"\n學號:{stu_3.sid},姓名:{stu_3.sname},電話:{stu_3.stel},國文:{stu_3.chi},數學:{stu_3.math},英文:{stu_3.eng},平均:{(stu_3.chi + stu_3.math + stu_3.eng) / 3}";
            str += $"\n學號:{stu_4.sid},姓名:{stu_4.sname},電話:{stu_4.stel},國文:{stu_4.chi},數學:{stu_4.math},英文:{stu_4.eng},平均:{(stu_4.chi + stu_4.math + stu_4.eng) / 3}";
            str += $"\n學號:{stu_5.sid},姓名:{stu_5.sname},電話:{stu_5.stel},國文:{stu_5.chi},數學:{stu_5.math},英文:{stu_5.eng},平均:{(stu_5.chi + stu_5.math + stu_5.eng) / 3}";
            lblresult.Text = str;
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public struct students
    {
        public string sid;
        public string sname;
        public string stel;
        public int chi;
        public int math;
        public int eng;
    }
}
