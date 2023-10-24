namespace Gandi
{
    partial class RSPGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSPGame));
            picQ2 = new System.Windows.Forms.PictureBox();
            picRock = new System.Windows.Forms.PictureBox();
            picSci = new System.Windows.Forms.PictureBox();
            picPaper = new System.Windows.Forms.PictureBox();
            picQ3 = new System.Windows.Forms.PictureBox();
            picQ1 = new System.Windows.Forms.PictureBox();
            label17 = new System.Windows.Forms.Label();
            proBar = new Moble.LabelProgressBar();
            lbscore = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lbCheck = new System.Windows.Forms.Label();
            lbEndScore = new System.Windows.Forms.Label();
            lbcnt = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picQ2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQ3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQ1).BeginInit();
            SuspendLayout();
            // 
            // picQ2
            // 
            picQ2.Image = (System.Drawing.Image)resources.GetObject("picQ2.Image");
            picQ2.Location = new System.Drawing.Point(175, 327);
            picQ2.Name = "picQ2";
            picQ2.Size = new System.Drawing.Size(134, 127);
            picQ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picQ2.TabIndex = 0;
            picQ2.TabStop = false;
            // 
            // picRock
            // 
            picRock.Image = (System.Drawing.Image)resources.GetObject("picRock.Image");
            picRock.Location = new System.Drawing.Point(12, 498);
            picRock.Name = "picRock";
            picRock.Size = new System.Drawing.Size(134, 129);
            picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picRock.TabIndex = 1;
            picRock.TabStop = false;
            picRock.Click += picRock_Click;
            // 
            // picSci
            // 
            picSci.Image = (System.Drawing.Image)resources.GetObject("picSci.Image");
            picSci.Location = new System.Drawing.Point(175, 498);
            picSci.Name = "picSci";
            picSci.Size = new System.Drawing.Size(134, 129);
            picSci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picSci.TabIndex = 2;
            picSci.TabStop = false;
            picSci.Click += picSci_Click;
            // 
            // picPaper
            // 
            picPaper.Image = (System.Drawing.Image)resources.GetObject("picPaper.Image");
            picPaper.Location = new System.Drawing.Point(338, 498);
            picPaper.Name = "picPaper";
            picPaper.Size = new System.Drawing.Size(134, 129);
            picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPaper.TabIndex = 3;
            picPaper.TabStop = false;
            picPaper.Click += picPaper_Click;
            // 
            // picQ3
            // 
            picQ3.Image = (System.Drawing.Image)resources.GetObject("picQ3.Image");
            picQ3.Location = new System.Drawing.Point(175, 327);
            picQ3.Name = "picQ3";
            picQ3.Size = new System.Drawing.Size(134, 127);
            picQ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picQ3.TabIndex = 4;
            picQ3.TabStop = false;
            // 
            // picQ1
            // 
            picQ1.Image = (System.Drawing.Image)resources.GetObject("picQ1.Image");
            picQ1.Location = new System.Drawing.Point(175, 327);
            picQ1.Name = "picQ1";
            picQ1.Size = new System.Drawing.Size(134, 127);
            picQ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picQ1.TabIndex = 5;
            picQ1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.Color.White;
            label17.Location = new System.Drawing.Point(217, 114);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(52, 19);
            label17.TabIndex = 37;
            label17.Text = "score";
            // 
            // proBar
            // 
            proBar.BackColor = System.Drawing.Color.RoyalBlue;
            proBar.CustomText = "";
            proBar.Location = new System.Drawing.Point(12, 12);
            proBar.Maximum = 200;
            proBar.Name = "proBar";
            proBar.ProgressColor = System.Drawing.Color.Aqua;
            proBar.Size = new System.Drawing.Size(460, 30);
            proBar.TabIndex = 36;
            proBar.TextColor = System.Drawing.Color.RoyalBlue;
            proBar.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            proBar.Value = 200;
            proBar.VisualMode = Moble.ProgressBarDisplayMode.CustomText;
            // 
            // lbscore
            // 
            lbscore.AutoSize = true;
            lbscore.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbscore.ForeColor = System.Drawing.Color.White;
            lbscore.Location = new System.Drawing.Point(175, 45);
            lbscore.Name = "lbscore";
            lbscore.Size = new System.Drawing.Size(146, 74);
            lbscore.TabIndex = 38;
            lbscore.Text = "100";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // lbCheck
            // 
            lbCheck.AutoSize = true;
            lbCheck.BackColor = System.Drawing.Color.RoyalBlue;
            lbCheck.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCheck.Location = new System.Drawing.Point(156, 469);
            lbCheck.Name = "lbCheck";
            lbCheck.Size = new System.Drawing.Size(171, 17);
            lbCheck.TabIndex = 39;
            lbCheck.Text = "승 : 1 무 : 1 패 : 1";
            // 
            // lbEndScore
            // 
            lbEndScore.AutoSize = true;
            lbEndScore.BackColor = System.Drawing.Color.RoyalBlue;
            lbEndScore.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbEndScore.ForeColor = System.Drawing.Color.White;
            lbEndScore.Location = new System.Drawing.Point(60, 170);
            lbEndScore.Name = "lbEndScore";
            lbEndScore.Size = new System.Drawing.Size(369, 74);
            lbEndScore.TabIndex = 40;
            lbEndScore.Text = "score : 100";
            // 
            // lbcnt
            // 
            lbcnt.AutoSize = true;
            lbcnt.Font = new System.Drawing.Font("휴먼둥근헤드라인", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbcnt.Location = new System.Drawing.Point(185, 189);
            lbcnt.Name = "lbcnt";
            lbcnt.Size = new System.Drawing.Size(112, 101);
            lbcnt.TabIndex = 53;
            lbcnt.Text = "3";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(160, 350);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(164, 87);
            button1.TabIndex = 54;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RSPGame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(button1);
            Controls.Add(lbcnt);
            Controls.Add(lbEndScore);
            Controls.Add(lbCheck);
            Controls.Add(lbscore);
            Controls.Add(label17);
            Controls.Add(proBar);
            Controls.Add(picPaper);
            Controls.Add(picSci);
            Controls.Add(picRock);
            Controls.Add(picQ2);
            Controls.Add(picQ3);
            Controls.Add(picQ1);
            Name = "RSPGame";
            Text = "가위바위보 게임";
            ((System.ComponentModel.ISupportInitialize)picQ2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSci).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQ3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQ1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picQ2;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picSci;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picQ3;
        private System.Windows.Forms.PictureBox picQ1;
        private System.Windows.Forms.Label label17;
        private Moble.LabelProgressBar proBar;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbEndScore;
        private System.Windows.Forms.Label lbcnt;
        private System.Windows.Forms.Button button1;
    }
}