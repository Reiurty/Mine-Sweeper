using System.Collections.Generic;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer gameTimer;
        private int secondsElapsed;
        public int minesCount = 10;
        int fieldWidth = 9, fieldHeight = 9;
        public bool gameOver = false;

        List<List<FieldButton>> _buttons;
        public Form1()
        {
            InitializeComponent();

            
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += new EventHandler(gameTimer_Tick);
            secondsElapsed = 0;

            easyBtn_Click(null, null);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            timerText.Text = secondsElapsed.ToString();
        }

        void placeMines()
        {
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
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
        private void restartBtn_Click(object sender, EventArgs e)
        {
            gameOver = false;
            restartBtn.BackgroundImage = Properties.Resources.Usual_Icon;
            gameTimer.Stop();
            secondsElapsed = 0;
            timerText.Text = "0";

            placeMines();
        }

        public void GameOver()
        {
            restartBtn.BackgroundImage = Properties.Resources.Defeat_Icon;
            gameTimer.Stop();
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
                {
                    if (_buttons[i][j].IsMine)
                    {
                        _buttons[i][j].IsOpen = true;
                    }
                }
            }
            gameOver = true;
        }

        public void FieldButtonClicked(FieldButton btn)
        {
            int h = 0;
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
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

            bool victory = true;
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
                {

                    if (_buttons[i][j].IsOpen)
                    {
                        if (_buttons[i][j].IsMine)
                        {
                            victory = false;
                            break;
                        }
                    }
                    else
                    {
                        if (_buttons[i][j].Text != "F")
                        {
                            victory = false; 
                            break;
                        }
                    }
                    //if ((_buttons[i][j].IsOpen && _buttons[i][j].IsMine) || (!_buttons[i][j].IsOpen && _buttons[i][j].Text != "F"))
                }
            }

            if (victory)
            {
                gameOver = true;
                gameTimer.Stop();
                restartBtn.BackgroundImage = Properties.Resources.Victory_Icon;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void setField(int width, int heigth, int mines)
        {
            fieldWidth = width;
            fieldHeight = heigth;
            minesCount = mines;

            panel1.Controls.Clear();
            _buttons = new List<List<FieldButton>>();
            for (int i = 0; i < fieldWidth; i++)
            {
                List<FieldButton> row = new List<FieldButton>();
                for (int j = 0; j < fieldHeight; j++)
                {
                    FieldButton btn = new FieldButton(_buttons, this);
                    btn.Pos = new Point(i, j);
                    panel1.Controls.Add(btn);
                    row.Add(btn);
                }
                _buttons.Add(row);
            }

            restartBtn_Click(null, null);
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            setField(9, 9, 10);
            this.Size = new Size(283, 404);
            minesText.Location = new Point(177, 31);
            timerText.Location = new Point(19, 31);
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            setField(16, 16, 40);
            this.Size = new Size(472, 598);
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            setField(30, 16, 99);
            this.Size = new Size(848, 598);
        }

        private void minesText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
