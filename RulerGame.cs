using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Moble
{
    public partial class RulerGame : Form
    {
        public int totalscore;
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public RulerGame()
        {
            InitializeComponent();

            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;

            pictureBox1.Size = new Size(60, 280);
            pictureBox1.Location = new Point(195, y);

            lb_Countdown.BackColor = Color.Transparent;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        }
        public int CountDown = 4;
        public int Random_CountDown;
        public static int y = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (y < 300)       // y축값이 300보다 작으면
            {
                y += 15;       // y축을 15만큼 증가시키면서 이동
            }
            else if (y == 300)   // y축이 300이면
            {
                timer1.Stop();      //게임종료
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                label1.Text = "0";



            }
            pictureBox1.Location = new Point(195, y);

        }


        private void RulerGame_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)     // SpaceBar를 누를 때
            {
                if (y == 300 || y == 0)     // y축이 300이거나 0이면 0점 처리
                {

                    label1.Text = "0";



                }
                else            // 300점 만점에서 y축 이동거리를 빼서 점수 계산
                {
                    label1.Text = (300 - y).ToString();

                }

                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();

                btn_Result.Visible = true;

                y = 0;



            }
            else
            {
                MessageBox.Show("스페이스바를 누르세요!!");
            }

        }





        private void RulerGame_Load(object sender, EventArgs e)
        {


            RulerGame rulerGame = new RulerGame();
            rulerGame.Size = new Size(500, 700);

            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(count_down);        // 게임시작 전 3, 2, 1, START 설정
            timer2.Interval = 750;
            timer2.Start();

            timer3 = new System.Windows.Forms.Timer();
            timer3.Tick += new EventHandler(Ramdom_Start);      // 자가 나오는 시간을 랜덤하게 설정
            timer3.Interval = 1000;


            Random random = new Random();
            Random_CountDown = random.Next(1, 10);

            btn_Result.Visible = false;

        }


        private void count_down(object sender, EventArgs e)
        {

            if (CountDown == 0)
            {
                lbStart.Text = string.Empty;
                lb_Countdown.Text = string.Empty;
                timer3.Start();           // 자가 랜덤하게 나오는 시간을 동작시키는 타이머
                timer4.Start();           // 게임시간을 알리는 프로그래스바 타이머
                timer4.Interval = 100;
            }
            else if (CountDown == 1)
            {
                lb_Countdown.Text = string.Empty;
                lbStart.Text = "START!!";

                CountDown--;
            }
            else if (CountDown > 1)
            {
                CountDown--;
                lb_Countdown.Text = CountDown.ToString();

            }
        }
        private void Ramdom_Start(object sender, EventArgs e)
        {

            if (Random_CountDown == 0)
            {
                timer1.Start();
            }
            else if (Random_CountDown > 0)
            {
                Random_CountDown--;
            }
        }

        //  프로그래스바 타이머
        private void timer4_Tick(object sender, EventArgs e)
        {
            // 프로그래스바의 Value가 0보다 클때만 동작(게임이 끝날 때에도 동작하는것을 방지)
            if (labelProgressBar1.Value > 0)
            {
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



            }
            else if (labelProgressBar1.Value == 0)
            {
                y = 0;
            }
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            totalscore = int.Parse(label1.Text);
            //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            this.FormSendEvent(totalscore.ToString());
            this.Close();
        }
    }
}
