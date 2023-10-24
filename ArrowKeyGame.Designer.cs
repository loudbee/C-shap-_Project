namespace Moble
{
    partial class ArrowKeyGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrowKeyGame));
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new System.Windows.Forms.Label();
            lb_Countdown = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            imageList1 = new System.Windows.Forms.ImageList(components);
            pb_input1 = new System.Windows.Forms.PictureBox();
            pb_input2 = new System.Windows.Forms.PictureBox();
            pb_input3 = new System.Windows.Forms.PictureBox();
            pb_input4 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            lb_Start = new System.Windows.Forms.Label();
            labelProgressBar1 = new LabelProgressBar();
            Final_Result = new System.Windows.Forms.Label();
            btn_Result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_input1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_input2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_input3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_input4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(205, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 74);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(214, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 19);
            label2.TabIndex = 2;
            label2.Text = "score";
            // 
            // lb_Countdown
            // 
            lb_Countdown.AutoSize = true;
            lb_Countdown.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Countdown.Location = new System.Drawing.Point(194, 136);
            lb_Countdown.Name = "lb_Countdown";
            lb_Countdown.Size = new System.Drawing.Size(105, 110);
            lb_Countdown.TabIndex = 3;
            lb_Countdown.Text = "3";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(73, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(75, 71);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(154, 272);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(75, 71);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new System.Drawing.Point(235, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(75, 71);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new System.Drawing.Point(316, 272);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(75, 71);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // timer2
            // 
            timer2.Interval = 200;
            timer2.Tick += timer2_Tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "keydown.png");
            imageList1.Images.SetKeyName(1, "keyleft.png");
            imageList1.Images.SetKeyName(2, "keyright.png");
            imageList1.Images.SetKeyName(3, "keyup.png");
            // 
            // pb_input1
            // 
            pb_input1.Location = new System.Drawing.Point(73, 394);
            pb_input1.Name = "pb_input1";
            pb_input1.Size = new System.Drawing.Size(75, 71);
            pb_input1.TabIndex = 8;
            pb_input1.TabStop = false;
            // 
            // pb_input2
            // 
            pb_input2.Location = new System.Drawing.Point(154, 394);
            pb_input2.Name = "pb_input2";
            pb_input2.Size = new System.Drawing.Size(75, 71);
            pb_input2.TabIndex = 10;
            pb_input2.TabStop = false;
            // 
            // pb_input3
            // 
            pb_input3.Location = new System.Drawing.Point(235, 394);
            pb_input3.Name = "pb_input3";
            pb_input3.Size = new System.Drawing.Size(75, 71);
            pb_input3.TabIndex = 11;
            pb_input3.TabStop = false;
            // 
            // pb_input4
            // 
            pb_input4.Location = new System.Drawing.Point(316, 394);
            pb_input4.Name = "pb_input4";
            pb_input4.Size = new System.Drawing.Size(75, 71);
            pb_input4.TabIndex = 12;
            pb_input4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(79, 529);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(304, 32);
            label3.TabIndex = 14;
            label3.Text = "방향키를 모두 입력한 후 SpaceBar를 누르십시오.\r\n              맞으면 +10점, 틀리면 -5점";
            // 
            // lb_Start
            // 
            lb_Start.AutoSize = true;
            lb_Start.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Start.Location = new System.Drawing.Point(12, 136);
            lb_Start.Name = "lb_Start";
            lb_Start.Size = new System.Drawing.Size(0, 110);
            lb_Start.TabIndex = 15;
            // 
            // labelProgressBar1
            // 
            labelProgressBar1.BackColor = System.Drawing.Color.RoyalBlue;
            labelProgressBar1.CustomText = "20.0";
            labelProgressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            labelProgressBar1.Location = new System.Drawing.Point(23, 12);
            labelProgressBar1.Maximum = 200;
            labelProgressBar1.Name = "labelProgressBar1";
            labelProgressBar1.ProgressColor = System.Drawing.Color.LightGreen;
            labelProgressBar1.Size = new System.Drawing.Size(449, 30);
            labelProgressBar1.TabIndex = 16;
            labelProgressBar1.TextColor = System.Drawing.Color.Black;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProgressBar1.Value = 200;
            labelProgressBar1.VisualMode = ProgressBarDisplayMode.CustomText;
            // 
            // Final_Result
            // 
            Final_Result.AutoSize = true;
            Final_Result.BackColor = System.Drawing.Color.Transparent;
            Final_Result.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Final_Result.ForeColor = System.Drawing.Color.White;
            Final_Result.Location = new System.Drawing.Point(130, 136);
            Final_Result.Name = "Final_Result";
            Final_Result.Size = new System.Drawing.Size(0, 74);
            Final_Result.TabIndex = 20;
            // 
            // btn_Result
            // 
            btn_Result.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Result.Location = new System.Drawing.Point(154, 349);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new System.Drawing.Size(169, 76);
            btn_Result.TabIndex = 21;
            btn_Result.Text = "확인";
            btn_Result.UseVisualStyleBackColor = true;
            btn_Result.Click += btn_Result_Click;
            // 
            // ArrowKeyGame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(btn_Result);
            Controls.Add(Final_Result);
            Controls.Add(labelProgressBar1);
            Controls.Add(lb_Start);
            Controls.Add(label3);
            Controls.Add(pb_input4);
            Controls.Add(pb_input3);
            Controls.Add(pb_input2);
            Controls.Add(pb_input1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lb_Countdown);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ArrowKeyGame";
            Text = "방향키 게임";
            Load += ArrowKeyGame_Load;
            KeyDown += ArrowKeyGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_input1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_input2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_input3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_input4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Countdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pb_input1;
        private System.Windows.Forms.PictureBox pb_input2;
        private System.Windows.Forms.PictureBox pb_input3;
        private System.Windows.Forms.PictureBox pb_input4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Start;
        private LabelProgressBar labelProgressBar1;
        private System.Windows.Forms.Label Final_Result;
        private System.Windows.Forms.Button btn_Result;
    }
}
