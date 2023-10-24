using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class Tsp_hard : Form
    {
        public int totalscore;
        //델리게이트 선언
        public delegate void FormSendDataHandler(string sendstring);
        //이벤트 생성
        public event FormSendDataHandler FormSendEvent;

        //전역 변수 선언
        static int timercnt = 3;
        static int cnt1 = 0;
        static int cnt2 = 0;
        static int cnt3 = 0;
        static int cnt4 = 0;
        static int cnt5 = 0;
        static int cnt6 = 0;
        static int cnt7 = 0;
        static int cnt8 = 0;
        static int roopcnt = 1;

        //태그값 받는 정수 배열
        int[] Last_click = new int[2];

        //전역 랜덤 생성자 선언
        Random Random = new Random();

        //전역 리스트 생성자 선언
        List<Image> old_images_Tsp = new List<Image>();
        List<int> num_Tsp = new List<int>();

        //이미지 태그에 들어갈 태그값 배열;
        static int[] num_cnt = { 1, 2, 3, 4, 5, 6, 7, 8 };

        private List<PictureBox> CrlMethod()
        {
            //초기화
            cnt1 = 0;
            cnt2 = 0;
            cnt3 = 0;
            cnt4 = 0;
            cnt5 = 0;
            cnt6 = 0;
            cnt7 = 0;
            cnt8 = 0;
            old_images_Tsp.Clear();
            num_Tsp.Clear();

            //픽쳐박스 리스트선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard1, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };
            return picture;
        }

        public Tsp_hard()
        {
            //Roopcnt초기화
            roopcnt = 1;

            InitializeComponent();

            // 폼 시작할 때 스크린의 중앙에
            this.StartPosition = FormStartPosition.CenterScreen;

            //스코어 값 초기화
            lb_TspScore.Text = "   0";

            //최종스코어 안보이기
            lb_Tsphard_lastscore.Enabled = false;
            lb_Tsphard_lastscore.Visible = false;


            //확인버튼 안보이기
            btn_Tsphard_ok.Enabled = false;
            btn_Tsphard_ok.Visible = false;

            //프로그래스바 라벨 초기화값
            progressbar_Tsphard.CustomText = "30.0";

            //프로그래스바 라벨 텍스트 크기
            progressbar_Tsphard.TextFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            //시작 시간 3초
            Tsphard_Start_Timer.Start();
        }

        //픽쳐박스 확인해서 제거하는 메소드
        private void recheckMethod(List<PictureBox> picture)
        {
            //마지막 클릭이 먼지 확인
            if (Last_click[0] == 0)
            {
                Last_click[0] = (int)picture[0].Tag;
                return;
            }
            //두번째 클릭이 먼지 확인
            else if ((Last_click[0] != 0) && (Last_click[1] == 0))
            {
                Last_click[1] = (int)picture[0].Tag;

                //첫번째와 두번째가 같으면 실행
                if (Last_click[0] == Last_click[1])
                {
                    lb_TspScore.Text = (int.Parse(lb_TspScore.Text) + 30).ToString();
                    picture[0].Image = null;
                    picture[0].Enabled = false;

                    for (int i = 1; i < picture.Count; i++)
                    {
                        if (Last_click[0] == (int)picture[i].Tag)
                        {
                            picture[i].Image = null;
                            picture[i].Enabled = false;
                        }
                    }
                }
                //첫번째와 두번째가 다르면 실행
                else
                {
                    //그림보여주기위해 false로 바꿈
                    picture[0].Enabled = false;

                    //점수 감소
                    lb_TspScore.Text = (int.Parse(lb_TspScore.Text) - 10).ToString();

                    //딜레이용
                    Thread.Sleep(100);

                    //그림 뒷면으로 돌리기위해 true로 바꿈
                    picture[0].Enabled = true;

                    for (int i = 0; i < picture.Count; i++)
                    {
                        if (picture[i].Enabled == true)
                        {
                            picture[i].Image = Tsphard_imageList.Images[0];
                        }
                    }
                }
                //값 초기화
                Last_click[0] = 0;
                Last_click[1] = 0;

                //카드 초기화
                if (picture[0].Enabled == false && picture[1].Enabled == false && picture[2].Enabled == false
                    && picture[3].Enabled == false && picture[4].Enabled == false && picture[5].Enabled == false
                    && picture[6].Enabled == false && picture[7].Enabled == false && picture[8].Enabled == false
                    && picture[9].Enabled == false && picture[10].Enabled == false && picture[11].Enabled == false
                    && picture[12].Enabled == false && picture[13].Enabled == false
                    && picture[14].Enabled == false && picture[15].Enabled == false)
                {
                    Tsphard_timer2.Stop();
                    if (roopcnt == 0)
                    {
                        Roop2();
                    }
                    else if (roopcnt == 1)
                    {
                        Roop1();
                    }
                    else if (roopcnt == 2)
                    {
                        Roop3();
                    }
                }
            }
        }

        //이미지 바뀌는 루프메서드 생성
        private void Roop1()
        {
            //순서반복 카운트
            roopcnt = 2;

            //초기화값 메소드
            List<PictureBox> picture = CrlMethod();

            //picturebox의 이미지 2개씩 넣어줌
            for (int i = 0; i < 16; i++)
            {
                //클릭 가능하게 값줌
                picture[i].Enabled = true;

                //랜덤하게 값줌
                num_Tsp.Add(Random.Next(9, 17));

                //null값이면 계속 돌면서 값을 넣어서 2개이상 안되게 만듬
                while (picture[i].Image == null)
                {
                    //이미지 랜덤하게 넣기
                    picture[i].Image = Tsphard_imageList.Images[num_Tsp[i]];

                    if (num_Tsp[i] == 9 && cnt1 < 2)
                    {
                        cnt1 += 1;
                        picture[i].Tag = num_cnt[0];
                    }
                    else if (num_Tsp[i] == 10 && cnt2 < 2)
                    {
                        cnt2 += 1;
                        picture[i].Tag = num_cnt[1];
                    }
                    else if (num_Tsp[i] == 11 && cnt3 < 2)
                    {
                        cnt3 += 1;
                        picture[i].Tag = num_cnt[2];
                    }
                    else if (num_Tsp[i] == 12 && cnt4 < 2)
                    {
                        cnt4 += 1;
                        picture[i].Tag = num_cnt[3];
                    }
                    else if (num_Tsp[i] == 13 && cnt5 < 2)
                    {
                        cnt5 += 1;
                        picture[i].Tag = num_cnt[4];
                    }
                    else if (num_Tsp[i] == 14 && cnt6 < 2)
                    {
                        cnt6 += 1;
                        picture[i].Tag = num_cnt[5];
                    }
                    else if (num_Tsp[i] == 15 && cnt7 < 2)
                    {
                        cnt7 += 1;
                        picture[i].Tag = num_cnt[6];
                    }
                    else if (num_Tsp[i] == 16 && cnt8 < 2)
                    {
                        cnt8 += 1;
                        picture[i].Tag = num_cnt[7];
                    }
                    //하나라도 2개가되면 실행
                    else if (cnt1 == 2 || cnt2 == 2 || cnt3 == 2 || cnt4 == 2 || cnt5 == 2 || cnt6 == 2 || cnt7 == 2 || cnt8 == 2)
                    {
                        if (picture[i] == pb_Tsphard16)
                        {
                            if (cnt1 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[9];
                                picture[i].Tag = num_cnt[0];
                            }
                            else if (cnt2 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[10];
                                picture[i].Tag = num_cnt[1];
                            }
                            else if (cnt3 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[11];
                                picture[i].Tag = num_cnt[2];
                            }
                            else if (cnt4 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[12];
                                picture[i].Tag = num_cnt[3];
                            }
                            else if (cnt5 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[13];
                                picture[i].Tag = num_cnt[4];
                            }
                            else if (cnt6 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[14];
                                picture[i].Tag = num_cnt[5];
                            }
                            else if (cnt7 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[15];
                                picture[i].Tag = num_cnt[6];
                            }
                            else if (cnt8 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[16];
                                picture[i].Tag = num_cnt[7];
                            }
                        }

                        //1부터 4까지 2개이상이면 그냥 새값 랜덤으로 넣어줌
                        else if (cnt1 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt2 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt3 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt4 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt5 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt6 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt7 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                        else if (cnt8 == 2)
                        {
                            num_Tsp[i] = Random.Next(9, 17);
                            picture[i].Image = null;
                        }
                    }
                }
            }

            //시작 타이머 3,2,1넣어줌
            Tsphard_timer1.Start();
            Tsphard_timer1.Interval = 1000;

            //시작 타이머의 3,2,1값 라벨로 보여줌
            lb_timetext.Text = timercnt.ToString();

            //picturebox의 뒷면으로 바뀌기전 값을 old에 넣어줌
            for (int i = 0; i < picture.Count; i++)
            {
                old_images_Tsp.Add(picture[i].Image);
            }
        }

        //이미지 바뀌는 루프메서드 생성
        private void Roop2()
        {
            //순서반복 카운트
            roopcnt = 1;

            //초기화값 메소드
            List<PictureBox> picture = CrlMethod();

            //picturebox의 이미지 2개씩 넣어줌
            for (int i = 0; i < 16; i++)
            {
                //클릭 가능하게 값줌
                picture[i].Enabled = true;

                //랜덤하게 값줌
                num_Tsp.Add(Random.Next(1, 9));

                //null값이면 계속 돌면서 값을 넣어서 2개이상 안되게 만듬
                while (picture[i].Image == null)
                {
                    //이미지 랜덤하게 넣기
                    picture[i].Image = Tsphard_imageList.Images[num_Tsp[i]];

                    if (num_Tsp[i] == 1 && cnt1 < 2)
                    {
                        cnt1 += 1;
                        picture[i].Tag = num_cnt[0];
                    }
                    else if (num_Tsp[i] == 2 && cnt2 < 2)
                    {
                        cnt2 += 1;
                        picture[i].Tag = num_cnt[1];
                    }
                    else if (num_Tsp[i] == 3 && cnt3 < 2)
                    {
                        cnt3 += 1;
                        picture[i].Tag = num_cnt[2];
                    }
                    else if (num_Tsp[i] == 4 && cnt4 < 2)
                    {
                        cnt4 += 1;
                        picture[i].Tag = num_cnt[3];
                    }
                    else if (num_Tsp[i] == 5 && cnt5 < 2)
                    {
                        cnt5 += 1;
                        picture[i].Tag = num_cnt[4];
                    }
                    else if (num_Tsp[i] == 6 && cnt6 < 2)
                    {
                        cnt6 += 1;
                        picture[i].Tag = num_cnt[5];
                    }
                    else if (num_Tsp[i] == 7 && cnt7 < 2)
                    {
                        cnt7 += 1;
                        picture[i].Tag = num_cnt[6];
                    }
                    else if (num_Tsp[i] == 8 && cnt8 < 2)
                    {
                        cnt8 += 1;
                        picture[i].Tag = num_cnt[7];
                    }
                    //하나라도 2개가되면 실행
                    else if (cnt1 == 2 || cnt2 == 2 || cnt3 == 2 || cnt4 == 2 || cnt5 == 2 || cnt6 == 2 || cnt7 == 2 || cnt8 == 2)
                    {
                        if (picture[i] == pb_Tsphard16)
                        {
                            if (cnt1 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[1];
                                picture[i].Tag = num_cnt[0];
                            }
                            else if (cnt2 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[2];
                                picture[i].Tag = num_cnt[1];
                            }
                            else if (cnt3 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[3];
                                picture[i].Tag = num_cnt[2];
                            }
                            else if (cnt4 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[4];
                                picture[i].Tag = num_cnt[3];
                            }
                            else if (cnt5 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[5];
                                picture[i].Tag = num_cnt[4];
                            }
                            else if (cnt6 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[6];
                                picture[i].Tag = num_cnt[5];
                            }
                            else if (cnt7 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[7];
                                picture[i].Tag = num_cnt[6];
                            }
                            else if (cnt8 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[8];
                                picture[i].Tag = num_cnt[7];
                            }
                        }

                        //1부터 4까지 2개이상이면 그냥 새값 랜덤으로 넣어줌
                        else if (cnt1 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt2 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt3 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt4 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt5 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt6 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt7 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                        else if (cnt8 == 2)
                        {
                            num_Tsp[i] = Random.Next(1, 9);
                            picture[i].Image = null;
                        }
                    }
                }
            }

            //시작 타이머 3,2,1넣어줌
            Tsphard_timer1.Start();
            Tsphard_timer1.Interval = 1000;

            //시작 타이머의 3,2,1값 라벨로 보여줌
            lb_timetext.Text = timercnt.ToString();

            //picturebox의 뒷면으로 바뀌기전 값을 old에 넣어줌
            for (int i = 0; i < picture.Count; i++)
            {
                old_images_Tsp.Add(picture[i].Image);
            }
        }

        //이미지 바뀌는 루프메서드 생성
        private void Roop3()
        {
            //순서반복 카운트
            roopcnt = 0;

            //초기화값 메소드
            List<PictureBox> picture = CrlMethod();

            //picturebox의 이미지 2개씩 넣어줌
            for (int i = 0; i < 16; i++)
            {
                //클릭 가능하게 값줌
                picture[i].Enabled = true;

                //랜덤하게 값줌
                num_Tsp.Add(Random.Next(17, 25));

                //null값이면 계속 돌면서 값을 넣어서 2개이상 안되게 만듬
                while (picture[i].Image == null)
                {
                    //이미지 랜덤하게 넣기
                    picture[i].Image = Tsphard_imageList.Images[num_Tsp[i]];

                    if (num_Tsp[i] == 17 && cnt1 < 2)
                    {
                        cnt1 += 1;
                        picture[i].Tag = num_cnt[0];
                    }
                    else if (num_Tsp[i] == 18 && cnt2 < 2)
                    {
                        cnt2 += 1;
                        picture[i].Tag = num_cnt[1];
                    }
                    else if (num_Tsp[i] == 19 && cnt3 < 2)
                    {
                        cnt3 += 1;
                        picture[i].Tag = num_cnt[2];
                    }
                    else if (num_Tsp[i] == 20 && cnt4 < 2)
                    {
                        cnt4 += 1;
                        picture[i].Tag = num_cnt[3];
                    }
                    else if (num_Tsp[i] == 21 && cnt5 < 2)
                    {
                        cnt5 += 1;
                        picture[i].Tag = num_cnt[4];
                    }
                    else if (num_Tsp[i] == 22 && cnt6 < 2)
                    {
                        cnt6 += 1;
                        picture[i].Tag = num_cnt[5];
                    }
                    else if (num_Tsp[i] == 23 && cnt7 < 2)
                    {
                        cnt7 += 1;
                        picture[i].Tag = num_cnt[6];
                    }
                    else if (num_Tsp[i] == 24 && cnt8 < 2)
                    {
                        cnt8 += 1;
                        picture[i].Tag = num_cnt[7];
                    }
                    //하나라도 2개가되면 실행
                    else if (cnt1 == 2 || cnt2 == 2 || cnt3 == 2 || cnt4 == 2 || cnt5 == 2 || cnt6 == 2 || cnt7 == 2 || cnt8 == 2)
                    {
                        if (picture[i] == pb_Tsphard16)
                        {
                            if (cnt1 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[17];
                                picture[i].Tag = num_cnt[0];
                            }
                            else if (cnt2 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[18];
                                picture[i].Tag = num_cnt[1];
                            }
                            else if (cnt3 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[19];
                                picture[i].Tag = num_cnt[2];
                            }
                            else if (cnt4 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[20];
                                picture[i].Tag = num_cnt[3];
                            }
                            else if (cnt5 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[21];
                                picture[i].Tag = num_cnt[4];
                            }
                            else if (cnt6 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[22];
                                picture[i].Tag = num_cnt[5];
                            }
                            else if (cnt7 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[23];
                                picture[i].Tag = num_cnt[6];
                            }
                            else if (cnt8 == 1)
                            {
                                picture[i].Image = Tsphard_imageList.Images[24];
                                picture[i].Tag = num_cnt[7];
                            }
                        }

                        //1부터 4까지 2개이상이면 그냥 새값 랜덤으로 넣어줌
                        else if (cnt1 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt2 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt3 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt4 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt5 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt6 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt7 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                        else if (cnt8 == 2)
                        {
                            num_Tsp[i] = Random.Next(17, 25);
                            picture[i].Image = null;
                        }
                    }
                }
            }

            //시작 타이머 3,2,1넣어줌
            Tsphard_timer1.Start();
            Tsphard_timer1.Interval = 1000;

            //시작 타이머의 3,2,1값 라벨로 보여줌
            lb_timetext.Text = timercnt.ToString();

            //picturebox의 뒷면으로 바뀌기전 값을 old에 넣어줌
            for (int i = 0; i < picture.Count; i++)
            {
                old_images_Tsp.Add(picture[i].Image);
            }
        }



        private void pb_Tsphard1_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard1, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[0];

            //이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard2_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard2, pb_Tsphard1, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16};

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[1];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard3_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard3, pb_Tsphard2, pb_Tsphard1, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16};

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[2];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard4_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard4, pb_Tsphard2, pb_Tsphard3, pb_Tsphard1,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16};

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[3];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard5_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard5, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard1, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16};

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[4];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard6_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard6, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard1, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[5];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard7_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard7, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard1, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16};

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[6];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard8_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard8, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard1,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16};

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[7];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard9_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard9, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard1, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[8];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard10_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard10, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard1, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[9];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard11_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard11, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard1, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[10];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard12_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard12, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard1,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[11];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard13_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard13, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard1, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[12];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard14_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard14, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard1, pb_Tsphard15, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[13];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard15_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard15, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard1, pb_Tsphard16 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[14];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void pb_Tsphard16_Click(object sender, EventArgs e)
        {
            //픽쳐박스 리스트 순서만 바꿔서 재선언
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard16, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard1 };

            //클릭시 이미지 보이기
            picture[0].Image = old_images_Tsp[15];

            // 이미지 체크 메소드 호출
            recheckMethod(picture);
        }

        private void Tsphard_timer1_Tick(object sender, EventArgs e)
        {
            //picturebox 배열 선언후 값 넣어줌
            List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard1, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

            //타이머틱이 작동될때마다 타이머카운트 하나 다운
            timercnt--;

            //타이머 카운트를 계속 라벨에 넣어줌
            lb_timetext.Text = timercnt.ToString();

            //클릭 불가
            for (int i = 0; i < picture.Count; i++)
            {
                picture[i].Enabled = false;
            }

            //0으로 바뀌면 라벨은 없어지고 이미지는 뒷면으로 바꾸기
            if (timercnt == 0)
            {
                //0이되면 타이머 동작 안하게 시킴
                Tsphard_timer1.Stop();

                //타이머2 동작시작;
                Tsphard_timer2.Start();

                //시작되면 뒷면으로 뒤집기;
                for (int i = 0; i < picture.Count; i++)
                {
                    picture[i].Image = Tsphard_imageList.Images[0];
                }

                //클릭가능
                for (int i = 0; i < picture.Count; i++)
                {
                    picture[i].Enabled = true;
                }

                //라벨없애기
                lb_timetext.Text = string.Empty;

                //타이머 카운트 초기화
                timercnt = 3;
            }
        }

        private void Tsphard_timer2_Tick(object sender, EventArgs e)
        {
            //타이머 틱이 바뀔때마다 value값 줄이기
            if (progressbar_Tsphard.Value > 0)
            {
                progressbar_Tsphard.Value--;
            }

            //20초가 끝나면 창이닫힘
            if (double.Parse(progressbar_Tsphard.CustomText) == 0.0 && progressbar_Tsphard.Value == 0)
            {
                Tsphard_timer2.Stop();

                //픽쳐 리스트선언후 보이지 않게하기
                List<PictureBox> picture = new List<PictureBox>() { pb_Tsphard1, pb_Tsphard2, pb_Tsphard3, pb_Tsphard4,
                pb_Tsphard5, pb_Tsphard6, pb_Tsphard7, pb_Tsphard8,
                pb_Tsphard9, pb_Tsphard10, pb_Tsphard11, pb_Tsphard12,
                pb_Tsphard13, pb_Tsphard14, pb_Tsphard15, pb_Tsphard16 };

                for (int i = 0; i < picture.Count; i++)
                {
                    picture[i].Visible = false;
                }

                //시간 안보이기
                progressbar_Tsphard.Visible = false;

                //점수 안보이기
                lb_TspScore.Visible = false;

                //스코어 라벨 안보이기
                label2.Visible = false;

                lb_TspScore.Visible = false;
                progressbar_Tsphard.Visible = false;
                label2.Visible = false;

                //최종 스코어값 표시
                lb_Tsphard_lastscore.Enabled = true;
                lb_Tsphard_lastscore.Visible = true;
                lb_Tsphard_lastscore.Text = "score : " + lb_TspScore.Text;

                //확인버튼 표시
                btn_Tsphard_ok.Enabled = true;
                btn_Tsphard_ok.Visible = true;
            }

            //타이머 틱이 바뀔때마다 프로그래스바 텍스트값 줄이기 및 10초지나면 색깔 바꾸기
            if (double.Parse(progressbar_Tsphard.CustomText) > 15.0)
            {
                progressbar_Tsphard.CustomText = string.Format("{0:f1}", double.Parse(progressbar_Tsphard.CustomText) - 0.1);
            }
            else
            {
                progressbar_Tsphard.TextColor = Color.White;
                progressbar_Tsphard.CustomText = string.Format("{0:f1}", double.Parse(progressbar_Tsphard.CustomText) - 0.1);
            }
        }

        private void Tsphard_Start_Timer_Tick(object sender, EventArgs e)
        {
            //타이머틱이 작동될때마다 타이머카운트 하나 다운
            timercnt--;

            //타이머 카운트를 계속 라벨에 넣어줌
            lb_timetext.Text = timercnt.ToString();

            //0으로 바뀌면 라벨 없애기
            if (timercnt == 0)
            {
                //0이되면 타이머 동작 안하게 시킴
                Tsphard_Start_Timer.Stop();

                //라벨없애기
                lb_timetext.Text = string.Empty;

                //처음시작 이미지 루프
                Roop2();
                Tsphard_timer1.Start();

                //타이머 카운트 초기화
                timercnt = 3;
            }
        }

        private void btn_Tsphard_ok_Click(object sender, EventArgs e)
        {
            string[] test = lb_Tsphard_lastscore.Text.Split("score : ");

            totalscore = int.Parse(test[1]);
            //델리게이트 이벤트를통해 폼1(부모폼)으로 데이터 전송
            this.FormSendEvent(totalscore.ToString());

            this.Close();
        }
    }
}