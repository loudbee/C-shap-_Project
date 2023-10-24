using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;

namespace Moble
{
    public partial class Piano : Form
    {
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        ImageList gameimage = new ImageList();
        Random random = new Random();
        public int[] do2 = new int[24];
        public int[] re2 = new int[24];
        public int[] mi2 = new int[24];
        public int[] pa2 = new int[24];
        public int[] sol2 = new int[24];
        public int num = 0;
        public int count = 0;
        public string piano_score = string.Empty;

        public void arrclear() //눌린 버튼의 인덱스 초기화
        {
            this.do2 = new int[24];
            this.re2 = new int[24];
            this.mi2 = new int[24];
            this.pa2 = new int[24];
            this.sol2 = new int[24];
        }
        public void gameimage_reset() //gameimage 크기 설정
        {
            gameimage.ImageSize = new Size(70, 70);
            gameimage.Images.Add(pictureBox1.Image);
            gameimage.Images.Add(pictureBox2.Image);
            gameimage.Images.Add(pictureBox3.Image);
            gameimage.Images.Add(pictureBox4.Image);
            gameimage.Images.Add(pictureBox5.Image);
            gameimage.Images.Add(pictureBox6.Image);
            gameimage.Images.Add(pictureBox7.Image);
            gameimage.Images.Add(pictureBox8.Image);
            gameimage.Images.Add(pictureBox9.Image);
            gameimage.Images.Add(pictureBox10.Image);
            gameimage.Images.Add(pictureBox11.Image);
            gameimage.Images.Add(pictureBox12.Image);
            gameimage.Images.Add(pictureBox13.Image);
            gameimage.Images.Add(pictureBox14.Image);
            gameimage.Images.Add(pictureBox15.Image);
            gameimage.Images.Add(pictureBox16.Image);
            gameimage.Images.Add(pictureBox17.Image);
            gameimage.Images.Add(pictureBox18.Image);
            gameimage.Images.Add(pictureBox19.Image);
            gameimage.Images.Add(pictureBox20.Image);
            gameimage.Images.Add(pictureBox21.Image);
            gameimage.Images.Add(pictureBox22.Image);
            gameimage.Images.Add(pictureBox23.Image);
            gameimage.Images.Add(pictureBox24.Image);
        }
        public void picture_input() //사진 랜덤배정
        {
            for (int i = 0; i < gameimage.Images.Count; i++)
            {
                num = random.Next(0, 5);
                if (num == 0)
                {
                    gameimage.Images[i] = imageList1.Images[0];
                    do2[i] = 1; //gameimage리스트에 도가 들어가고 도가 들어간 인덱스 번호에 1값을 저장.
                }
                else if (num == 1)
                {
                    gameimage.Images[i] = imageList1.Images[1];
                    re2[i] = 2;

                }
                else if (num == 2)
                {
                    gameimage.Images[i] = imageList1.Images[2];
                    mi2[i] = 3;
                }
                else if (num == 3)
                {
                    gameimage.Images[i] = imageList1.Images[3];
                    pa2[i] = 4;
                }
                else if (num == 4)
                {
                    gameimage.Images[i] = imageList1.Images[4];
                    sol2[i] = 5;
                }
            }
            List<PictureBox> list = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
            pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21,
            pictureBox22, pictureBox23, pictureBox24};

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Image = gameimage.Images[i];
            }
        }
        public void result(PictureBox pb, int btn) //버튼 입력에 따른 점수계산(+5,-5) 및 사진 변경. 
        {
            for (int i = 0; i < gameimage.Images.Count; i++)
            {
                if (count == i + 1)
                {
                    if (do2[i] == 1)
                    {
                        if (btn == 1)
                        {
                            pb.Image = imageList2.Images[0];
                            lb_Score.Text = (int.Parse(lb_Score.Text) + 5).ToString();
                        }
                        else
                        {
                            count--;
                            lb_Score.Text = (int.Parse(lb_Score.Text) - 5).ToString();
                        }
                    }
                    else if (re2[i] == 2)
                    {
                        if (btn == 2)
                        {
                            pb.Image = imageList2.Images[1];
                            lb_Score.Text = (int.Parse(lb_Score.Text) + 5).ToString();
                        }
                        else
                        {
                            count--;
                            lb_Score.Text = (int.Parse(lb_Score.Text) - 5).ToString();
                        }
                    }
                    else if (mi2[i] == 3)
                    {
                        if (btn == 3)
                        {
                            pb.Image = imageList2.Images[2];
                            lb_Score.Text = (int.Parse(lb_Score.Text) + 5).ToString();
                        }
                        else
                        {
                            count--;
                            lb_Score.Text = (int.Parse(lb_Score.Text) - 5).ToString();
                        }
                    }
                    else if (pa2[i] == 4)
                    {
                        if (btn == 4)
                        {
                            pb.Image = imageList2.Images[3];
                            lb_Score.Text = (int.Parse(lb_Score.Text) + 5).ToString();
                        }
                        else
                        {
                            count--;
                            lb_Score.Text = (int.Parse(lb_Score.Text) - 5).ToString();
                        }
                    }
                    else if (sol2[i] == 5)
                    {
                        if (btn == 5)
                        {
                            pb.Image = imageList2.Images[4];
                            lb_Score.Text = (int.Parse(lb_Score.Text) + 5).ToString();
                        }
                        else
                        {
                            count--;
                            lb_Score.Text = (int.Parse(lb_Score.Text) - 5).ToString();
                        }
                    }
                }
            }
        }
        public void count_result(int btn) //버튼 누른 횟수 위치의 사진 변경
        {
            lb_Score.Location = new Point(190, 35);
            if (count == 1)
                result(pictureBox1, btn);
            else if (count == 2)
                result(pictureBox2, btn);
            else if (count == 3)
                result(pictureBox3, btn);
            else if (count == 4)
                result(pictureBox4, btn);
            else if (count == 5)
                result(pictureBox5, btn);
            else if (count == 6)
                result(pictureBox6, btn);
            else if (count == 7)
                result(pictureBox7, btn);
            else if (count == 8)
                result(pictureBox8, btn);
            else if (count == 9)
                result(pictureBox9, btn);
            else if (count == 10)
                result(pictureBox10, btn);
            else if (count == 11)
                result(pictureBox11, btn);
            else if (count == 12)
                result(pictureBox12, btn);
            else if (count == 13)
                result(pictureBox13, btn);
            else if (count == 14)
                result(pictureBox14, btn);
            else if (count == 15)
                result(pictureBox15, btn);
            else if (count == 16)
                result(pictureBox16, btn);
            else if (count == 17)
                result(pictureBox17, btn);
            else if (count == 18)
                result(pictureBox18, btn);
            else if (count == 19)
                result(pictureBox19, btn);
            else if (count == 20)
                result(pictureBox20, btn);
            else if (count == 21)
                result(pictureBox21, btn);
            else if (count == 22)
                result(pictureBox22, btn);
            else if (count == 23)
                result(pictureBox23, btn);
            else if (count == 24)
            {
                result(pictureBox24, btn);
                count = 0;
                arrclear();
                List<PictureBox> list = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
            pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21,
            pictureBox22, pictureBox23, pictureBox24};
                for (int i = 0; i < list.Count; i++)
                {
                    gameimage.Images[i] = list[i].Image;
                }
                picture_input();
            }
        }
        public Piano() //Piano 시작
        {
            InitializeComponent();

            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;


            //픽쳐박스 리스트 생성
            List<PictureBox> list = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
            pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21,
            pictureBox22, pictureBox23, pictureBox24};

            //모든 픽쳐박스의 값 안보이기
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Visible = false;
            }

            //score = lb_Score.Text;
            labelProgressBar_Piano1.CustomText = "20.0";
            labelProgressBar_Piano1.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gameimage_reset();
            picture_input();
            timer2.Start();
            lb_Score.Location = new Point(220, 35);
            lb_Start.Text = "  3  ";
        }

        private void btn_Do_Click(object sender, EventArgs e) //도 버튼 눌릴 시
        {
            int btnDo = 1;
            count++;
            count_result(btnDo);
            btn_Do.BackColor = Color.Yellow;
        }
        private void btn_Re_Click(object sender, EventArgs e) //레 버튼 눌릴 시
        {
            int btnRe = 2;
            count++;
            count_result(btnRe);
            btn_Re.BackColor = Color.Yellow;
        }
        private void btn_Mi_Click(object sender, EventArgs e) //미 버튼 눌릴 시
        {
            int btnMi = 3;
            count++;
            count_result(btnMi);
            btn_Mi.BackColor = Color.Yellow;
        }
        private void btn_Pa_Click(object sender, EventArgs e) //파 버튼 눌릴 시
        {
            int btnPa = 4;
            count++;
            count_result(btnPa);
            btn_Pa.BackColor = Color.Yellow;
        }
        private void btn_Sol_Click(object sender, EventArgs e) //솔 버튼 눌릴 시
        {
            int btnSol = 5;
            count++;
            count_result(btnSol);
            btn_Sol.BackColor = Color.Yellow;
        }

        private void timer1_Tick(object sender, EventArgs e) //게임 시작 후의 남은 시간.
        {
            //픽쳐박스 리스트 생성
            List<PictureBox> list = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
            pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21,
            pictureBox22, pictureBox23, pictureBox24};

            //모든 픽쳐박스의 값 보이기
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Visible = true;
            }

            btn_Do.BackColor = Color.White;
            btn_Re.BackColor = Color.White;
            btn_Mi.BackColor = Color.White;
            btn_Pa.BackColor = Color.White;
            btn_Sol.BackColor = Color.White;
            labelProgressBar_Piano1.Value--;
            //score = lb_Score.Text;

            if (double.Parse(labelProgressBar_Piano1.CustomText) > 10.0)
            {
                labelProgressBar_Piano1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar_Piano1.CustomText) - 0.1);
            }
            else
            {
                labelProgressBar_Piano1.TextColor = Color.White;
                labelProgressBar_Piano1.CustomText = string.Format("{0:f1}", double.Parse(labelProgressBar_Piano1.CustomText) - 0.1);

            }

            if ((labelProgressBar_Piano1.Value == 0) && (labelProgressBar_Piano1.CustomText == "0.0"))
            {
                timer1.Stop();
                lb_Piano_lastscore.Text = "score : " + lb_Score.Text;
                btn_Do.Enabled = false;
                btn_Re.Enabled = false;
                btn_Mi.Enabled = false;
                btn_Pa.Enabled = false;
                btn_Sol.Enabled = false;
                lb_Piano_lastscore.Enabled = true;
                lb_Piano_lastscore.Visible = true;
                btn_Piano_ok.Enabled = true;
                btn_Piano_ok.Visible = true;

                List<PictureBox> pblist = new List<PictureBox>() {  pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21,
pictureBox22, pictureBox23, pictureBox24,};
                for (int i = 0; i < pblist.Count; i++)
                {
                    pblist[i].Visible = false;
                }
                lb_Score.Visible = false;
                label2.Visible = false;
                labelProgressBar_Piano1.Visible = false;

                btn_Do.Visible = false;
                btn_Re.Visible = false;
                btn_Mi.Visible = false;
                btn_Pa.Visible = false;
                btn_Sol.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
        }
        int time = 0;
        private void timer2_Tick(object sender, EventArgs e) //게임 시작전 카운트 시간.
        {
            time++;
            if (time == 1)
                lb_Start.Text = "  2  ";
            if (time == 2)
                lb_Start.Text = "  1  ";
            if (time == 3)
            {
                lb_Start.Location = new Point(5, 160);
                lb_Start.Text = "Start";
            }
            if (time == 4)
            {
                lb_Start.Text = "";
                timer2.Stop();
                timer1.Start();
                btn_Do.Enabled = true;
                btn_Re.Enabled = true;
                btn_Mi.Enabled = true;
                btn_Pa.Enabled = true;
                btn_Sol.Enabled = true;
            }
        }

        private void btn_Piano_ok_Click(object sender, EventArgs e)
        {
            piano_score = lb_Score.Text;
            ////델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            //this.FormSendEvent(piano_score.ToString());
            this.Close();
        }
    }
}
