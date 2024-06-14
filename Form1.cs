using System.Collections.Generic;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
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
                    FieldButton btn = new FieldButton(_buttons);
                    btn.Pos = new Point(i, j);
                    //btn.IsMine = (i + j) % 2 == 0;
                    panel1.Controls.Add(btn);
                    row.Add(btn);
                }
                _buttons.Add(row);
            }
            placeMines();
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
            int totalMines = 15;

            while (minesPlaced < totalMines)
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
            placeMines();
        }
    }
}
