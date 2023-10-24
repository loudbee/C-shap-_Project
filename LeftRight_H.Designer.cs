namespace Moble
{
    partial class LeftRight_H
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeftRight_H));
            lbScore = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lable2 = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnI1 = new System.Windows.Forms.Button();
            imageList2 = new System.Windows.Forms.ImageList(components);
            btnR = new System.Windows.Forms.Button();
            btnL = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            btnUL = new System.Windows.Forms.Button();
            btnUR = new System.Windows.Forms.Button();
            lb_Sec = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            labelProgressBar2 = new LabelProgressBar();
            button1 = new System.Windows.Forms.Button();
            lbEndScore = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbScore.ForeColor = System.Drawing.Color.White;
            lbScore.Location = new System.Drawing.Point(175, 35);
            lbScore.Name = "lbScore";
            lbScore.Size = new System.Drawing.Size(146, 74);
            lbScore.TabIndex = 0;
            lbScore.Text = "200";
            lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lable2.ForeColor = System.Drawing.Color.White;
            lable2.Location = new System.Drawing.Point(216, 100);
            lable2.Name = "lable2";
            lable2.Size = new System.Drawing.Size(52, 19);
            lable2.TabIndex = 2;
            lable2.Text = "score";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "LR_Dog.png");
            imageList1.Images.SetKeyName(1, "LR_Cat.png");
            imageList1.Images.SetKeyName(2, "LR_Bird.png");
            imageList1.Images.SetKeyName(3, "LR_Gorani.png");
            // 
            // btnI1
            // 
            btnI1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnI1.ForeColor = System.Drawing.Color.RoyalBlue;
            btnI1.ImageIndex = 4;
            btnI1.ImageList = imageList2;
            btnI1.Location = new System.Drawing.Point(167, 374);
            btnI1.Name = "btnI1";
            btnI1.Size = new System.Drawing.Size(151, 134);
            btnI1.TabIndex = 3;
            btnI1.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "tvdog.png");
            imageList2.Images.SetKeyName(1, "tvcat.png");
            imageList2.Images.SetKeyName(2, "tvbird.png");
            imageList2.Images.SetKeyName(3, "tvgorani.png");
            imageList2.Images.SetKeyName(4, "tv.png");
            // 
            // btnR
            // 
            btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnR.ForeColor = System.Drawing.Color.RoyalBlue;
            btnR.ImageIndex = 1;
            btnR.ImageList = imageList1;
            btnR.Location = new System.Drawing.Point(339, 521);
            btnR.Name = "btnR";
            btnR.Size = new System.Drawing.Size(133, 128);
            btnR.TabIndex = 3;
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // btnL
            // 
            btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnL.ForeColor = System.Drawing.Color.RoyalBlue;
            btnL.ImageIndex = 0;
            btnL.ImageList = imageList1;
            btnL.Location = new System.Drawing.Point(12, 521);
            btnL.Name = "btnL";
            btnL.Size = new System.Drawing.Size(133, 128);
            btnL.TabIndex = 3;
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(220, 120);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(42, 23);
            btnStart.TabIndex = 4;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnUL
            // 
            btnUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUL.ForeColor = System.Drawing.Color.RoyalBlue;
            btnUL.ImageIndex = 2;
            btnUL.ImageList = imageList1;
            btnUL.Location = new System.Drawing.Point(12, 251);
            btnUL.Name = "btnUL";
            btnUL.Size = new System.Drawing.Size(133, 124);
            btnUL.TabIndex = 10;
            btnUL.UseVisualStyleBackColor = true;
            btnUL.Click += btnUL_Click;
            // 
            // btnUR
            // 
            btnUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUR.ForeColor = System.Drawing.Color.RoyalBlue;
            btnUR.ImageIndex = 3;
            btnUR.ImageList = imageList1;
            btnUR.Location = new System.Drawing.Point(339, 251);
            btnUR.Name = "btnUR";
            btnUR.Size = new System.Drawing.Size(133, 124);
            btnUR.TabIndex = 11;
            btnUR.UseVisualStyleBackColor = true;
            btnUR.Click += btnUR_Click;
            // 
            // lb_Sec
            // 
            lb_Sec.AutoSize = true;
            lb_Sec.Font = new System.Drawing.Font("맑은 고딕", 63F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Sec.Location = new System.Drawing.Point(195, 197);
            lb_Sec.Name = "lb_Sec";
            lb_Sec.Size = new System.Drawing.Size(96, 112);
            lb_Sec.TabIndex = 12;
            lb_Sec.Text = "3";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // labelProgressBar2
            // 
            labelProgressBar2.CustomText = "";
            labelProgressBar2.Location = new System.Drawing.Point(12, 9);
            labelProgressBar2.Maximum = 200;
            labelProgressBar2.Name = "labelProgressBar2";
            labelProgressBar2.ProgressColor = System.Drawing.Color.LightGreen;
            labelProgressBar2.Size = new System.Drawing.Size(460, 23);
            labelProgressBar2.TabIndex = 13;
            labelProgressBar2.TextColor = System.Drawing.Color.Black;
            labelProgressBar2.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProgressBar2.Value = 200;
            labelProgressBar2.VisualMode = ProgressBarDisplayMode.CustomText;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(158, 377);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(164, 87);
            button1.TabIndex = 58;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbEndScore
            // 
            lbEndScore.AutoSize = true;
            lbEndScore.BackColor = System.Drawing.Color.RoyalBlue;
            lbEndScore.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbEndScore.ForeColor = System.Drawing.Color.White;
            lbEndScore.Location = new System.Drawing.Point(58, 197);
            lbEndScore.Name = "lbEndScore";
            lbEndScore.Size = new System.Drawing.Size(369, 74);
            lbEndScore.TabIndex = 57;
            lbEndScore.Text = "score : 100";
            // 
            // LeftRight_H
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(button1);
            Controls.Add(lbEndScore);
            Controls.Add(labelProgressBar2);
            Controls.Add(lb_Sec);
            Controls.Add(btnUR);
            Controls.Add(btnUL);
            Controls.Add(btnStart);
            Controls.Add(btnR);
            Controls.Add(btnL);
            Controls.Add(btnI1);
            Controls.Add(lable2);
            Controls.Add(lbScore);
            Name = "LeftRight_H";
            Text = "좌로우로 게임 하드모드";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnI1;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUL;
        private System.Windows.Forms.Button btnUR;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lb_Sec;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private LabelProgressBar labelProgressBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbEndScore;
    }
}
