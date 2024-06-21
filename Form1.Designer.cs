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
            restartBtn = new Button();
            panel1 = new Panel();
            timerText = new TextBox();
            minesText = new TextBox();
            SuspendLayout();
            // 
            // restartBtn
            // 
            restartBtn.Location = new Point(179, 12);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(63, 59);
            restartBtn.TabIndex = 0;
            restartBtn.Text = "Restart";
            restartBtn.UseVisualStyleBackColor = false;
            restartBtn.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 361);
            panel1.TabIndex = 1;
            // 
            // timerText
            // 
            timerText.Location = new Point(12, 31);
            timerText.Name = "timerText";
            timerText.Size = new Size(100, 23);
            timerText.TabIndex = 2;
            timerText.TextAlign = HorizontalAlignment.Center;
            timerText.TextChanged += textBox1_TextChanged;
            // 
            // minesText
            // 
            minesText.Location = new Point(323, 31);
            minesText.Name = "minesText";
            minesText.Size = new Size(100, 23);
            minesText.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(minesText);
            Controls.Add(timerText);
            Controls.Add(panel1);
            Controls.Add(restartBtn);
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
    }
}
