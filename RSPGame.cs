using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gandi
{
    public partial class RSPGame : Form
    {
        int picNum;
        public int totalScore;
        int remainingSeconds;
        int win;
        int loose;
        int draw;



        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public RSPGame()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            proBar.CustomText = "20.0";
            picNum = 0;
            totalScore = 0;
            win = 0; draw = 0; loose = 0;
            lbscore.Text = " 0";
            lbCheck.Text = "";

            button1.Visible = false;

            lbEndScore.Visible = false;

            lbCheck.Location = new Point(156, 469);

            remainingSeconds = 4;
            timer2.Interval = 1000; // 1초마다 타이머 이벤트 발생
            timer2.Tick += timer2_Tick;


            timer2.Start();

            Qvalue();

        }

        private void Qvalue()
        {
            Random random = new Random();


            int i = random.Next(0, 3);

            if (i == 0)
            {
                picNum = 0;
                picQ1.Visible = true;
                picQ2.Visible = false;
                picQ3.Visible = false;
            }
            if (i == 1)
            {
                picNum = 1;
                picQ1.Visible = false;
                picQ2.Visible = true;
                picQ3.Visible = false;
            }
            if (i == 2)
            {
                picNum = 2;
                picQ1.Visible = false;
                picQ2.Visible = false;
                picQ3.Visible = true;
            }
        }

        private void picRock_Click(object sender, EventArgs e) // 0 - 바위 , 1 - 가위 , 2 - 보
        {
            if (picNum == 0)
            {
                draw++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;

            }
            else if (picNum == 1)
            {
                win++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
                totalScore += 10;
            }
            else if (picNum == 2)
            {
                loose++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
                totalScore -= 5;
            }

            lbscore.Text = totalScore.ToString();

            Qvalue();
        }

        private void picSci_Click(object sender, EventArgs e)
        {
            if (picNum == 0)
            {
                loose++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
                totalScore -= 5;

            }
            else if (picNum == 1)
            {
                draw++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
            }
            else if (picNum == 2)
            {
                win++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
                totalScore += 10;
            }

            lbscore.Text = totalScore.ToString();
            Qvalue();
        }

        private void picPaper_Click(object sender, EventArgs e)
        {
            if (picNum == 0)
            {
                win++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
                totalScore += 10;
            }
            else if (picNum == 1)
            {
                loose++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
                totalScore -= 5;
            }
            else if (picNum == 2)
            {
                draw++;
                lbCheck.Text = "승 : " + win + " 무 : " + draw + " 패 : " + loose;
            }

            lbscore.Text = totalScore.ToString();
            Qvalue();

        }

        void pic_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbcnt.Visible = false;
            proBar.Value--;
            EnableControls(true);


            if (double.Parse(proBar.CustomText) > 10.0)
            {
                proBar.CustomText = string.Format("{0:f1}", double.Parse(proBar.CustomText) - 0.1);
            }
            else
            {
                proBar.TextColor = Color.White;
                proBar.CustomText = string.Format("{0:f1}", double.Parse(proBar.CustomText) - 0.1);
            }


            if (proBar.Value == 0)
            {
                timer1.Stop();

                lbEndScore.Location = new Point(58, 257);
                lbEndScore.Text = "score : " + totalScore.ToString();

                lbEndScore.Visible = true;

                picQ1.Visible = false;
                picQ2.Visible = false;
                picQ3.Visible = false;
                picPaper.Visible = false;
                picRock.Visible = false;
                picSci.Visible = false;
                lbCheck.Visible = false;

                button1.Visible = true;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            EnableControls(false);
            remainingSeconds--;

            if (remainingSeconds > 0)
            {
                // 남은 시간을 라벨에 출력
                lbcnt.Text = remainingSeconds.ToString();
            }
            else
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void EnableControls(bool enable)
        {
            // 폼의 모든 컨트롤을 활성화 또는 비활성화합니다.
            foreach (Control control in this.Controls)
            {
                control.Enabled = enable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            this.FormSendEvent(totalScore.ToString());

            this.Close();
        }
    }
}
