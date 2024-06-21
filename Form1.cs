using System.Collections.Generic;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer gameTimer;
        private int secondsElapsed;
        public int minesCount = 15;

        List<List<FieldButton>> _buttons;
        public Form1()
        {
            InitializeComponent();
            _buttons = new List<List<FieldButton>>();
            for (int i = 0; i < 10; i++)
            {
                List<FieldButton> row = new List<FieldButton>();
                for (int j = 0; j < 10; j++)
                {
                    FieldButton btn = new FieldButton(_buttons, this);
                    btn.Pos = new Point(i, j);
                    //btn.IsMine = (i + j) % 2 == 0;
                    panel1.Controls.Add(btn);
                    row.Add(btn);
                }
                _buttons.Add(row);
            }
            placeMines();

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += new EventHandler(gameTimer_Tick);
            secondsElapsed = 0;
            timerText.Text = "0";
            minesText.Text = minesCount.ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            timerText.Text = secondsElapsed.ToString();
        }

        void placeMines()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _buttons[i][j].IsOpen = false;
                    _buttons[i][j].IsMine = false;
                }
            }

            Random random = new Random();
            int minesPlaced = 0;

            while (minesPlaced < minesCount)
            {
                int randomX = random.Next(0, _buttons.Count);
                int randomY = random.Next(0, _buttons[0].Count);

                if (_buttons[randomX][randomY].IsMine)
                {
                    continue;
                }

                _buttons[randomX][randomY].IsMine = true;
                minesPlaced++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            secondsElapsed = 0;
            timerText.Text = "0";
            placeMines();
        }

        public void GameOver()
        {
            gameTimer.Stop();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (_buttons[i][j].IsMine)
                    {
                        _buttons[i][j].IsOpen = true;
                    }
                }
            }
        }

        public void FieldButtonClicked(FieldButton btn)
        {
            int h = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (_buttons[i][j].Text == "F")
                    {
                        h++;
                    }
                }
            }
            minesText.Text = (minesCount - h).ToString();
            if (!gameTimer.Enabled)
            {
                gameTimer.Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
