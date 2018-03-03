using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Command
{
    enum Field { Empty, X, O }

    class TicTacToe
    {
        private static GameField Game;
        public bool winner = false;
        public int sum = 9;
        public int current;
        public Stack<int> X;
        public Stack<int> Y;

        public TicTacToe(Field current)
        {
            this.current = Convert.ToInt32(current);
            X = new Stack<int>();
            Y = new Stack<int>();

            Game = GameField.GetInstance();
        }

        public void SetMove(int x, int y, Button button)
        {
            if (Game.field[x, y] == Field.Empty)
            {
                X.Push(x);
                Y.Push(y);
                Playing(x, y, button);
            }
        }

        public void Playing(int x, int y, Button button)
        {
            if (current % 2 == 0)
            {
                current++;
                sum--;
                Game.field[x, y] = Field.O;
                button.Text = "O";
                button.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                current++;
                sum--;
                Game.field[x, y] = Field.X;
                button.Text = "X";
                button.ForeColor = System.Drawing.Color.Green;
            }
            Scan();
        }

        private void Scan()
        {
            //X
            if (Game.field[0, 0] == Field.X && Game.field[0, 1] == Field.X && Game.field[0, 2] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[1, 0] == Field.X && Game.field[1, 1] == Field.X && Game.field[1, 2] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[2, 0] == Field.X && Game.field[2, 1] == Field.X && Game.field[2, 2] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 0] == Field.X && Game.field[1, 1] == Field.X && Game.field[2, 2] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 2] == Field.X && Game.field[1, 1] == Field.X && Game.field[2, 0] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 0] == Field.X && Game.field[1, 0] == Field.X && Game.field[2, 0] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 1] == Field.X && Game.field[1, 1] == Field.X && Game.field[2, 1] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 2] == Field.X && Game.field[1, 2] == Field.X && Game.field[2, 2] == Field.X)
            {
                winner = true;
                MessageBox.Show("Player 'X' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Y
            else if (Game.field[0, 0] == Field.O && Game.field[0, 1] == Field.O && Game.field[0, 2] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[1, 0] == Field.O && Game.field[1, 1] == Field.O && Game.field[1, 2] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[2, 0] == Field.O && Game.field[2, 1] == Field.O && Game.field[2, 2] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 0] == Field.O && Game.field[1, 1] == Field.O && Game.field[2, 2] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 2] == Field.O && Game.field[1, 1] == Field.O && Game.field[2, 0] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (winner == false && sum == 0)
                MessageBox.Show("Draw !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (Game.field[0, 0] == Field.O && Game.field[1, 0] == Field.O && Game.field[2, 0] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 1] == Field.O && Game.field[1, 1] == Field.O && Game.field[2, 1] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Game.field[0, 2] == Field.O && Game.field[1, 2] == Field.O && Game.field[2, 2] == Field.O)
            {
                winner = true;
                MessageBox.Show("Player 'O' Win !", "Informathion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
