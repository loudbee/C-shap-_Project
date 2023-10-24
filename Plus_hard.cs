using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{

    public partial class Plus_hard : Form
    {
        int count = 3;
        int IScore;
        public string plushard_score = "";

        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;


        public Plus_hard()
        {
            InitializeComponent();

            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;

            Random_Btn();//버튼 초기화
            Val_x_y();//계산 값 초기화
            OneTwoThree();
            lb_Result.Text = string.Empty;//결과값 초기화
            label1.Text = string.Empty;//Score 초기화
            IScore = 0;// Score 변수 초기화
            labelProgressBar1.CustomText = "20.0";
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            lb_Plushard_lastscore.Visible = false;
            btn_Plushard_ok.Visible = false;

            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            lb_Sec.Visible = true;// 3,2,1만 보이기
        }
        private void OneTwoThree()
        {
            lb_Sec.Text = string.Empty;
            timer2.Start();
        }
        //게임 진행중
        private void Gaming()
        {
            if (lb_Result.Text == str1)
            {
                IScore += 10;
                label1.Text = IScore.ToString();
                Random_Btn();
                lb_Result.Text = string.Empty;
            }
            else
            {
                IScore -= 5;
                label1.Text = IScore.ToString();
                lb_Result.Text = string.Empty;
            }
            Val_x_y();
        }

        //버튼 난수 발생
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

        //A키 눌림 발생시 Gaming()메소드 실행
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                Gaming();
        }

        private void Key_true()
        {
            Plus_hard form1 = new Plus_hard();
            this.KeyPreview = true;
            timer2.Stop();
            timer1.Start();
        }

        //x,y의 랜덤값 및 계산부호(라벨3) 생성
        private string str1 = "";
        private void Val_x_y()
        {
            Random random = new Random();
            lb_x.Text = random.Next(0, 10).ToString();
            lb_y.Text = random.Next(0, 10).ToString();

            int x = int.Parse(lb_x.Text);//라벨 x값
            int y = int.Parse(lb_y.Text);//라벨 y값
            int z = random.Next(0, 5);
            int sum = 0;

            //계산 부호 랜덤 발생
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = z;
            }
            if (arr[0] == 0)
                label3.Text = "+";
            else if (arr[1] == 1)
                label3.Text = "-";
            else if (arr[2] == 2)
                label3.Text = "*";
            else if (arr[3] == 3)
                label3.Text = "+";
            else
                label3.Text = "-";

            //포함된 수식에 따라 계산값 발생
            switch (label3.Text)
            {
                case "+":
                    sum = x + y;
                    str1 = sum.ToString();
                    break;
                case "-":
                    sum = x - y;
                    str1 = sum.ToString();
                    break;

                case "*":
                    sum = x * y;
                    str1 = sum.ToString();
                    break;
            }
            //MessageBox.Show(lb_Result.Text, str1.ToString());          
        }

        //(=) 버튼 실행, 실행순서가 중요
        private void btn_Result_Click(object sender, EventArgs e)
        {
            if (lb_Result.Text == str1)
            {
                IScore += 10;
                label1.Text = IScore.ToString();
                Random_Btn();
                lb_Result.Text = string.Empty;
            }
            else
            {
                IScore -= 5;
                label1.Text = IScore.ToString();
                lb_Result.Text = string.Empty;
            }
            Val_x_y();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //각 버튼 Text 숫자 lb_Result에 출력
        string str = "";
        private void btn_Number_0_Click(object sender, EventArgs e)
        {
            str = btn_Number_0.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_1_Click(object sender, EventArgs e)
        {
            str = btn_Number_1.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_2_Click(object sender, EventArgs e)
        {
            str = btn_Number_2.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_3_Click(object sender, EventArgs e)
        {
            str = btn_Number_3.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_4_Click(object sender, EventArgs e)
        {
            str = btn_Number_4.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_5_Click(object sender, EventArgs e)
        {
            str = btn_Number_5.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_6_Click(object sender, EventArgs e)
        {
            str = btn_Number_6.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_7_Click(object sender, EventArgs e)
        {
            str = btn_Number_7.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_8_Click(object sender, EventArgs e)
        {
            str = btn_Number_8.Text;
            lb_Result.Text += str;
        }

        private void btn_Number_9_Click(object sender, EventArgs e)
        {
            str = btn_Number_9.Text;
            lb_Result.Text += str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = button1.Text;
            lb_Result.Text += str;
        }

        //타이머1 시작되면(3,2,1카운트 초기화, 프로그래스바 값++, 게임종료 안내문자)  
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Sec.Text = string.Empty;
            labelProgressBar1.Value--;


            if (double.Parse(labelProgressBar1.CustomText) > 10.0)
            {
                labelProgressBar1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar1.CustomText) - 0.1);
            }
            else
            {
                labelProgressBar1.TextColor = Color.White;
                labelProgressBar1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar1.CustomText) - 0.1);
            }

            if (labelProgressBar1.Value == 0)
            {
                timer1.Stop();

                foreach (Control control in this.Controls)
                {
                    control.Visible = false;
                }

                lb_Plushard_lastscore.Text = "score : " + label1.Text;
                lb_Plushard_lastscore.Enabled = true;
                lb_Plushard_lastscore.Visible = true;
                btn_Plushard_ok.Enabled = true;
                btn_Plushard_ok.Visible = true;
                //Clear();
            }

        }
        //타이머2 시작(3,2,1카운트 시작, START위치값, 타이머1 실행)
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                lb_Sec.Text = count.ToString();
                count--;
            }
            else
            {
                lb_Sec.Location = new Point(100, 120);
                lb_Sec.Text = "START";
                Key_true();

                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }

                lb_Plushard_lastscore.Visible = false;
                lb_Sec.Visible = false;// 3,2,1 안보이기
                btn_Plushard_ok.Visible = false; //확인 안보이기
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void btn_Plushard_ok_Click(object sender, EventArgs e)
        {
            plushard_score = label1.Text;
            ////델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            //this.FormSendEvent(plushard_score.ToString());

            this.Close();
        }
    }
}
