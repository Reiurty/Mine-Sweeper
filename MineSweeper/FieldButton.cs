using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{

    public partial class FieldButton : Button
    {
        private int _x, _y;
        private bool _isMine = true;
        private bool _isOpen = false;
        private Form1 _form;
        private List<List<FieldButton>> _buttons;

        public bool IsMine
        {
            get => _isMine;
            set
            {
                _isMine = value;
                IsOpen = IsOpen;
            }
        }

        int CalcMines()
        {
            int count = 0;
            for (int i = _x - 1; i <= _x + 1; i++)
            {
                if (i < 0 || i >= _buttons.Count)
                {
                    continue;
                }
                for (int j = _y - 1; j <= _y + 1; j++)
                {
                    if (j < 0 || j >= _buttons[0].Count)
                    {
                        continue;
                    }
                    if (_buttons[i][j].IsMine)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        void OpenNeighbors()
        {
            for (int i = _x - 1; i <= _x + 1; i++)
            {
                if (i < 0 || i >= _buttons.Count)
                {
                    continue;
                }
                for (int j = _y - 1; j <= _y + 1; j++)
                {
                    if (j < 0 || j >= _buttons[0].Count)
                    {
                        continue;
                    }
                    if (_buttons[i][j].IsOpen)
                    {
                        continue;
                    }
                    _buttons[i][j].IsOpen = true;
                }
            }
        }

        public bool IsOpen
        {
            get => _isOpen;
            set
            {
                _isOpen = value;
                if (!_isOpen)
                {
                    Text = " ";
                }
                else
                {
                    if (_isMine)
                    {
                        Text = "☼";
                    }
                    else
                    {
                        int count = CalcMines();
                        Text = count == 0 ? " " : count.ToString();
                        if (count == 0)
                        {
                            OpenNeighbors();
                        }
                    }
                }
                FlatStyle = _isOpen ? FlatStyle.Flat : FlatStyle.Standard;
            }
        }

        public Point Pos
        {
            get => new(_x, _y);
            set
            {
                _x = value.X;
                _y = value.Y;
                Location = new Point(_x * 27, _y * 27);
            }
        }

        public FieldButton(List<List<FieldButton>> buttons, Form1 form)
        {
            InitializeComponent();
            Size = new Size(25, 25);
            _buttons = buttons;
            _form = form;
        }

        private void FieldButton_Click(object sender, EventArgs e)
        {
            IsOpen = true;
            _form.FieldButtonClicked(this);
            if (IsMine)
            {
                _form.GameOver();
            }
        }

        private void FieldButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            if (IsOpen)
            {
                return;
            }
            Text = Text == "F" ? " " : "F";
            _form.FieldButtonClicked(this);
        }
    }
}
