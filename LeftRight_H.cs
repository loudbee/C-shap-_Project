using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class LeftRight_H : Form
    {
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public int totalscore;
        public LeftRight_H()
        {
            InitializeComponent();
            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;
            lbScore.Text = " 0 ";
            labelProgressBar2.CustomText = "20.0";
            lbEndScore.Visible = false;
            button1.Visible = false;

        }
        int count = 0;
        private int score = 0; // 점수
        private int realNum = 0; // 해당 숫자
        private string mode = ""; // 모드 문자
        Random rand = new Random(); // 랜덤

        private void UIR() // 모드 선택시 실행되는 랜덤사진 함수
        {
            int num = rand.Next(0, 4);
            if (num == 0) { btnI1.Image = imageList2.Images[0]; realNum = 1; }
            else if (num == 1) { btnI1.Image = imageList2.Images[1]; realNum = 2; }
            else if (num == 2) { btnI1.Image = imageList2.Images[2]; realNum = 3; }
            else if (num == 3) { btnI1.Image = imageList2.Images[3]; realNum = 4; }
        }
        private void Clear() // 초기화
        {
            score = 0; lbScore.Text = " 0 ";
            labelProgressBar2.Value = 200;
            labelProgressBar2.TextColor = Color.Black;
            labelProgressBar2.CustomText = "20.0";
        }

        private void timer1_Tick(object sender, EventArgs e) // 시작시 프로그래스바 타이머
        {
            lbScore.Text = score.ToString();

            labelProgressBar2.Value--;
            if (double.Parse(labelProgressBar2.CustomText) > 10.0)
            {
                labelProgressBar2.CustomText = string.Format("{0:f1}",
                double.Parse(labelProgressBar2.CustomText) - 0.1);
            }
            else
            {
                labelProgressBar2.TextColor = Color.White;
                labelProgressBar2.CustomText = string.Format("{0:f1}",
                double.Parse(labelProgressBar2.CustomText) - 0.1);
            }

            if (labelProgressBar2.Value == 0) // 20초 끝나면 
            {
                timer3.Stop();
                timer1.Stop();

                foreach (Control control in this.Controls)
                {
                    control.Visible = false;
                }

                totalscore = score;

                lbEndScore.Text = "score : " + totalscore.ToString();
                lbEndScore.Visible = true;
                button1.Visible = true;

                Clear();
            }
            else { timer3.Start(); }
        }
        private void timer2_Tick(object sender, EventArgs e) // 타이머 시작전 카운트 시작
        {
            if (lb_Sec.Visible == false) { lb_Sec.Visible = true; lb_Sec.Location = new Point(195, 197); lb_Sec.Text = "4"; }
            if (lb_Sec.Text == "4") { lb_Sec.Text = "3"; }
            if (lb_Sec.Text == "3") { lb_Sec.Text = "2"; }
            else if (lb_Sec.Text == "2") { lb_Sec.Text = "1"; }
            else if (lb_Sec.Text == "1") { lb_Sec.Location = new Point(100, 200); lb_Sec.Text = "START"; }
            else
            {
                lb_Sec.Visible = false;
                timer2.Stop();
                timer1.Start();
            }
        }
        private void timer3_Tick(object sender, EventArgs e) { UIR(); } // 랜덤 사진 조정 타이머
        private void btnStart_Click(object sender, EventArgs e) // 시작버튼 클릭시
        {
            Clear();
            //MessageBox.Show("하드모드 시작합니다.");
            //UIR();
            btnI1.Image = imageList2.Images[4];
            timer2.Start();
        }
        private void btnL_Click(object sender, EventArgs e) // 왼쪽1 버튼
        {
            int L = 1;
            if (L == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
            else { score -= 5; }
        }

        private void btnR_Click(object sender, EventArgs e) // 오른쪽1 버튼
        {
            int R = 2;
            if (R == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
            else { score -= 5; }
        }

        private void btnUL_Click(object sender, EventArgs e) // 하드 - 왼쪽2 버튼
        {
            int R = 3;
            if (R == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
            else { score -= 5; }

        }

        private void btnUR_Click(object sender, EventArgs e) // 하드 - 오른쪽2 버튼
        {
            int R = 4;
            if (R == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
            else { score -= 5; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //totalscore = score;
            //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            this.FormSendEvent(totalscore.ToString());

            this.Close();
        }
    }
}
