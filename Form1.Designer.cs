namespace MineSweeper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            restartBtn = new Button();
            panel1 = new Panel();
            timerText = new TextBox();
            minesText = new TextBox();
            easyBtn = new Button();
            normalBtn = new Button();
            hardBtn = new Button();
            SuspendLayout();
            // 
            // restartBtn
            // 
            restartBtn.Anchor = AnchorStyles.Top;
            restartBtn.BackgroundImage = Properties.Resources.Defeat_Icon;
            restartBtn.BackgroundImageLayout = ImageLayout.Zoom;
            restartBtn.Location = new Point(97, 12);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(63, 59);
            restartBtn.TabIndex = 0;
            restartBtn.Text = " ";
            restartBtn.UseVisualStyleBackColor = false;
            restartBtn.Click += restartBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 243);
            panel1.TabIndex = 1;
            // 
            // timerText
            // 
            timerText.Location = new Point(166, 31);
            timerText.Name = "timerText";
            timerText.Size = new Size(72, 23);
            timerText.TabIndex = 2;
            timerText.TextAlign = HorizontalAlignment.Center;
            timerText.TextChanged += textBox1_TextChanged;
            // 
            // minesText
            // 
            minesText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minesText.Location = new Point(19, 31);
            minesText.Name = "minesText";
            minesText.Size = new Size(72, 23);
            minesText.TabIndex = 3;
            minesText.TextAlign = HorizontalAlignment.Center;
            minesText.TextChanged += minesText_TextChanged;
            // 
            // easyBtn
            // 
            easyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            easyBtn.Location = new Point(9, 326);
            easyBtn.Name = "easyBtn";
            easyBtn.Size = new Size(63, 25);
            easyBtn.TabIndex = 1;
            easyBtn.Text = "Easy";
            easyBtn.UseVisualStyleBackColor = false;
            easyBtn.Click += easyBtn_Click;
            // 
            // normalBtn
            // 
            normalBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            normalBtn.Location = new Point(78, 326);
            normalBtn.Name = "normalBtn";
            normalBtn.Size = new Size(63, 25);
            normalBtn.TabIndex = 4;
            normalBtn.Text = "Normal";
            normalBtn.UseVisualStyleBackColor = false;
            normalBtn.Click += normalBtn_Click;
            // 
            // hardBtn
            // 
            hardBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hardBtn.Location = new Point(147, 326);
            hardBtn.Name = "hardBtn";
            hardBtn.Size = new Size(63, 25);
            hardBtn.TabIndex = 2;
            hardBtn.Text = "Hard";
            hardBtn.UseVisualStyleBackColor = false;
            hardBtn.UseWaitCursor = true;
            hardBtn.Click += hardBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 363);
            Controls.Add(hardBtn);
            Controls.Add(normalBtn);
            Controls.Add(easyBtn);
            Controls.Add(minesText);
            Controls.Add(timerText);
            Controls.Add(panel1);
            Controls.Add(restartBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "MineSweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button restartBtn;
        private Panel panel1;
        private Button button2;
        private FieldButton fieldButton1;
        private TextBox timerText;
        private TextBox minesText;
        private Button easyBtn;
        private Button normalBtn;
        private Button hardBtn;
    }
}
