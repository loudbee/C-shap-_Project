using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class Bubibubi : Form
    {
        public int totalscore;
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public Bubibubi()
        {
            InitializeComponent();
            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;

            labelProgressBar1.CustomText = "20.0";
            lbScore.Text = " 0 ";
            lbEndScore.Visible = false;
            button2.Visible = false;
        }
        private int score = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if ((trackBar1.Value >= 0 && trackBar1.Value <= 8) || trackBar1.Value >= 42 && trackBar1.Value <= 50) { score += 2; }
            else { score -= 1; }

        }
        private void Clear()
        {
            score = 0;
            trackBar1.Value = 25;
            labelProgressBar1.Value = 200;
            labelProgressBar1.TextColor = Color.Black;
            labelProgressBar1.CustomText = "20.0";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Clear();
            lbScore.Text = " 0 ";
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbScore.Text = score.ToString();
            labelProgressBar1.Value--;
            if (double.Parse(labelProgressBar1.CustomText) > 10.0)
            {
                labelProgressBar1.CustomText = string.Format("{0:f1}",
                double.Parse(labelProgressBar1.CustomText) - 0.1);
            }
            else
            {
                labelProgressBar1.TextColor = Color.White;
                labelProgressBar1.CustomText = string.Format("{0:f1}",
                double.Parse(labelProgressBar1.CustomText) - 0.1);
            }
            if (labelProgressBar1.Value == 0)
            {
                timer1.Stop();

                foreach (Control control in this.Controls)
                {
                    control.Visible = false;
                }

                lbEndScore.Visible = true;
                button2.Visible = true;
                lbEndScore.Text = "score : " + score.ToString();
                totalscore = score;

                Clear();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lb_Sec.Visible == false) { lb_Sec.Visible = true; lb_Sec.Location = new Point(195, 197); lb_Sec.Text = "4"; }
            if (lb_Sec.Text == "4") { lb_Sec.Text = "3"; }
            else if (lb_Sec.Text == "3") { lb_Sec.Text = "2"; }
            else if (lb_Sec.Text == "2") { lb_Sec.Text = "1"; }
            else if (lb_Sec.Text == "1") { lb_Sec.Location = new Point(100, 200); lb_Sec.Text = "START"; }
            else
            {
                lb_Sec.Visible = false;
                timer2.Stop();
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //totalscore = score;
            //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            this.FormSendEvent(totalscore.ToString());

            this.Close();
        }
    }
}
