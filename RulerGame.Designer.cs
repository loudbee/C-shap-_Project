namespace Moble
{
    partial class RulerGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulerGame));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            lb_Countdown = new System.Windows.Forms.Label();
            timer3 = new System.Windows.Forms.Timer(components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            lbStart = new System.Windows.Forms.Label();
            labelProgressBar1 = new LabelProgressBar();
            timer4 = new System.Windows.Forms.Timer(components);
            btn_Result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(196, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 280);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Countdown
            // 
            lb_Countdown.AutoSize = true;
            lb_Countdown.BackColor = System.Drawing.Color.Transparent;
            lb_Countdown.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Countdown.Location = new System.Drawing.Point(174, 431);
            lb_Countdown.Name = "lb_Countdown";
            lb_Countdown.Size = new System.Drawing.Size(105, 110);
            lb_Countdown.TabIndex = 4;
            lb_Countdown.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(199, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 19);
            label2.TabIndex = 6;
            label2.Text = "score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(190, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 74);
            label1.TabIndex = 5;
            label1.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(195, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(60, 280);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(110, 214);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(242, 66);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(78, 224);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(212, 160);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // lbStart
            // 
            lbStart.AutoSize = true;
            lbStart.BackColor = System.Drawing.Color.Transparent;
            lbStart.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbStart.ForeColor = System.Drawing.Color.White;
            lbStart.Location = new System.Drawing.Point(52, 460);
            lbStart.Name = "lbStart";
            lbStart.Size = new System.Drawing.Size(48, 74);
            lbStart.TabIndex = 17;
            lbStart.Text = " ";
            // 
            // labelProgressBar1
            // 
            labelProgressBar1.BackColor = System.Drawing.Color.RoyalBlue;
            labelProgressBar1.CustomText = "20.0";
            labelProgressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            labelProgressBar1.Location = new System.Drawing.Point(12, 12);
            labelProgressBar1.Maximum = 200;
            labelProgressBar1.Name = "labelProgressBar1";
            labelProgressBar1.ProgressColor = System.Drawing.Color.LightGreen;
            labelProgressBar1.Size = new System.Drawing.Size(449, 30);
            labelProgressBar1.TabIndex = 18;
            labelProgressBar1.TextColor = System.Drawing.Color.Black;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProgressBar1.Value = 200;
            labelProgressBar1.VisualMode = ProgressBarDisplayMode.CustomText;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // btn_Result
            // 
            btn_Result.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Result.Location = new System.Drawing.Point(160, 350);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new System.Drawing.Size(169, 76);
            btn_Result.TabIndex = 34;
            btn_Result.Text = "확인";
            btn_Result.UseVisualStyleBackColor = true;
            btn_Result.Visible = false;
            btn_Result.Click += btn_Result_Click;
            // 
            // RulerGame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(btn_Result);
            Controls.Add(labelProgressBar1);
            Controls.Add(lbStart);
            Controls.Add(lb_Countdown);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "RulerGame";
            Text = "자를 잡아라 게임";
            Load += RulerGame_Load;
            KeyDown += RulerGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lb_Countdown;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbStart;
        private LabelProgressBar labelProgressBar1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button btn_Result;
    }
}