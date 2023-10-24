using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class Plus : Form
    {
        int count = 3;
        int IScore; // Iscore 변수 선언

        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public string plus_score;
        public Plus() //생성자
        {
            InitializeComponent();//디자인 초기화
                                  //
                                  // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;
            Random_Btn();//Random버튼 초기화면

            //나머지 전부 안보이기
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            lb_Sec.Visible = true;// 3,2,1만 보이기
            Change_xy();//x, y와 버튼 난수           
            OneTwoThree();
            //IScore = int.Parse(lb_Score.Text);//lb_Score 초기화
            label1.Text = string.Empty;//label.Text=string.Empty;            
            lb_Score.Text = string.Empty;
            IScore = 0;
            labelProgressBar1.CustomText = "20.0";
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }
        private void Clear()
        {
            lb_x.Text = "-";
            lb_y.Text = "-";
            label3.Text = string.Empty;
            //lb_Score.Text = "-";
            lb_Sec.Text = string.Empty;
            label1.Text = string.Empty;
            //progressBar1.Value = 20;
            btn_Number_0.Text = "-";
            btn_Number_1.Text = "-";
            btn_Number_2.Text = "-";
            btn_Number_3.Text = "-";
            btn_Number_4.Text = "-";
            btn_Number_5.Text = "-";
            btn_Number_6.Text = "-";
            btn_Number_7.Text = "-";
            btn_Number_8.Text = "-";
            btn_Number_9.Text = "-";
        }
        //시작 타이머
        private void OneTwoThree()
        {
            lb_Sec.Text = string.Empty;
            lb_Sec.Visible = true;// 3,2,1만 보이기
            timer2.Enabled = true;
        }

        //폼1 키프리뷰 트루
        private void Key_true()
        {
            Plus form1 = new Plus();
            this.KeyPreview = true;
            timer2.Stop();
            timer1.Start();
        }
        public void timer_1_Stop()
        {
            timer1.Stop();
        }

        class Number
        {
            Random random = new Random();//랜덤 인스턴스 생성
            //x의 난수값
            public int number_x()
            {
                int a = random.Next(0, 10);
                return a;
            }
            //y의 난수값
            public int number_y()
            {
                int b = random.Next(0, 10);
                return b;
            }
        }

        //게임 진행중
        private void Gaming()
        {
            if (label1.Text == (int.Parse(lb_x.Text) + int.Parse(lb_y.Text)).ToString())
            {
                IScore += 10;
                lb_Score.Text = IScore.ToString();
                Change_xy();
                Random_Btn();
                label1.Text = string.Empty;
            }
            else
            {
                IScore -= 5;
                lb_Score.Text = IScore.ToString();
                Change_xy();
                label1.Text = string.Empty;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                Gaming();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_Equal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_Equal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //btn 클릭 이벤트
        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if (lb_x.Text == "-" || lb_y.Text == "-")
            {
                MessageBox.Show("게임시작을 하지 않았습니다.");
                return;
            }
            if (label1.Text == (int.Parse(lb_x.Text) + int.Parse(lb_y.Text)).ToString())
            {
                IScore += 10;
                lb_Score.Text = IScore.ToString();
                Change_xy();
                Random_Btn();
                label1.Text = string.Empty;
            }
            else
            {
                IScore -= 5;
                lb_Score.Text = IScore.ToString();
                Change_xy();
                label1.Text = string.Empty;
            }
        }
        //클릭버튼 난수 발생
        private void Random_Btn()
        {
            Random random = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(0, 10);
                for (int j = 0; j <= i; j++)
                {
                    if (arr[i] == arr[j] && j != i)
                    {
                        i = i - 1;
                    }
                }
            }
            btn_Number_0.Text = arr[0].ToString();
            btn_Number_1.Text = arr[1].ToString();
            btn_Number_2.Text = arr[2].ToString();
            btn_Number_3.Text = arr[3].ToString();
            btn_Number_4.Text = arr[4].ToString();
            btn_Number_5.Text = arr[5].ToString();
            btn_Number_6.Text = arr[6].ToString();
            btn_Number_7.Text = arr[7].ToString();
            btn_Number_8.Text = arr[8].ToString();
            btn_Number_9.Text = arr[9].ToString();
        }

        private string str = "";
        private void btn_Number_0_Click(object sender, EventArgs e)
        {
            str = btn_Number_0.Text;
            label1.Text += str;
        }

        private void btn_Number_1_Click(object sender, EventArgs e)
        {
            str = btn_Number_1.Text;
            label1.Text += str;
        }

        private void btn_Number_2_Click(object sender, EventArgs e)
        {
            str = btn_Number_2.Text;
            label1.Text += str;
        }

        private void btn_Number_3_Click(object sender, EventArgs e)
        {
            str = btn_Number_3.Text;
            label1.Text += str;
        }

        private void btn_Number_4_Click(object sender, EventArgs e)
        {
            str = btn_Number_4.Text;
            label1.Text += str;
        }

        private void btn_Number_5_Click(object sender, EventArgs e)
        {
            str = btn_Number_5.Text;
            label1.Text += str;
        }

        private void btn_Number_6_Click(object sender, EventArgs e)
        {
            str = btn_Number_6.Text;
            label1.Text += str;
        }

        private void btn_Number_7_Click(object sender, EventArgs e)
        {
            str = btn_Number_7.Text;
            label1.Text += str;
        }

        private void btn_Number_8_Click(object sender, EventArgs e)
        {
            str = btn_Number_8.Text;
            label1.Text += str;
        }

        private void btn_Number_9_Click(object sender, EventArgs e)
        {
            str = btn_Number_9.Text;
            label1.Text += str;
        }

        //timer 20초 지나면 스탑
        private void timer1_Tick(object sender, EventArgs e)
        {

            lb_Sec.Text = string.Empty;
            labelProgressBar1.Value--;


            if (double.Parse(labelProgressBar1.CustomText) > 10.0 && labelProgressBar1.Value != 0)
            {
                labelProgressBar1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar1.CustomText) - 0.1);
            }
            else
            {
                labelProgressBar1.TextColor = Color.White;
                labelProgressBar1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar1.CustomText) - 0.1);
            }

            if (labelProgressBar1.Value < 1)
            {
                timer1.Stop();
                Clear();

                foreach (Control control in this.Controls)
                {
                    control.Visible = false;
                }

                lb_Plus_lastscore.Text = "score : " + lb_Score.Text;
                lb_Plus_lastscore.Enabled = true;
                lb_Plus_lastscore.Visible = true;
                btn_Plus_ok.Enabled = true;
                btn_Plus_ok.Visible = true;

                //MessageBox.Show("랜덤 숫자더하기 게임의 점수는" + lb_Score.Text + "점입니다.", " 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();

                //Clear();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Change_xy();
        }

        // x,y값 변경
        private void Change_xy()
        {
            Number number = new Number();
            int val1 = number.number_x();
            int val2 = number.number_y();

            lb_x.Text = val1.ToString();
            lb_y.Text = val2.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //
        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            lb_Sec.Visible = true;// 3,2,1만 보이기

            if (count > 0)
            {
                lb_Sec.Text = count.ToString();
                count--;
            }
            else if (count == 0)
            {
                lb_Sec.Location = new Point(100, 120);
                lb_Sec.Text = "START";
                Key_true();

                //시작된후 버튼 보이기
                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }

                lb_Plus_lastscore.Enabled = false;
                lb_Plus_lastscore.Visible = false;
                btn_Plus_ok.Enabled = false;
                btn_Plus_ok.Visible = false;

                //timer2.Enabled = false;

                //count = 3;

                //timer1.Enabled = true;
            }
        }

        private void btn_Plus_ok_Click(object sender, EventArgs e)
        {
            //lb_Plus_lastscore.Text = lb_Score.Text;
            plus_score = lb_Score.Text;
            //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            //this.FormSendEvent(plus_score.ToString());

            this.Close();
        }
    }
}
