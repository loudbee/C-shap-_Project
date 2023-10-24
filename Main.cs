using Gandi;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moble
{
    public partial class Main : Form
    {

        int total_score;
        List<St> ids = new List<St>();


        public struct St
        {
            public string id;
            public int score;
        }

        NumGame numGame;

        public Main()
        {
            InitializeComponent();

            lb_R1_score.Visible = false;
            lb_R2_score.Visible = false;
            lb_R3_score.Visible = false;


        }
        //각 게임 연결버튼

        // 피아노 노말
        private void btn_Pi_Click(object sender, EventArgs e)
        {
            //btn_Piano_Click -- 피아노
            Piano form1 = new Piano();
            form1.ShowDialog();
            total_score += int.Parse(form1.piano_score);
            lb_total_score.Text = total_score.ToString();

        }

        // 더하기 노말
        private void btn_The_Click(object sender, EventArgs e)
        {
            //btn_Plus_Click -- 더하기
            Plus form1 = new Plus();
            form1.ShowDialog();
            total_score += int.Parse(form1.plus_score);
            lb_total_score.Text = total_score.ToString();


        }

        // 순서대로 노말 
        private void btn_Soon_Click(object sender, EventArgs e)
        {
            //버튼을 클릭하면 폼2를 연다.
            NumGame form1 = new NumGame();
            //폼 2에 이벤트를 달아둔다..
            form1.FormSendEvent += new NumGame.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();

        }


        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call

        }



        // 좌로우로 노말
        private void btn_Joa_Click(object sender, EventArgs e)
        {
            LeftRight_N form1 = new LeftRight_N();
            //label4.Text = form1.Tsp_score.ToString();
            ////폼 2에 이벤트를 달아둔다..
            form1.FormSendEvent += new LeftRight_N.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();

        }

        // 같은그림 노말
        private void btn_Same_Click(object sender, EventArgs e)
        {
            TSP form1 = new TSP();
            //label4.Text = form1.Tsp_score.ToString();
            ////폼 2에 이벤트를 달아둔다.
            form1.FormSendEvent += new TSP.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        // 방향키 노말
        private void btn_Bang_Click(object sender, EventArgs e)
        {
            ArrowKeyGame form1 = new ArrowKeyGame();
            form1.FormSendEvent += new ArrowKeyGame.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        // 부비부비 노말
        private void btn_Bu_Click(object sender, EventArgs e)
        {
            Bubibubi form1 = new Bubibubi();
            form1.FormSendEvent += new Bubibubi.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        // 가위바위보 노말 완료 
        private void btn_Ga_Click(object sender, EventArgs e)
        {
            //버튼을 클릭하면 폼2를 연다.
            RSPGame form2 = new RSPGame();
            //폼 2에 이벤트를 달아둔다..
            form2.FormSendEvent += new RSPGame.FormSendDataHandler(DieaseUpdateEventMethod);
            form2.ShowDialog();

            total_score += form2.totalScore;
            lb_total_score.Text = total_score.ToString();

        }

        // 자 노말
        private void btn_Ja_Click(object sender, EventArgs e)
        {
            RulerGame form2 = new RulerGame();
            //폼 2에 이벤트를 달아둔다..
            form2.FormSendEvent += new RulerGame.FormSendDataHandler(DieaseUpdateEventMethod);
            form2.ShowDialog();

            total_score += form2.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        //각 게임 좋아요 개수
        private void btn_PiLike_Click(object sender, EventArgs e)
        {
            lb_PiLike.Text = (int.Parse(lb_PiLike.Text) + 1).ToString();
        }
        private void btn_TheLike_Click(object sender, EventArgs e)
        {
            lb_TheLike.Text = (int.Parse(lb_TheLike.Text) + 1).ToString();
        }
        private void btn_SoonLike_Click(object sender, EventArgs e)
        {
            lb_SoonLike.Text = (int.Parse(lb_SoonLike.Text) + 1).ToString();
        }
        private void btn_JoaLike_Click(object sender, EventArgs e)
        {
            lb_JoaLike.Text = (int.Parse(lb_JoaLike.Text) + 1).ToString();
        }
        private void btn_SameLike_Click(object sender, EventArgs e)
        {
            lb_SameLike.Text = (int.Parse(lb_SameLike.Text) + 1).ToString();
        }
        private void btn_BangLike_Click(object sender, EventArgs e)
        {
            lb_BangLike.Text = (int.Parse(lb_BangLike.Text) + 1).ToString();
        }
        private void btn_BuLike_Click(object sender, EventArgs e)
        {
            lb_BuLike.Text = (int.Parse(lb_BuLike.Text) + 1).ToString();
        }
        private void btn_GaLike_Click(object sender, EventArgs e)
        {
            lb_GaLike.Text = (int.Parse(lb_JaLike.Text) + 1).ToString();
        }
        private void btn_JaLike_Click(object sender, EventArgs e)
        {
            lb_JaLike.Text = (int.Parse(lb_JaLike.Text) + 1).ToString();
        }



        // 더하기 하드
        private void btn_pl_h_Click(object sender, EventArgs e)
        {
            //btn_Piano_hard_Click -- 더하기 하드
            Plus_hard form1 = new Plus_hard();
            form1.ShowDialog();
            total_score += int.Parse(form1.plushard_score);
            lb_total_score.Text = total_score.ToString();

        }

        // 같은그림 하드
        private void btn_same_h_Click(object sender, EventArgs e)
        {
            //버튼을 클릭하면 폼2를 연다.
            Tsp_hard form2 = new Tsp_hard();
            //폼 2에 이벤트를 달아둔다..
            form2.FormSendEvent += new Tsp_hard.FormSendDataHandler(DieaseUpdateEventMethod);
            form2.ShowDialog();

            total_score += form2.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        // 방향키 하드
        private void btn_arr_h_Click(object sender, EventArgs e)
        {
            ArrowKeyGame_Hard form1 = new ArrowKeyGame_Hard();
            form1.FormSendEvent += new ArrowKeyGame_Hard.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        // 피아노 하드
        private void btn_pi_h_Click(object sender, EventArgs e)
        {
            //btn_Piano_hard_Click -- 피아노 하드
            Piano_hard form1 = new Piano_hard();
            form1.ShowDialog();
            total_score += int.Parse(form1.pianohard_score);
            lb_total_score.Text = total_score.ToString();

        }


        // 등록버튼
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if ((lb_Rank1.Text == textBox1.Text) || (lb_Rank2.Text == textBox1.Text) || (lb_Rank3.Text == textBox1.Text))
                {
                    MessageBox.Show("등록할 수 없습니다.");
                }
                else
                {
                    if (int.Parse(lb_R1_score.Text) < total_score)
                    {
                        if (lb_R1_score.Text == "0")
                        {
                            lb_R1_score.Visible = true;
                            lb_R1_score.Text = lb_total_score.Text;
                            lb_Rank1.Text = textBox1.Text;
                        }
                        else
                        {
                            lb_R2_score.Visible = true;
                            if(lb_R3_score.Text != "0")
                                lb_R3_score.Visible = true;
                            lb_R3_score.Text = lb_R2_score.Text;
                            lb_Rank3.Text = lb_Rank2.Text;
                            lb_R2_score.Text = lb_R1_score.Text;
                            lb_Rank2.Text = lb_Rank1.Text;
                            lb_R1_score.Text = lb_total_score.Text;
                            lb_Rank1.Text = textBox1.Text;
                        }
                    }
                    else if (int.Parse(lb_R2_score.Text) < total_score)
                    {
                        if (lb_R2_score.Text == "0")
                        {
                            lb_R2_score.Visible = true;
                            lb_R2_score.Text = lb_total_score.Text;
                            lb_Rank2.Text = textBox1.Text;
                        }
                        else
                        {
                            lb_R3_score.Visible = true;

                            lb_R3_score.Text = lb_R2_score.Text;
                            lb_Rank3.Text = lb_Rank2.Text;
                            lb_R2_score.Text = lb_total_score.Text;
                            lb_Rank2.Text = textBox1.Text;
                        }
                    }
                    else if (int.Parse(lb_R3_score.Text) < total_score)
                    {
                        if (lb_R3_score.Text == "0")
                        {
                            lb_R3_score.Visible = true;
                            lb_R3_score.Text = lb_total_score.Text;
                            lb_Rank3.Text = textBox1.Text;
                        }
                        else
                        {
                            lb_R3_score.Text = lb_total_score.Text;
                            lb_Rank3.Text = textBox1.Text;
                        }
                    }
                    total_score = 0;
                    lb_total_score.Text = "score";
                }
            }
            textBox1.Clear();

        }

        // 하드 좌로우로
        private void btn_left_h_Click(object sender, EventArgs e)
        {
            LeftRight_H form1 = new LeftRight_H();
            form1.FormSendEvent += new LeftRight_H.FormSendDataHandler(DieaseUpdateEventMethod);
            form1.ShowDialog();

            total_score += form1.totalscore;
            lb_total_score.Text = total_score.ToString();
        }

        private void btn_PHLike_Click(object sender, EventArgs e)
        {
            lb_PiH.Text = (int.Parse(lb_PiH.Text) + 1).ToString();
        }

        private void btn_CalHLike_Click(object sender, EventArgs e)
        {
            lb_CalH.Text = (int.Parse(lb_CalH.Text) + 1).ToString();
        }

        private void btn_JauHLike_Click(object sender, EventArgs e)
        {
            lb_JuaH.Text = (int.Parse(lb_JuaH.Text) + 1).ToString();
        }

        private void btn_SameHLike_Click(object sender, EventArgs e)
        {
            lb_sameH.Text = (int.Parse(lb_sameH.Text) + 1).ToString();
        }

        private void btn_BangHLike_Click(object sender, EventArgs e)
        {
            lb_bangH.Text = (int.Parse(lb_bangH.Text) + 1).ToString();
        }
    }

    public class CircularButton : System.Windows.Forms.Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
