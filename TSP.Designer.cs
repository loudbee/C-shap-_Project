namespace Moble
{
    partial class TSP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TSP));
            lb_TspScore = new System.Windows.Forms.Label();
            Tsp_timer1 = new System.Windows.Forms.Timer(components);
            label2 = new System.Windows.Forms.Label();
            progressbar_Tsp = new LabelProgressBar();
            panel1 = new System.Windows.Forms.Panel();
            pb_Tsp8 = new System.Windows.Forms.PictureBox();
            pb_Tsp4 = new System.Windows.Forms.PictureBox();
            pb_Tsp7 = new System.Windows.Forms.PictureBox();
            pb_Tsp3 = new System.Windows.Forms.PictureBox();
            pb_Tsp6 = new System.Windows.Forms.PictureBox();
            pb_Tsp2 = new System.Windows.Forms.PictureBox();
            pb_Tsp5 = new System.Windows.Forms.PictureBox();
            pb_Tsp1 = new System.Windows.Forms.PictureBox();
            lb_Tsp_lastscore = new System.Windows.Forms.Label();
            Tsp_imageList = new System.Windows.Forms.ImageList(components);
            Tsp_timer2 = new System.Windows.Forms.Timer(components);
            lb_timetext = new System.Windows.Forms.Label();
            Tsp_Start_Timer = new System.Windows.Forms.Timer(components);
            btn_Tsp_ok = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp1).BeginInit();
            SuspendLayout();
            // 
            // lb_TspScore
            // 
            lb_TspScore.AutoSize = true;
            lb_TspScore.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_TspScore.ForeColor = System.Drawing.Color.White;
            lb_TspScore.Location = new System.Drawing.Point(175, 35);
            lb_TspScore.Name = "lb_TspScore";
            lb_TspScore.Size = new System.Drawing.Size(146, 74);
            lb_TspScore.TabIndex = 0;
            lb_TspScore.Text = "200";
            // 
            // Tsp_timer1
            // 
            Tsp_timer1.Tick += Tsp_timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(225, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 19);
            label2.TabIndex = 2;
            label2.Text = "score";
            // 
            // progressbar_Tsp
            // 
            progressbar_Tsp.CustomText = "progressbar";
            progressbar_Tsp.Location = new System.Drawing.Point(12, 12);
            progressbar_Tsp.Maximum = 200;
            progressbar_Tsp.Name = "progressbar_Tsp";
            progressbar_Tsp.ProgressColor = System.Drawing.Color.White;
            progressbar_Tsp.Size = new System.Drawing.Size(460, 23);
            progressbar_Tsp.TabIndex = 3;
            progressbar_Tsp.TextColor = System.Drawing.Color.RoyalBlue;
            progressbar_Tsp.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            progressbar_Tsp.Value = 200;
            progressbar_Tsp.VisualMode = ProgressBarDisplayMode.CustomText;
            // 
            // panel1
            // 
            panel1.Controls.Add(pb_Tsp8);
            panel1.Controls.Add(pb_Tsp4);
            panel1.Controls.Add(pb_Tsp7);
            panel1.Controls.Add(pb_Tsp3);
            panel1.Controls.Add(pb_Tsp6);
            panel1.Controls.Add(pb_Tsp2);
            panel1.Controls.Add(pb_Tsp5);
            panel1.Controls.Add(pb_Tsp1);
            panel1.Location = new System.Drawing.Point(12, 180);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(460, 250);
            panel1.TabIndex = 4;
            // 
            // pb_Tsp8
            // 
            pb_Tsp8.Location = new System.Drawing.Point(380, 145);
            pb_Tsp8.Name = "pb_Tsp8";
            pb_Tsp8.Size = new System.Drawing.Size(58, 102);
            pb_Tsp8.TabIndex = 7;
            pb_Tsp8.TabStop = false;
            pb_Tsp8.Click += pb_Tsp8_Click;
            // 
            // pb_Tsp4
            // 
            pb_Tsp4.Location = new System.Drawing.Point(380, 3);
            pb_Tsp4.Name = "pb_Tsp4";
            pb_Tsp4.Size = new System.Drawing.Size(58, 102);
            pb_Tsp4.TabIndex = 6;
            pb_Tsp4.TabStop = false;
            pb_Tsp4.Click += pb_Tsp4_Click;
            // 
            // pb_Tsp7
            // 
            pb_Tsp7.Location = new System.Drawing.Point(260, 145);
            pb_Tsp7.Name = "pb_Tsp7";
            pb_Tsp7.Size = new System.Drawing.Size(58, 102);
            pb_Tsp7.TabIndex = 5;
            pb_Tsp7.TabStop = false;
            pb_Tsp7.Click += pb_Tsp7_Click;
            // 
            // pb_Tsp3
            // 
            pb_Tsp3.Location = new System.Drawing.Point(260, 3);
            pb_Tsp3.Name = "pb_Tsp3";
            pb_Tsp3.Size = new System.Drawing.Size(58, 102);
            pb_Tsp3.TabIndex = 4;
            pb_Tsp3.TabStop = false;
            pb_Tsp3.Click += pb_Tsp3_Click;
            // 
            // pb_Tsp6
            // 
            pb_Tsp6.Location = new System.Drawing.Point(140, 145);
            pb_Tsp6.Name = "pb_Tsp6";
            pb_Tsp6.Size = new System.Drawing.Size(58, 102);
            pb_Tsp6.TabIndex = 3;
            pb_Tsp6.TabStop = false;
            pb_Tsp6.Click += pb_Tsp6_Click;
            // 
            // pb_Tsp2
            // 
            pb_Tsp2.Location = new System.Drawing.Point(140, 3);
            pb_Tsp2.Name = "pb_Tsp2";
            pb_Tsp2.Size = new System.Drawing.Size(58, 102);
            pb_Tsp2.TabIndex = 2;
            pb_Tsp2.TabStop = false;
            pb_Tsp2.Click += pb_Tsp2_Click;
            // 
            // pb_Tsp5
            // 
            pb_Tsp5.Location = new System.Drawing.Point(20, 145);
            pb_Tsp5.Name = "pb_Tsp5";
            pb_Tsp5.Size = new System.Drawing.Size(58, 102);
            pb_Tsp5.TabIndex = 1;
            pb_Tsp5.TabStop = false;
            pb_Tsp5.Click += pb_Tsp5_Click;
            // 
            // pb_Tsp1
            // 
            pb_Tsp1.Location = new System.Drawing.Point(20, 3);
            pb_Tsp1.Name = "pb_Tsp1";
            pb_Tsp1.Size = new System.Drawing.Size(58, 102);
            pb_Tsp1.TabIndex = 0;
            pb_Tsp1.TabStop = false;
            pb_Tsp1.Click += pb_Tsp1_Click;
            // 
            // lb_Tsp_lastscore
            // 
            lb_Tsp_lastscore.AutoSize = true;
            lb_Tsp_lastscore.Enabled = false;
            lb_Tsp_lastscore.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Tsp_lastscore.ForeColor = System.Drawing.Color.White;
            lb_Tsp_lastscore.Location = new System.Drawing.Point(60, 170);
            lb_Tsp_lastscore.Name = "lb_Tsp_lastscore";
            lb_Tsp_lastscore.Size = new System.Drawing.Size(369, 74);
            lb_Tsp_lastscore.TabIndex = 6;
            lb_Tsp_lastscore.Text = "score : 200";
            // 
            // Tsp_imageList
            // 
            Tsp_imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            Tsp_imageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("Tsp_imageList.ImageStream");
            Tsp_imageList.TransparentColor = System.Drawing.Color.Transparent;
            Tsp_imageList.Images.SetKeyName(0, "뒷면.jpg");
            Tsp_imageList.Images.SetKeyName(1, "1만.jpg");
            Tsp_imageList.Images.SetKeyName(2, "1삭.jpg");
            Tsp_imageList.Images.SetKeyName(3, "1통.jpg");
            Tsp_imageList.Images.SetKeyName(4, "5만.jpg");
            Tsp_imageList.Images.SetKeyName(5, "5삭.jpg");
            Tsp_imageList.Images.SetKeyName(6, "5통.jpg");
            Tsp_imageList.Images.SetKeyName(7, "8만.jpg");
            Tsp_imageList.Images.SetKeyName(8, "8삭.jpg");
            Tsp_imageList.Images.SetKeyName(9, "8통.jpg");
            Tsp_imageList.Images.SetKeyName(10, "9만.jpg");
            Tsp_imageList.Images.SetKeyName(11, "9삭.jpg");
            Tsp_imageList.Images.SetKeyName(12, "9통.jpg");
            Tsp_imageList.Images.SetKeyName(13, "남.jpg");
            Tsp_imageList.Images.SetKeyName(14, "동.jpg");
            Tsp_imageList.Images.SetKeyName(15, "발.jpg");
            Tsp_imageList.Images.SetKeyName(16, "백.jpg");
            Tsp_imageList.Images.SetKeyName(17, "북.jpg");
            Tsp_imageList.Images.SetKeyName(18, "서.jpg");
            Tsp_imageList.Images.SetKeyName(19, "중.jpg");
            Tsp_imageList.Images.SetKeyName(20, "3만.jpg");
            Tsp_imageList.Images.SetKeyName(21, "3삭.jpg");
            Tsp_imageList.Images.SetKeyName(22, "3통.jpg");
            Tsp_imageList.Images.SetKeyName(23, "북2.jpg");
            Tsp_imageList.Images.SetKeyName(24, "중2.jpg");
            // 
            // Tsp_timer2
            // 
            Tsp_timer2.Tick += Tsp_timer2_Tick;
            // 
            // lb_timetext
            // 
            lb_timetext.AutoSize = true;
            lb_timetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_timetext.ForeColor = System.Drawing.Color.Black;
            lb_timetext.Location = new System.Drawing.Point(194, 475);
            lb_timetext.Name = "lb_timetext";
            lb_timetext.Size = new System.Drawing.Size(98, 108);
            lb_timetext.TabIndex = 5;
            lb_timetext.Text = "3";
            // 
            // Tsp_Start_Timer
            // 
            Tsp_Start_Timer.Interval = 1000;
            Tsp_Start_Timer.Tick += Tsp_Start_Timer_Tick;
            // 
            // btn_Tsp_ok
            // 
            btn_Tsp_ok.Enabled = false;
            btn_Tsp_ok.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Tsp_ok.Location = new System.Drawing.Point(160, 335);
            btn_Tsp_ok.Name = "btn_Tsp_ok";
            btn_Tsp_ok.Size = new System.Drawing.Size(164, 87);
            btn_Tsp_ok.TabIndex = 6;
            btn_Tsp_ok.Text = "확인";
            btn_Tsp_ok.UseVisualStyleBackColor = true;
            btn_Tsp_ok.Click += btn_Tsp_ok_Click;
            // 
            // TSP
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(lb_Tsp_lastscore);
            Controls.Add(btn_Tsp_ok);
            Controls.Add(lb_timetext);
            Controls.Add(panel1);
            Controls.Add(progressbar_Tsp);
            Controls.Add(label2);
            Controls.Add(lb_TspScore);
            Name = "TSP";
            Text = "같은그림찾기 게임";
            Load += TSP_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_Tsp8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Tsp1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_TspScore;
        private System.Windows.Forms.Timer Tsp_timer1;
        private System.Windows.Forms.Label label2;
        private LabelProgressBar progressbar_Tsp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Tsp6;
        private System.Windows.Forms.PictureBox pb_Tsp2;
        private System.Windows.Forms.PictureBox pb_Tsp5;
        private System.Windows.Forms.PictureBox pb_Tsp1;
        private System.Windows.Forms.PictureBox pb_Tsp8;
        private System.Windows.Forms.PictureBox pb_Tsp4;
        private System.Windows.Forms.PictureBox pb_Tsp7;
        private System.Windows.Forms.PictureBox pb_Tsp3;
        private System.Windows.Forms.ImageList Tsp_imageList;
        private System.Windows.Forms.Timer Tsp_timer2;
        private System.Windows.Forms.Label lb_timetext;
        private System.Windows.Forms.Timer Tsp_Start_Timer;
        private System.Windows.Forms.Label lb_Tsp_lastscore;
        private System.Windows.Forms.Button btn_Tsp_ok;
    }
}
