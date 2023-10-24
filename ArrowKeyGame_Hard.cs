using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class ArrowKeyGame_Hard : Form
    {
        public int totalscore;
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        public ArrowKeyGame_Hard()
        {

            InitializeComponent();
            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;

            timer2.Enabled = false;

            labelProgressBar1.TextColor = Color.RoyalBlue;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            btn_Result.Visible = false;
        }
        // 게임 시작전 카운트를 주는 변수
        public int CountDown = 4;

        // 랜덤값을 받는 변수
        public int image_num;

        //이미지의 위치값을 저장할 변수
        public string image_string = "";
        public string image1 = "";
        public string image2 = "";
        public string image3 = "";
        public string image4 = "";

        public int count = 0;

        List<string> input_key = new List<string>();


        public string check_list1 = string.Empty;
        public string check_list2 = string.Empty;
        public string check_list3 = string.Empty;
        public string check_list4 = string.Empty;

        public int Score = 0;
        public int Save_number;

        public string Arrow_Key()       // 랜덤으로 방향키의 이미지가 나오게 하는 매서드
        {

            Random random = new Random();
            image_num = random.Next(0, 4);

            switch (image_num)
            {
                // case 0: 왼쪽 방향키
                case 0:
                    image_string = "C:\\Gandi_main\\bin\\keyleft.png";
                    break;
                // case 1: 오른쪽 방향키
                case 1:
                    image_string = "C:\\Gandi_main\\bin\\keyright.png";
                    break;
                // case 2: 아래 방향키
                case 2:
                    image_string = "C:\\Gandi_main\\bin\\keydown.png";
                    break;
                // case 3: 위 방향키
                case 3:
                    image_string = "C:\\Gandi_main\\bin\\keyup.png";
                    break;
            }


            // 랜덤하게 0~3까지 숫자를 받아서 swtich문을 통해서 image_string값에 저장 후 그 string값을 리턴
            return image_string;

        }

        public void Build_Game()    // 랜덤으로 받은 주소값을 배열에 저장
        {

            // 리턴된 string(이미지의 위치값)을 4개의 string변수에 저장
            image1 = Arrow_Key();
            image2 = Arrow_Key();
            image3 = Arrow_Key();
            image4 = Arrow_Key();


            // 이미지의 위치값을 저장한 string변수를 각 picturebox에 Load시킴
            pictureBox1.Load(image1);
            pictureBox2.Load(image2);
            pictureBox3.Load(image3);
            pictureBox4.Load(image4);

        }






        //ArrowKeyGame폼이 Load할 때 timer1 시작
        private void ArrowKeyGame_Load(object sender, EventArgs e)
        {
            btn_Result.Visible = false;
            Final_Result.Visible = false;
            timer1.Interval = 750;
            timer1.Start();         // 게임 시작 전 3, 2, 1, start!를 알리는 타이머

        }







        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountDown == 0)     //timer1로 인해  CountDown이 0이 되면
            {
                lb_Countdown.Text = string.Empty;   //
                lb_Start.Text = string.Empty;       //  시간을 알리는 Label을 없애고

                timer1.Stop();                      // timer1을 멈춘다.
                timer2.Enabled = true;
                timer2.Interval = 100;


                timer4.Start();


            }
            else if (CountDown == 1)    //카운트다운이 끝난 후 start 문자를 출력
            {

                lb_Start.Text = "START!!";
                CountDown--;
            }
            else if (CountDown >= 2)        // 카운트다운 3, 2, 1을 알림
            {

                CountDown--;
                lb_Countdown.Text = CountDown.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label1.Text) >= 0 && int.Parse(label1.Text) < 10)
            {
                label1.Location = new Point(205, 45);
            }
            if ((int.Parse(label1.Text) >= 10 && int.Parse(label1.Text) < 100) || int.Parse(label1.Text) < 0)
            {
                label1.Location = new Point(195, 45);
            }
            if (int.Parse(label1.Text) >= 100 || int.Parse(label1.Text) <= -10)
            {
                label1.Location = new Point(175, 45);
            }

            if (labelProgressBar1.Value > 0)
            {
                // 프로그래스바의 Value가 0보다 클때만 동작(게임이 끝날 때에도 동작하는것을 방지)
                labelProgressBar1.Value--;


                //프로그래스바가 반이 넘어가기전 TextColor를 처음 설정값인 Black으로
                if (double.Parse(labelProgressBar1.CustomText) > 10.0)
                {

                    labelProgressBar1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar1.CustomText) - 0.1);

                }
                else ////프로그래스바가 반이 넘어가기전 TextColor를 White로
                {
                    labelProgressBar1.TextColor = Color.White;
                    labelProgressBar1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar1.CustomText) - 0.1);
                }
            }
            else
            {
                btn_Result.Visible = true;
                Final_Result.Visible = true;
                labelProgressBar2.Visible = false;
                timer2.Stop();
                timer4.Stop();
                timer5.Stop();
                timer1.Stop();
                timer3.Stop();

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;

                pb_input1.Image = null;
                pb_input2.Image = null;
                pb_input3.Image = null;
                pb_input4.Image = null;

                Final_Result.Location = new Point(60, 170);
                btn_Result.Location = new Point(150, 355);
                Final_Result.Text = "score : " + label1.Text;

                // label1.Text = string.Empty;
                label2.Text = string.Empty;
                label3.Text = string.Empty;

                label1.Visible = false;
                labelProgressBar1.Visible = false;
                labelProgressBar2.Visible = false;

                btn_Result.Visible = true;
            }

        }

        private void ArrowKeyGame_Hard_KeyDown(object sender, KeyEventArgs e)
        {
            if (CountDown == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    // 왼쪽 방향키를 입력 시
                    input_key.Add("C:\\Gandi_main\\bin\\keyleft.png");

                    if (pb_input1.Image == null)
                    {
                        //플레이어가 입력하는 방향키 이미지를 보여준다.
                        pb_input1.Load("C:\\Gandi_main\\bin\\keyleft.png");
                        check_list1 = "C:\\Gandi_main\\bin\\keyleft.png";     //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input2.Image == null)
                    {
                        pb_input2.Load("C:\\Gandi_main\\bin\\keyleft.png");

                        check_list2 = "C:\\Gandi_main\\bin\\keyleft.png";     //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input3.Image == null)
                    {
                        pb_input3.Load("C:\\Gandi_main\\bin\\keyleft.png");

                        check_list3 = "C:\\Gandi_main\\bin\\keyleft.png";     //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input4.Image == null)
                    {
                        pb_input4.Load("C:\\Gandi_main\\bin\\keyleft.png");

                        check_list4 = "C:\\Gandi_main\\bin\\keyleft.png";     //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }

                }
                if (e.KeyCode == Keys.Right)
                {
                    // 오른쪽 방향키를 입력 시
                    input_key.Add("C:\\Gandi_main\\bin\\keyright.png");
                    if (pb_input1.Image == null)
                    {
                        //플레이어가 입력하는 방향키 이미지를 보여준다.
                        pb_input1.Load("C:\\Gandi_main\\bin\\keyright.png");

                        check_list1 = "C:\\Gandi_main\\bin\\keyright.png";        //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input2.Image == null)
                    {
                        pb_input2.Load("C:\\Gandi_main\\bin\\keyright.png");

                        check_list2 = "C:\\Gandi_main\\bin\\keyright.png";        //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input3.Image == null)
                    {
                        pb_input3.Load("C:\\Gandi_main\\bin\\keyright.png");

                        check_list3 = "C:\\Gandi_main\\bin\\keyright.png";        //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input4.Image == null)
                    {
                        pb_input4.Load("C:\\Gandi_main\\bin\\keyright.png");

                        check_list4 = "C:\\Gandi_main\\bin\\keyright.png";        //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    // 아래쪽 방향키를 입력 시
                    input_key.Add("C:\\Gandi_main\\bin\\keydown.png");
                    if (pb_input1.Image == null)
                    {
                        //플레이어가 입력하는 방향키 이미지를 보여준다.
                        pb_input1.Load("C:\\Gandi_main\\bin\\keydown.png");

                        check_list1 = "C:\\Gandi_main\\bin\\keydown.png";         //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input2.Image == null)
                    {
                        pb_input2.Load("C:\\Gandi_main\\bin\\keydown.png");

                        check_list2 = "C:\\Gandi_main\\bin\\keydown.png";         //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input3.Image == null)
                    {
                        pb_input3.Load("C:\\Gandi_main\\bin\\keydown.png");

                        check_list3 = "C:\\Gandi_main\\bin\\keydown.png";         //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input4.Image == null)
                    {
                        pb_input4.Load("C:\\Gandi_main\\bin\\keydown.png");

                        check_list4 = "C:\\Gandi_main\\bin\\keydown.png";         //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }

                }
                if (e.KeyCode == Keys.Up)
                {
                    // 위쪽 방향키를 입력 시
                    input_key.Add("C:\\Gandi_main\\bin\\keyup.png");
                    if (pb_input1.Image == null)
                    {
                        pb_input1.Load("C:\\Gandi_main\\bin\\keyup.png");

                        check_list1 = "C:\\Gandi_main\\bin\\keyup.png";           //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input2.Image == null)
                    {
                        pb_input2.Load("C:\\Gandi_main\\bin\\keyup.png");

                        check_list2 = "C:\\Gandi_main\\bin\\keyup.png";           //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input3.Image == null)
                    {
                        pb_input3.Load("C:\\Gandi_main\\bin\\keyup.png");

                        check_list3 = "C:\\Gandi_main\\bin\\keyup.png";           //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                    else if (pb_input4.Image == null)
                    {
                        pb_input4.Load("C:\\Gandi_main\\bin\\keyup.png");

                        check_list4 = "C:\\Gandi_main\\bin\\keyup.png";           //랜덤하게 나오는 이미지 위치값과 비교를 하기위한 변수
                    }
                }

                if (e.KeyCode == Keys.Space)
                {

                    //무작위 이미지가 저장된 image1,2,3,4와 키보드 입력시 저장된 check_list1,2,3,4를 비교
                    // 만약 image1,2,3,4와 check_list1,2,3,4가 모두 같으면 Score에 10점을 더해준다.
                    if (image1 == check_list1 && image2 == check_list2 && image3 == check_list3 && image4 == check_list4)
                    {
                        Score += 10;
                        label1.Text = Score.ToString();
                        pb_input1.Image = null;
                        pb_input2.Image = null;
                        pb_input3.Image = null;             //
                        pb_input4.Image = null;             //
                        check_list1 = string.Empty;         //  이미지가 모두 같다면
                        check_list2 = string.Empty;         //  이미지와 비교를 한 check_list1,2,3,4를 모두 초기화
                        check_list3 = string.Empty;         //
                        check_list4 = string.Empty;


                        labelProgressBar2.Value = 85;
                        labelProgressBar2.Maximum = 85;
                        timer4.Stop();
                        timer4.Start();
                        timer5.Stop();
                        timer5.Start();

                        Build_Game();
                    }
                    else
                    {
                        //무작위 이미지가 저장된 image1,2,3,4와 키보드 입력시 저장된 check_list1,2,3,4를 비교
                        // 만약 image1,2,3,4와 check_list1,2,3,4 중 하나라도 다르면 Score에 5점을 빼준다.
                        Score -= 5;
                        label1.Text = Score.ToString();
                        pb_input1.Image = null;             //
                        pb_input2.Image = null;             //
                        pb_input3.Image = null;             //  이미지가 다르다면
                        pb_input4.Image = null;             //  이미지와 비교를 한 check_list1,2,3,4를 모두 초기화
                        check_list1 = string.Empty;         //
                        check_list2 = string.Empty;
                        check_list3 = string.Empty;
                        check_list4 = string.Empty;


                        labelProgressBar2.Value = 85;
                        labelProgressBar2.Maximum = 85;
                        timer4.Stop();
                        timer4.Start();
                        timer5.Stop();
                        timer5.Start();
                        Build_Game();
                    }

                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            labelProgressBar2.Value = 85;
            labelProgressBar2.Maximum = 85;
            timer5.Interval = 1;
            timer4.Interval = 1500;
            timer5.Start();

            Build_Game();      // 게임을 다시 불러온다.
            if (count > 0)
            {
                if (image1 != check_list1 || image2 != check_list2 || image3 != check_list3 || image4 != check_list4)
                {
                    Score -= 5;
                    label1.Text = Score.ToString();
                }
            }
            count++;



        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            if (labelProgressBar2.Value > 0)
            {

                // 프로그래스바의 Value가 0보다 클때만 동작(게임이 끝날 때에도 동작하는것을 방지)
                labelProgressBar2.Value--;


            }
            else if (labelProgressBar2.Value == 0)
            {


                timer5.Stop();
                timer5.Start();




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

